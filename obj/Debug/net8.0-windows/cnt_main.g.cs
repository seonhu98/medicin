﻿#pragma checksum "..\..\..\cnt_main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0EA445127FD6211CD4B7C72E68959E3D566BEFDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using MedicineInfo;
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


namespace MedicineInfo {
    
    
    /// <summary>
    /// cnt_main
    /// </summary>
    public partial class cnt_main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\cnt_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Survey;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\cnt_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Consult;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\cnt_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_QnA;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\cnt_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_drug;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\cnt_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button info_search;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MedicineInfo;component/cnt_main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\cnt_main.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btn_Survey = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\cnt_main.xaml"
            this.btn_Survey.Click += new System.Windows.RoutedEventHandler(this.btn_Survey_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Consult = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\cnt_main.xaml"
            this.btn_Consult.Click += new System.Windows.RoutedEventHandler(this.btn_Consult_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_QnA = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\cnt_main.xaml"
            this.btn_QnA.Click += new System.Windows.RoutedEventHandler(this.btn_QnA_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_drug = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\cnt_main.xaml"
            this.btn_drug.Click += new System.Windows.RoutedEventHandler(this.btn_drug_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.info_search = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\cnt_main.xaml"
            this.info_search.Click += new System.Windows.RoutedEventHandler(this.info_search_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
