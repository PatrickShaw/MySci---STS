﻿#pragma checksum "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A152A60B15DE9B1298315E6A5B13E40"
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


namespace MyChem_Program.Modules.Calculators {
    
    
    /// <summary>
    /// MolarConcentrationBox
    /// </summary>
    public partial class MolarConcentrationBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMolConcentration;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbmolLL;
        
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
            System.Uri resourceLocater = new System.Uri("/MyChem Program;component/modules/calculators/molarconcentrationbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtMolConcentration = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml"
            this.txtMolConcentration.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtMolConcentration_TextChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml"
            this.txtMolConcentration.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtMolConcentration_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbmolLL = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\..\Modules\Calculators\MolarConcentrationBox.xaml"
            this.cmbmolLL.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbmolLL_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

