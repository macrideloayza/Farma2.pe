﻿#pragma checksum "C:\Users\Paul\Documents\GitHub\Farma2.pe\Farma.pe\Farma.pe\BuscarMedicamentos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6419E909E0D58A718D290106DB4B7618"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace Farma.pe {
    
    
    public partial class BuscarMedicamentos : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnMedicamentos;
        
        internal System.Windows.Controls.Image image;
        
        internal System.Windows.Controls.ListBox lbMedicamento;
        
        internal System.Windows.Controls.TextBox txtFiltro;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Farma.pe;component/BuscarMedicamentos.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnMedicamentos = ((System.Windows.Controls.Button)(this.FindName("btnMedicamentos")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
            this.lbMedicamento = ((System.Windows.Controls.ListBox)(this.FindName("lbMedicamento")));
            this.txtFiltro = ((System.Windows.Controls.TextBox)(this.FindName("txtFiltro")));
        }
    }
}

