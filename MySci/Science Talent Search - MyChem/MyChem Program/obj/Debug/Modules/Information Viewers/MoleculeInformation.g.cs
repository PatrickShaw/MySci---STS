﻿#pragma checksum "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "62C31EEED190554D66979D8C2303AD91"
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
    /// MoleculeInformation
    /// </summary>
    public partial class MoleculeInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFormula;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMolecularMass;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAmount;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMolecularMass_Copy;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbUnit;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbUnitWanted;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMolecule;
        
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
            System.Uri resourceLocater = new System.Uri("/MyChem Program;component/modules/information%20viewers/moleculeinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
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
            this.lblFormula = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblMolecularMass = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtAmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
            this.txtAmount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtAmount_TextChanged);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
            this.txtAmount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtAmount_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblMolecularMass_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.cmbUnit = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
            this.cmbUnit.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbUnit_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbUnitWanted = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
            this.cmbUnitWanted.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbUnitWanted_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 47 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.grdMolecule = ((System.Windows.Controls.Grid)(target));
            
            #line 48 "..\..\..\..\Modules\Information Viewers\MoleculeInformation.xaml"
            this.grdMolecule.Initialized += new System.EventHandler(this.grdMolecule_Initialized);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

