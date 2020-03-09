﻿using System;
using System.Activities;
using System.ComponentModel;
using Plugins.Shared.Library;

namespace RPA.UIAutomation.Activities.Window
{
    [Designer(typeof(WindowMaxiDesigner))]
    public sealed class WindowMaxi : AsyncCodeActivity
    {
        public new string DisplayName
        {
            get
            {
                return "Window Max";
            }
        }

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);
        }

        [Browsable(false)]
        public Window currWindow { get; set; }

        //[RequiredArgument]
        [Category("公共")]
        [DisplayName("错误执行")]
        [Description("指定即使活动引发错误，自动化是否仍应继续")]
        public InArgument<bool> ContinueOnError { get; set; }

        [Category("选项")]
        [Browsable(true)]
        [DisplayName("窗口")]
        [Description("存储窗口的变量。该字段仅接受Window变量")]
        public InArgument<Window> ActiveWindow { get; set; }

        [Browsable(false)]
        public string icoPath
        {
            get
            {
                return @"pack://application:,,,/RPA.UIAutomation.Activities;Component/Resources/Window/WindowMaxi.png";
            }
        }


        [Browsable(false)]
        public string ClassName { get { return "WindowMaxi"; } }

        private delegate string runDelegate();
        private runDelegate m_Delegate;
        public string Run()
        {
            return ClassName;
        }

        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state)
        {
            Window Windowmaxi = ActiveWindow.Get(context);
            try
            {
                if (Windowmaxi != null)
                {
                    Win32Api.SendMessage((IntPtr)Windowmaxi.getWindowHwnd(), Win32Api.WM_SYSCOMMAND, (IntPtr)Win32Api.SC_MAXIMIZE, IntPtr.Zero);
                }
                else
                {
                    PropertyDescriptor property = context.DataContext.GetProperties()[WindowActive.OpenBrowsersPropertyTag];
                    if (property == null)
                        property = context.DataContext.GetProperties()[WindowAttach.OpenBrowsersPropertyTag];
                    if (property != null)
                    {
                        Window getBrowser = property.GetValue(context.DataContext) as Window;
                        Win32Api.SendMessage((IntPtr)getBrowser.getWindowHwnd(), Win32Api.WM_SYSCOMMAND, (IntPtr)Win32Api.SC_MAXIMIZE, IntPtr.Zero);
                    } 
                }
            }
            catch (Exception e)
            {
                SharedObject.Instance.Output(SharedObject.enOutputType.Error, "关闭窗口错误产生", e.Message);
                if (ContinueOnError.Get(context))
                {
                }
                else
                {
                    throw;
                }
            }

            m_Delegate = new runDelegate(Run);
            return m_Delegate.BeginInvoke(callback, state);
        }

        protected override void EndExecute(AsyncCodeActivityContext context, IAsyncResult result)
        {
        }

    }
}
