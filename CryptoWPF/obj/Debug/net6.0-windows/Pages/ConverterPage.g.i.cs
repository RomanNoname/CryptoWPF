﻿#pragma checksum "..\..\..\..\Pages\ConverterPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3AAF82BC1182B0617400ED5CA73C9D241EDD51A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CryptoWPF.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CryptoWPF.Pages {
    
    
    /// <summary>
    /// ConverterPage
    /// </summary>
    public partial class ConverterPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConvertOut;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConvertIn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameCoinOut;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label IN;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameCoinIn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountCoin;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Converted;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CoinsOut;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\ConverterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CoinsIn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CryptoWPF;component/pages/converterpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ConverterPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\Pages\ConverterPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchCoinOut);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ConvertOut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ConvertIn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 17 "..\..\..\..\Pages\ConverterPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchCoinIn);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NameCoinOut = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.IN = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.NameCoinIn = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.CountCoin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 28 "..\..\..\..\Pages\ConverterPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Convert);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Converted = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.CoinsOut = ((System.Windows.Controls.ListView)(target));
            
            #line 33 "..\..\..\..\Pages\ConverterPage.xaml"
            this.CoinsOut.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GetCoinOut);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CoinsIn = ((System.Windows.Controls.ListView)(target));
            
            #line 43 "..\..\..\..\Pages\ConverterPage.xaml"
            this.CoinsIn.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GetCoinIn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

