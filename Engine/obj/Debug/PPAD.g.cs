﻿#pragma checksum "..\..\PPAD.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07732A946A1A20DFCC0C86205BCF0E63"
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
using TestNewEngineWPF;


namespace TestNewEngineWPF {
    
    
    /// <summary>
    /// PPAD
    /// </summary>
    public partial class PPAD : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TestNewEngineWPF.PPAD Move;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button start;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button end;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button previous;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zIN;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zOut;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button first;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button last;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PPAD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button draw;
        
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
            System.Uri resourceLocater = new System.Uri("/TestNewEngineWPF;component/ppad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PPAD.xaml"
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
            this.Move = ((TestNewEngineWPF.PPAD)(target));
            return;
            case 2:
            this.start = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\PPAD.xaml"
            this.start.Click += new System.Windows.RoutedEventHandler(this.start_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.end = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\PPAD.xaml"
            this.end.Click += new System.Windows.RoutedEventHandler(this.end_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.previous = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\PPAD.xaml"
            this.previous.Click += new System.Windows.RoutedEventHandler(this.previous_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\PPAD.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.zIN = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\PPAD.xaml"
            this.zIN.Click += new System.Windows.RoutedEventHandler(this.zIn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.zOut = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\PPAD.xaml"
            this.zOut.Click += new System.Windows.RoutedEventHandler(this.zOut_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.first = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\PPAD.xaml"
            this.first.Click += new System.Windows.RoutedEventHandler(this.first_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.last = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\PPAD.xaml"
            this.last.Click += new System.Windows.RoutedEventHandler(this.last_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.draw = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\PPAD.xaml"
            this.draw.Click += new System.Windows.RoutedEventHandler(this.draw_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

