﻿#pragma checksum "..\..\AddNewGoodsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "29DF403DBC9335749B753D69643C79ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using SalesManageSystem;
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


namespace SalesManageSystem {
    
    
    /// <summary>
    /// AddNewGoodsWindow
    /// </summary>
    public partial class AddNewGoodsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox goodsNumTBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox categoryTBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codeTBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox unitTBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox specificationTBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productionPlaceTBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox versionTBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddNewGoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox remarksTBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SalesManageSystem;component/addnewgoodswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddNewGoodsWindow.xaml"
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
            this.goodsNumTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.categoryTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.codeTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.nameTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.unitTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.specificationTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.productionPlaceTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.versionTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.remarksTBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 57 "..\..\AddNewGoodsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ensureBtnClicked);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 58 "..\..\AddNewGoodsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancelBtnClicked);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 59 "..\..\AddNewGoodsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clearBtnClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

