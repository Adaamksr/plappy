﻿#pragma checksum "..\..\kalender.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8FAFF9B9AB42FF4137014ED99BDAE42109BD4AE388E2979ADE066487CD1612DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Plappy_v1;
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


namespace Plappy_v1 {
    
    
    /// <summary>
    /// kalender
    /// </summary>
    public partial class kalender : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label5;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label6;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label7;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\kalender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label8;
        
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
            System.Uri resourceLocater = new System.Uri("/Plappy-v1;component/kalender.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\kalender.xaml"
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
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\kalender.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label1 = ((System.Windows.Controls.Label)(target));
            
            #line 18 "..\..\kalender.xaml"
            this.label1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Aanwezigheden);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label2 = ((System.Windows.Controls.Label)(target));
            
            #line 19 "..\..\kalender.xaml"
            this.label2.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Leden);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label3 = ((System.Windows.Controls.Label)(target));
            
            #line 20 "..\..\kalender.xaml"
            this.label3.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Speelmomenten);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label4 = ((System.Windows.Controls.Label)(target));
            
            #line 21 "..\..\kalender.xaml"
            this.label4.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Sporthal);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label5 = ((System.Windows.Controls.Label)(target));
            
            #line 22 "..\..\kalender.xaml"
            this.label5.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Kalender);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label6 = ((System.Windows.Controls.Label)(target));
            
            #line 23 "..\..\kalender.xaml"
            this.label6.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Statistieken);
            
            #line default
            #line hidden
            return;
            case 9:
            this.label7 = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\kalender.xaml"
            this.label7.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CoronaAlert);
            
            #line default
            #line hidden
            return;
            case 10:
            this.label8 = ((System.Windows.Controls.Label)(target));
            
            #line 25 "..\..\kalender.xaml"
            this.label8.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Profiel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

