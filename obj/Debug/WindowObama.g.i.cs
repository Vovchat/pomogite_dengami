﻿#pragma checksum "..\..\WindowObama.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "36A648CC9E3F29507108CAC33263AEE64653BBC5EDE267FEBC072D316407BE7C"
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
    /// WindowObama
    /// </summary>
    public partial class WindowObama : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 27 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDo;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgProviders;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeletePd;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPd;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgPriceLists;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeletePt;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPt;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbUpPd;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDownPd;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbUpPt;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\WindowObama.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDownPt;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppЛРОПБД;component/windowobama.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowObama.xaml"
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
            this.btnDo = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\WindowObama.xaml"
            this.btnDo.Click += new System.Windows.RoutedEventHandler(this.btnDo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtgProviders = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.DeletePd = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\WindowObama.xaml"
            this.DeletePd.Click += new System.Windows.RoutedEventHandler(this.DeletePd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddPd = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\WindowObama.xaml"
            this.AddPd.Click += new System.Windows.RoutedEventHandler(this.AddPd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dtgPriceLists = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.DeletePt = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\WindowObama.xaml"
            this.DeletePt.Click += new System.Windows.RoutedEventHandler(this.DeletePt_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddPt = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\WindowObama.xaml"
            this.AddPt.Click += new System.Windows.RoutedEventHandler(this.AddPt_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rbUpPd = ((System.Windows.Controls.RadioButton)(target));
            
            #line 93 "..\..\WindowObama.xaml"
            this.rbUpPd.Click += new System.Windows.RoutedEventHandler(this.rbUpPd_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.rbDownPd = ((System.Windows.Controls.RadioButton)(target));
            
            #line 96 "..\..\WindowObama.xaml"
            this.rbDownPd.Click += new System.Windows.RoutedEventHandler(this.rbDownPd_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.rbUpPt = ((System.Windows.Controls.RadioButton)(target));
            
            #line 105 "..\..\WindowObama.xaml"
            this.rbUpPt.Click += new System.Windows.RoutedEventHandler(this.rbUpPt_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.rbDownPt = ((System.Windows.Controls.RadioButton)(target));
            
            #line 108 "..\..\WindowObama.xaml"
            this.rbDownPt.Click += new System.Windows.RoutedEventHandler(this.rbDownPt_Click);
            
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
            case 3:
            
            #line 40 "..\..\WindowObama.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditPd_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 70 "..\..\WindowObama.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditPt_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

