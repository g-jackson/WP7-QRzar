﻿#pragma checksum "C:\Users\Glenn\Documents\Computer Science\Java Zombies\WP7.VideoScanZXing.SampleApp\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84C6FFD2A30E2B1EE3841F2EE8E7A002"
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


namespace WP7.VideoScanZXing.SampleApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock tbScanResultBarCode;
        
        internal System.Windows.Controls.TextBlock ScannedNumber;
        
        internal System.Windows.Controls.Button QRload;
        
        internal System.Windows.Controls.TextBlock TextNumber;
        
        internal System.Windows.Controls.TextBox TestCode;
        
        internal System.Windows.Controls.Button Textload;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP7.VideoScanZXing.SampleApp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.tbScanResultBarCode = ((System.Windows.Controls.TextBlock)(this.FindName("tbScanResultBarCode")));
            this.ScannedNumber = ((System.Windows.Controls.TextBlock)(this.FindName("ScannedNumber")));
            this.QRload = ((System.Windows.Controls.Button)(this.FindName("QRload")));
            this.TextNumber = ((System.Windows.Controls.TextBlock)(this.FindName("TextNumber")));
            this.TestCode = ((System.Windows.Controls.TextBox)(this.FindName("TestCode")));
            this.Textload = ((System.Windows.Controls.Button)(this.FindName("Textload")));
        }
    }
}
