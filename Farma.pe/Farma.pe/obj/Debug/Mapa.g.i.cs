﻿#pragma checksum "C:\Users\Paul\Documents\GitHub\Farma2.pe\Farma.pe\Farma.pe\Mapa.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FDBC9A5CF334F809F392903A355140E4"
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
using Microsoft.Phone.Maps.Toolkit;
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
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Maps.Toolkit.MapItemsControl PushpinLayer;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Farma.pe;component/Mapa.xaml", System.UriKind.Relative));
            this.PushpinLayer = ((Microsoft.Phone.Maps.Toolkit.MapItemsControl)(this.FindName("PushpinLayer")));
        }
    }
}

