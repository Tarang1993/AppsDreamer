﻿#pragma checksum "C:\Users\Tarang\AppsDreamer\OurWindowsApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6F0BD5DEDE7D28825668AB376E37FB87"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
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


namespace OurWindowsApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama panorama;
        
        internal System.Windows.Controls.TextBox textBox1;
        
        internal System.Windows.Controls.Button button;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.ProgressBar ProgressBar;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal Microsoft.Phone.Controls.WebBrowser webBrowser1;
        
        internal System.Windows.Controls.TextBlock Weather;
        
        internal System.Windows.Controls.ListBox AirportList;
        
        internal System.Windows.Controls.ListBox RailwaysList;
        
        internal System.Windows.Controls.ListBox BusList;
        
        internal System.Windows.Controls.ListBox HospitalList;
        
        internal System.Windows.Controls.ListBox GasList;
        
        internal System.Windows.Controls.TextBlock About;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/OurWindowsApp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.panorama = ((Microsoft.Phone.Controls.Panorama)(this.FindName("panorama")));
            this.textBox1 = ((System.Windows.Controls.TextBox)(this.FindName("textBox1")));
            this.button = ((System.Windows.Controls.Button)(this.FindName("button")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.ProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("ProgressBar")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.webBrowser1 = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("webBrowser1")));
            this.Weather = ((System.Windows.Controls.TextBlock)(this.FindName("Weather")));
            this.AirportList = ((System.Windows.Controls.ListBox)(this.FindName("AirportList")));
            this.RailwaysList = ((System.Windows.Controls.ListBox)(this.FindName("RailwaysList")));
            this.BusList = ((System.Windows.Controls.ListBox)(this.FindName("BusList")));
            this.HospitalList = ((System.Windows.Controls.ListBox)(this.FindName("HospitalList")));
            this.GasList = ((System.Windows.Controls.ListBox)(this.FindName("GasList")));
            this.About = ((System.Windows.Controls.TextBlock)(this.FindName("About")));
        }
    }
}
