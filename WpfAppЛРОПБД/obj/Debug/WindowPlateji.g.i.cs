﻿#pragma checksum "..\..\WindowPlateji.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F0230008B588BDD411CBC2A0BF1E382D1CBBC9314475F8B8BE1E0FAD1A72473"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfAppЛРОПБД;


namespace WpfAppЛРОПБД {
    
    
    /// <summary>
    /// WindowPlateji
    /// </summary>
    public partial class WindowPlateji : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKlientiki;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDomoi;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeletePL;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DobavitPL;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgPlateji;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchPL;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbUpN;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\WindowPlateji.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDownN;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppЛРОПБД;component/windowplateji.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowPlateji.xaml"
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
            this.btnKlientiki = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\WindowPlateji.xaml"
            this.btnKlientiki.Click += new System.Windows.RoutedEventHandler(this.btnKlientiki_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnDomoi = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\WindowPlateji.xaml"
            this.btnDomoi.Click += new System.Windows.RoutedEventHandler(this.btnDomoi_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeletePL = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\WindowPlateji.xaml"
            this.DeletePL.Click += new System.Windows.RoutedEventHandler(this.DeletePL_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DobavitPL = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\WindowPlateji.xaml"
            this.DobavitPL.Click += new System.Windows.RoutedEventHandler(this.DobavitPL_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtgPlateji = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.txtSearchPL = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\WindowPlateji.xaml"
            this.txtSearchPL.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchPL_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rbUpN = ((System.Windows.Controls.RadioButton)(target));
            
            #line 75 "..\..\WindowPlateji.xaml"
            this.rbUpN.Click += new System.Windows.RoutedEventHandler(this.rbUpN_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rbDownN = ((System.Windows.Controls.RadioButton)(target));
            
            #line 77 "..\..\WindowPlateji.xaml"
            this.rbDownN.Click += new System.Windows.RoutedEventHandler(this.rbDownN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 51 "..\..\WindowPlateji.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditPJ_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

