﻿#pragma checksum "..\..\..\Mouse\ComboBoxWithCheckControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35DC30808D9FDA15DED70D4582B701AB586D91F8D4F9E3B7A5BE9F1D0EAA9365"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using RPA.UIAutomation.Activities.Mouse;
using System;
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


namespace RPA.UIAutomation.Activities.Mouse {
    
    
    /// <summary>
    /// ComboBoxWithCheckControl
    /// </summary>
    public partial class ComboBoxWithCheckControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAlt;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbCtrl;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbShift;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbWin;
        
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
            System.Uri resourceLocater = new System.Uri("/RPA.UIAutomation.Activities;component/mouse/comboboxwithcheckcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
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
            
            #line 10 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            ((System.Windows.Controls.ComboBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.ComboBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbAlt = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbAlt.Checked += new System.Windows.RoutedEventHandler(this.Alt_Checked);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbAlt.Unchecked += new System.Windows.RoutedEventHandler(this.Alt_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbCtrl = ((System.Windows.Controls.CheckBox)(target));
            
            #line 19 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbCtrl.Checked += new System.Windows.RoutedEventHandler(this.Ctrl_Checked);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbCtrl.Unchecked += new System.Windows.RoutedEventHandler(this.Ctrl_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbShift = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbShift.Checked += new System.Windows.RoutedEventHandler(this.Shift_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbShift.Unchecked += new System.Windows.RoutedEventHandler(this.Shift_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbWin = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbWin.Checked += new System.Windows.RoutedEventHandler(this.Win_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\Mouse\ComboBoxWithCheckControl.xaml"
            this.cbWin.Unchecked += new System.Windows.RoutedEventHandler(this.Win_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

