﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E58D288CB73BA97071ED4FC9073B81607B985F3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ADO_Disconnected_WPF;
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


namespace ADO_Disconnected_WPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QueryBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExecuteTrigger;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridView;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button execDataSet;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button customUpdate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ADO_Disconnected_WPF;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((ADO_Disconnected_WPF.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.QueryBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\MainWindow.xaml"
            this.QueryBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.QueryBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\MainWindow.xaml"
            this.QueryBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.QueryBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExecuteTrigger = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.ExecuteTrigger.Click += new System.Windows.RoutedEventHandler(this.ExecuteTrigger_Click);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.ExecuteTrigger.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ExecuteTrigger_MouseEnter);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.ExecuteTrigger.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ExecuteTrigger_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGridView = ((System.Windows.Controls.DataGrid)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.DataGridView.MouseEnter += new System.Windows.Input.MouseEventHandler(this.dbDataView_MouseEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.DataGridView.MouseLeave += new System.Windows.Input.MouseEventHandler(this.dbDataView_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.execDataSet = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.execDataSet.Click += new System.Windows.RoutedEventHandler(this.execDataSet_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.customUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.customUpdate.Click += new System.Windows.RoutedEventHandler(this.customUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LogBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.LogBox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.LogBox_MouseEnter);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.LogBox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.LogBox_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

