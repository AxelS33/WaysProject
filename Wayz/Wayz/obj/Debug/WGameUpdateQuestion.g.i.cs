﻿#pragma checksum "..\..\WGameUpdateQuestion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "895556287F406F48D0E2BBFC288284A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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


namespace Wayz {
    
    
    /// <summary>
    /// WGameUpdateQuestion
    /// </summary>
    public partial class WGameUpdateQuestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\WGameUpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogout;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\WGameUpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdateQuestion;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WGameUpdateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelUpdateQuestion;
        
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
            System.Uri resourceLocater = new System.Uri("/Wayz;component/wgameupdatequestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WGameUpdateQuestion.xaml"
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
            this.BtnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\WGameUpdateQuestion.xaml"
            this.BtnLogout.Click += new System.Windows.RoutedEventHandler(this.BtnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnUpdateQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\WGameUpdateQuestion.xaml"
            this.BtnUpdateQuestion.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCancelUpdateQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\WGameUpdateQuestion.xaml"
            this.BtnCancelUpdateQuestion.Click += new System.Windows.RoutedEventHandler(this.BtnCancelUpdateQuestion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
