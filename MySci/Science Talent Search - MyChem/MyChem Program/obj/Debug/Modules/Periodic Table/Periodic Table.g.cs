﻿#pragma checksum "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "250825394BB950CDD4264F9F9816EB51"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace MyChem_Program {
    
    
    /// <summary>
    /// Periodic_Table
    /// </summary>
    public partial class Periodic_Table : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas theCanvas;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHelp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel eleWrap;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClear;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOkay;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbColour_Mode;
        
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
            System.Uri resourceLocater = new System.Uri("/MyChem Program;component/modules/periodic%20table/periodic%20table.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
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
            
            #line 7 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
            ((MyChem_Program.Periodic_Table)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.theCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.btnHelp = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
            this.btnHelp.Click += new System.Windows.RoutedEventHandler(this.btnHelp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.eleWrap = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 5:
            this.btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
            this.btnClear.Click += new System.Windows.RoutedEventHandler(this.btnClearElements_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnOkay = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
            this.btnOkay.Click += new System.Windows.RoutedEventHandler(this.btnOkay_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmbColour_Mode = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\..\Modules\Periodic Table\Periodic Table.xaml"
            this.cmbColour_Mode.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbColour_Mode_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

