﻿#pragma checksum "..\..\..\DataBase\ConnectSettingDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5ADFA575B239D3D0BDEDCF3078BFB68141AD774C93FE953353C964BE14F425C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Plugins.Shared.Library.Controls;
using RPA.Integration.Activities.Database;
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


namespace RPA.Integration.Activities.Database {
    
    
    /// <summary>
    /// ConnectSettingDialog
    /// </summary>
    public partial class ConnectSettingDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\DataBase\ConnectSettingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleText;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\DataBase\ConnectSettingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\DataBase\ConnectSettingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NewConn1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\DataBase\ConnectSettingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWizard;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\DataBase\ConnectSettingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Activities.Presentation.View.ExpressionTextBox etb;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\DataBase\ConnectSettingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\DataBase\ConnectSettingDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
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
            System.Uri resourceLocater = new System.Uri("/RPA.Integration.Activities;component/database/connectsettingdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DataBase\ConnectSettingDialog.xaml"
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
            this.TitleText = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\DataBase\ConnectSettingDialog.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NewConn1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnWizard = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\DataBase\ConnectSettingDialog.xaml"
            this.btnWizard.Click += new System.Windows.RoutedEventHandler(this.btnWizard_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.etb = ((System.Activities.Presentation.View.ExpressionTextBox)(target));
            return;
            case 6:
            this.comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 76 "..\..\..\DataBase\ConnectSettingDialog.xaml"
            this.comboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\DataBase\ConnectSettingDialog.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

