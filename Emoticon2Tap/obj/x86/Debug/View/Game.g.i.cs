﻿#pragma checksum "F:\Project\Emoticon2Tap\Emoticon2Tap\Emoticon2Tap\View\Game.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D5A810555881671BF2526D1E17267752"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace Emoticon2Tap.View {
    
    
    public partial class Game : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock textBlock;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock txtScore;
        
        internal System.Windows.Controls.TextBlock lblTimer;
        
        internal System.Windows.Controls.TextBlock txtPlayer;
        
        internal System.Windows.Controls.Image Emoji;
        
        internal System.Windows.Controls.Button btnPause;
        
        internal System.Windows.Controls.Button btnStart;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock1_Copy;
        
        internal System.Windows.Controls.TextBlock textBlock1_Copy1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Emoticon2Tap;component/View/Game.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.textBlock = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtScore = ((System.Windows.Controls.TextBlock)(this.FindName("txtScore")));
            this.lblTimer = ((System.Windows.Controls.TextBlock)(this.FindName("lblTimer")));
            this.txtPlayer = ((System.Windows.Controls.TextBlock)(this.FindName("txtPlayer")));
            this.Emoji = ((System.Windows.Controls.Image)(this.FindName("Emoji")));
            this.btnPause = ((System.Windows.Controls.Button)(this.FindName("btnPause")));
            this.btnStart = ((System.Windows.Controls.Button)(this.FindName("btnStart")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock1_Copy = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1_Copy")));
            this.textBlock1_Copy1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1_Copy1")));
        }
    }
}
