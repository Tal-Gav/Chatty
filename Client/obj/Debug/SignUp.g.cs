﻿#pragma checksum "..\..\SignUp.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3A6FAF4648C67EFDE931F36453D3C54F8AB658289F3A1E656650731A437CC9A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TalMiniProject___Chatty;


namespace TalMiniProject___Chatty {
    
    
    /// <summary>
    /// SignUp
    /// </summary>
    public partial class SignUp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridi;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle UserBack;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle PassBack;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ConfirmPassBack;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPassBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ChatBtn;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Login;
        
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
            System.Uri resourceLocater = new System.Uri("/TalMiniProject - Chatty;component/signup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SignUp.xaml"
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
            
            #line 12 "..\..\SignUp.xaml"
            ((TalMiniProject___Chatty.SignUp)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\SignUp.xaml"
            ((TalMiniProject___Chatty.SignUp)(target)).MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridi = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.UserBack = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.PassBack = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.ConfirmPassBack = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.ConfirmPassBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 44 "..\..\SignUp.xaml"
            this.ConfirmPassBox.GotFocus += new System.Windows.RoutedEventHandler(this.ConfirmPassBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 44 "..\..\SignUp.xaml"
            this.ConfirmPassBox.LostFocus += new System.Windows.RoutedEventHandler(this.ConfirmPassBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PassBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 45 "..\..\SignUp.xaml"
            this.PassBox.LostFocus += new System.Windows.RoutedEventHandler(this.PassBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 45 "..\..\SignUp.xaml"
            this.PassBox.GotFocus += new System.Windows.RoutedEventHandler(this.PassBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.UserBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\SignUp.xaml"
            this.UserBox.LostFocus += new System.Windows.RoutedEventHandler(this.UserBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\SignUp.xaml"
            this.UserBox.GotFocus += new System.Windows.RoutedEventHandler(this.UserBox_GotFocus_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ChatBtn = ((System.Windows.Controls.Label)(target));
            
            #line 47 "..\..\SignUp.xaml"
            this.ChatBtn.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ChatBtn_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Login = ((System.Windows.Controls.Label)(target));
            
            #line 48 "..\..\SignUp.xaml"
            this.Login.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Login_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

