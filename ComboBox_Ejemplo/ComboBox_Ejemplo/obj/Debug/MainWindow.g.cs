﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71C2B93C1715C0451D99139C53AB4D900A2D22004FE4DEAB7E2240BAD6F8BF08"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ComboBox_Ejemplo;
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


namespace ComboBox_Ejemplo {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Capitales;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox TodasC;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Madrid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Sucre;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Bogota;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Lima;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Santiago;
        
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
            System.Uri resourceLocater = new System.Uri("/ComboBox_Ejemplo;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Capitales = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.TodasC = ((System.Windows.Controls.CheckBox)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.TodasC.Checked += new System.Windows.RoutedEventHandler(this.TodasC_Checked);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MainWindow.xaml"
            this.TodasC.Unchecked += new System.Windows.RoutedEventHandler(this.TodasC_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Madrid = ((System.Windows.Controls.CheckBox)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.Madrid.Checked += new System.Windows.RoutedEventHandler(this.Individual_checked);
            
            #line default
            #line hidden
            
            #line 44 "..\..\MainWindow.xaml"
            this.Madrid.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_noChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Sucre = ((System.Windows.Controls.CheckBox)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.Sucre.Checked += new System.Windows.RoutedEventHandler(this.Individual_checked);
            
            #line default
            #line hidden
            
            #line 45 "..\..\MainWindow.xaml"
            this.Sucre.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_noChecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Bogota = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.Bogota.Checked += new System.Windows.RoutedEventHandler(this.Individual_checked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MainWindow.xaml"
            this.Bogota.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_noChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Lima = ((System.Windows.Controls.CheckBox)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.Lima.Checked += new System.Windows.RoutedEventHandler(this.Individual_checked);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.Lima.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_noChecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Santiago = ((System.Windows.Controls.CheckBox)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.Santiago.Checked += new System.Windows.RoutedEventHandler(this.Individual_checked);
            
            #line default
            #line hidden
            
            #line 48 "..\..\MainWindow.xaml"
            this.Santiago.Unchecked += new System.Windows.RoutedEventHandler(this.Individual_noChecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

