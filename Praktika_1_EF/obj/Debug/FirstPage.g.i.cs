﻿#pragma checksum "..\..\FirstPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63AD1D400F8366805FDE714E0C471CD08CFDDAE698CBEE77477D3222C0740C73"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Praktika_1_EF;
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


namespace Praktika_1_EF {
    
    
    /// <summary>
    /// FirstPage
    /// </summary>
    public partial class FirstPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid NAME_COFFEEDataGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insert;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button poick_dan;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filter_dani;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filter_dan;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox poick;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Praktika_1_EF;component/firstpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FirstPage.xaml"
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
            this.NAME_COFFEEDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.insert = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\FirstPage.xaml"
            this.insert.Click += new System.Windows.RoutedEventHandler(this.insert_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\FirstPage.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.update = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\FirstPage.xaml"
            this.update.Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.poick_dan = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\FirstPage.xaml"
            this.poick_dan.Click += new System.Windows.RoutedEventHandler(this.poick_dan_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.filter_dani = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\FirstPage.xaml"
            this.filter_dani.Click += new System.Windows.RoutedEventHandler(this.filter_dani_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.filter_dan = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\FirstPage.xaml"
            this.filter_dan.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filter_dan_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.poick = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.addressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
