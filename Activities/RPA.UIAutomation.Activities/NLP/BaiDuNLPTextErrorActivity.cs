﻿using Plugins.Shared.Library;
using System;
using System.Activities;
using System.ComponentModel;

namespace RPA.UIAutomation.Activities.NLP
{
    /// <summary>
    /// 文本纠错
    /// </summary>
    [Designer(typeof(BaiDuNLPTextErrorDesigner))]
    public sealed class BaiDuNLPTextErrorActivity : CodeActivity
    {
        public new string DisplayName;
        [Browsable(false)]
        public string _DisplayName { get { return "BaiDuNLP"; } }

        [Category("输入")]
        [RequiredArgument]
        [Browsable(true)]
        [Description("您的APIKey。")]
        public InArgument<string> APIKey { get; set; }

        [Category("输入")]
        [RequiredArgument]
        [Browsable(true)]
        [Description("您的SecretKey。")]
        public InArgument<string> SecretKey { get; set; }

        [Category("输入")]
        [RequiredArgument]
        [Browsable(true)]
        [Description("待纠错文本，输入限制511字节。")]
        public InArgument<string> Text { get; set; }

        [Category("输出")]
        [Browsable(true)]
        [Description("提示错误并给出正确的文本结果。")]
        public OutArgument<string> Result { get; set; }

        [Browsable(false)]
        public string icoPath
        {
            get
            {
                return @"pack://application:,,,/RPA.UIAutomation.Activities;Component/Resources/NLP/nlp.png";
            }
        }

        protected override void Execute(CodeActivityContext context)
        {
            string text = Text.Get(context);
            string apiKey = APIKey.Get(context);
            string seKey = SecretKey.Get(context);
            try
            {
                var client = new Baidu.Aip.Nlp.Nlp(apiKey, seKey);
                //修改超时时间
                client.Timeout = 60000;
                //调用文本纠错
                string result = client.Ecnet(text).ToString();
                Result.Set(context, result);
            }
            catch (Exception e)
            {
                SharedObject.Instance.Output(SharedObject.enOutputType.Error, "有一个错误产生", e.Message);
            }
        }
    }
}
