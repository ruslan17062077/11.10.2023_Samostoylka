﻿#pragma checksum "..\..\..\Pages\AddandReg.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C9764C99B827DE539AA7C2ABA2A29C22A4A9B682ADC818217D07E29C812473C"
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
using mvideo.Pages;


namespace mvideo.Pages {
    
    
    /// <summary>
    /// AddandReg
    /// </summary>
    public partial class AddandReg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdTb;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTb;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chenaTb;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox opisaTb;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox discountTb;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel PhotoWp;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddImageBtn;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\AddandReg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
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
            System.Uri resourceLocater = new System.Uri("/mvideo;component/pages/addandreg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddandReg.xaml"
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
            this.IdTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.chenaTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Pages\AddandReg.xaml"
            this.chenaTb.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.chenaTb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.opisaTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.discountTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Pages\AddandReg.xaml"
            this.discountTb.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.chenaTb_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.Edit = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\AddandReg.xaml"
            this.Edit.Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PhotoWp = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 9:
            this.AddImageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Pages\AddandReg.xaml"
            this.AddImageBtn.Click += new System.Windows.RoutedEventHandler(this.AddImageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Pages\AddandReg.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

