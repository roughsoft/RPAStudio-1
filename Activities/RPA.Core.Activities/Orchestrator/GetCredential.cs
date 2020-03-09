﻿using System.Activities;
using System.ComponentModel;
using System;
using Plugins.Shared.Library;
using System.Security;
using System.Runtime.InteropServices;
using System.Threading;

namespace RPA.Core.Activities.OrchestratorActivity
{
    [Designer(typeof(GetCredentialDesigner))]
    public sealed class GetCredential : CodeActivity
    {
        public new string DisplayName
        {
            get
            {
                return "Get Credential";
            }
        }

        [Browsable(false)]
        public string icoPath { get { return "pack://application:,,,/RPA.Core.Activities;Component/Resources/Orchestrator/Credential.png"; } }


        [Category("选项")]
        [RequiredArgument]
        [DisplayName("凭据名称")]
        [Browsable(true)]
        [Description(" 系统中获取的凭据名称")]
        public InArgument<string> CredentialName
        {
            get;
            set;
        }

        [Category("选项")]
        [DisplayName("超时时间(毫秒)")]
        [Browsable(true)]
        [Description(" 指定在引发错误之前等待活动运行的时间量（以毫秒为单位）。默认值为30000毫秒（30秒）")]
        public InArgument<Int32> TimeoutMS
        {
            get;
            set;
        }

        [Category("输出")]
        [DisplayName("密码")]
        [Browsable(true)]
        [Description(" 检索到的凭证的安全密码")]
        public OutArgument<SecureString> PassWord
        {
            get;
            set;
        }

        [Category("输出")]
        [DisplayName("用户名")]
        [Browsable(true)]
        [Description(" 检索到的凭证的用户名")]
        public OutArgument<string> UserName
        {
            get;
            set;
        }


        [DllImport("Advapi32.dll", EntryPoint = "CredReadW", CharSet = CharSet.Unicode, SetLastError = true)]
        //读取凭据信息 
        static extern bool CredRead(string target, CRED_TYPE type, int reservedFlag, out IntPtr CredentialPtr);

        CountdownEvent latch;
        private void refreshData(CountdownEvent latch)
        {
            latch.Signal();
        }


        protected override void Execute(CodeActivityContext context)
        {
            Int32 _timeout = TimeoutMS.Get(context);
            CallWithTimeout(new Action(() => {
                try
                {
                    string credName = CredentialName.Get(context);
                    IntPtr credPtr = new IntPtr();
                    WReadCred(credName, CRED_TYPE.GENERIC, CRED_PERSIST.LOCAL_MACHINE, out credPtr);
                    if (credPtr.ToInt32() == 0)
                    {
                        SharedObject.Instance.Output(SharedObject.enOutputType.Error, "凭证不存在");
                        return;
                    }
                    Credential lRawCredential = (Credential)Marshal.PtrToStructure(credPtr, typeof(Credential));
                    SecureString securePassWord = new SecureString();
                    foreach (char c in lRawCredential.CredentialBlob)
                    {
                        securePassWord.AppendChar(c);
                    }
                    UserName.Set(context, lRawCredential.UserName);
                    PassWord.Set(context, securePassWord);
                }catch (Exception e)
                {
                    SharedObject.Instance.Output(SharedObject.enOutputType.Error, "读取凭证执行过程出错", e.Message);
                }

            }), _timeout);
        }

        private void CallWithTimeout(Action action, int timeoutMilliseconds)
        {
            Thread threadToKill = null;
            Action wrappedAction = () =>
            {
                threadToKill = Thread.CurrentThread;
                action();
            };

            IAsyncResult result = wrappedAction.BeginInvoke(null, null);
            if (result.AsyncWaitHandle.WaitOne(timeoutMilliseconds))
            {
                wrappedAction.EndInvoke(result);
            }
            else
            {
                threadToKill.Abort();
                throw new TimeoutException();
            }
        }

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CredEnumerate(string filter, uint flag, out uint count, out IntPtr pCredentials);

        public static bool WReadCred(string targetName, CRED_TYPE credType, CRED_PERSIST reservedFlag, out IntPtr intPtr)
        {
            return CredRead(targetName, credType, (int)reservedFlag, out intPtr);
        }
    }
}
