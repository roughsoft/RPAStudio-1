﻿#pragma checksum "..\..\..\Mail\SaveMailAttachmentsDesigner.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7CE79AF2D3A88024ABA3162C30FF2601F68F1215603E08D39EFB3D61FACC4BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MimeKit;
using Plugins.Shared.Library.Controls;
using RPA.Integration.Activities.Mail;
using System;
using System.Activities.Presentation;
using System.Activities.Presentation.Converters;
using System.Activities.Presentation.View;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RPA.Integration.Activities.Mail {
    
    
    /// <summary>
    /// SaveMailAttachmentsDesigner
    /// </summary>
    public partial class SaveMailAttachmentsDesigner : System.Activities.Presentation.ActivityDesigner, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Mail\SaveMailAttachmentsDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Activities.Presentation.View.ExpressionTextBox expressTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Mail\SaveMailAttachmentsDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Activities.Presentation.View.ExpressionTextBox expressTextBox1;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Mail\SaveMailAttachmentsDesigner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button getUrlButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RPA.Integration.Activities;component/mail/savemailattachmentsdesigner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Mail\SaveMailAttachmentsDesigner.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.expressTextBox = ((System.Activities.Presentation.View.ExpressionTextBox)(target));
            return;
            case 2:
            this.expressTextBox1 = ((System.Activities.Presentation.View.ExpressionTextBox)(target));
            return;
            case 3:
            this.getUrlButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Mail\SaveMailAttachmentsDesigner.xaml"
            this.getUrlButton.Click += new System.Windows.RoutedEventHandler(this.PathSelect);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

