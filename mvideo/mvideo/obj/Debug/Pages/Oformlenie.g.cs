﻿#pragma checksum "..\..\..\Pages\Oformlenie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C0F37067EFA211F57236DCDC65EFC1BFBECFE9E9A7CF916BDEA07FD8F289204"
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
    /// Oformlenie
    /// </summary>
    public partial class Oformlenie : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\Pages\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTB;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTB;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CityTB;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StreetTB;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HomeTB;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OtmenaBtn;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\Oformlenie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OfotmitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/mvideo;component/pages/oformlenie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Oformlenie.xaml"
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
            this.NameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PhoneTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CityTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.StreetTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.HomeTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.OtmenaBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.OfotmitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Pages\Oformlenie.xaml"
            this.OfotmitBtn.Click += new System.Windows.RoutedEventHandler(this.OfotmitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

