﻿#pragma checksum "C:\Users\EvaldoRC\documents\visual studio 2010\Projects\UniMoodle\UniMoodle\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD12DAB6C77E62EAF32BD3FF8719852A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace UniMoodle {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ProgressBar barraProgresso;
        
        internal System.Windows.Controls.CheckBox cbxManterLogado;
        
        internal System.Windows.Controls.Button btnEntrar;
        
        internal System.Windows.Controls.PasswordBox psbSenha;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.TextBox txtbLogin;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/UniMoodle;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.barraProgresso = ((System.Windows.Controls.ProgressBar)(this.FindName("barraProgresso")));
            this.cbxManterLogado = ((System.Windows.Controls.CheckBox)(this.FindName("cbxManterLogado")));
            this.btnEntrar = ((System.Windows.Controls.Button)(this.FindName("btnEntrar")));
            this.psbSenha = ((System.Windows.Controls.PasswordBox)(this.FindName("psbSenha")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.txtbLogin = ((System.Windows.Controls.TextBox)(this.FindName("txtbLogin")));
        }
    }
}
