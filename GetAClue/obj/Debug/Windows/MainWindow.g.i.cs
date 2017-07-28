﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4950588A36F735F99BA1FFDC3273D54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.DXBinding;
using GetAClue.ViewModels;
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


namespace GetAClue {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Framework;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RoomButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WeaponButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SuspectButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnterButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GuessesLabel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Counter;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GuessCategories;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RoomCategory;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WeaponCategory;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SuspectCategory;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image TransparentClueLogo;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Instructions;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InstructionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RoomOption;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Room;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InstructionsForRoom;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Lounge;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Study;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Hall;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Library;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DiningRoom;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Kitchen;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Ballroom;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Conservatory;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton BilliardRoom;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid WeaponOption;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Weapons;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InstructionsForWeapons;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Candlestick;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Revolver;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Knife;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton LeadPipe;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Wrench;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SuspectsOption;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Suspects;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InstructionsForSuspects;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ColonelMustard;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MrGreen;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ProfessorPlum;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MissScarlet;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MrsPeacock;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MrsWhite;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GameOver;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock YouWin;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock YouLose;
        
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
            System.Uri resourceLocater = new System.Uri("/GetAClue;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            this.Framework = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Start = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.RoomButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.WeaponButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.SuspectButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.EnterButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.GuessesLabel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Counter = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.GuessCategories = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.RoomCategory = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.WeaponCategory = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.SuspectCategory = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.TransparentClueLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 14:
            this.Instructions = ((System.Windows.Controls.Grid)(target));
            return;
            case 15:
            this.InstructionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.RoomOption = ((System.Windows.Controls.Grid)(target));
            return;
            case 17:
            this.Room = ((System.Windows.Controls.Image)(target));
            return;
            case 18:
            this.InstructionsForRoom = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 19:
            this.Lounge = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 20:
            this.Study = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 21:
            this.Hall = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 22:
            this.Library = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 23:
            this.DiningRoom = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 24:
            this.Kitchen = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 25:
            this.Ballroom = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 26:
            this.Conservatory = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 27:
            this.BilliardRoom = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 28:
            this.WeaponOption = ((System.Windows.Controls.Grid)(target));
            return;
            case 29:
            this.Weapons = ((System.Windows.Controls.Image)(target));
            return;
            case 30:
            this.InstructionsForWeapons = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 31:
            this.Candlestick = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 32:
            this.Revolver = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 33:
            this.Knife = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 34:
            this.LeadPipe = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 35:
            this.Wrench = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 36:
            this.SuspectsOption = ((System.Windows.Controls.Grid)(target));
            return;
            case 37:
            this.Suspects = ((System.Windows.Controls.Image)(target));
            return;
            case 38:
            this.InstructionsForSuspects = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 39:
            this.ColonelMustard = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 40:
            this.MrGreen = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 41:
            this.ProfessorPlum = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 42:
            this.MissScarlet = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 43:
            this.MrsPeacock = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 44:
            this.MrsWhite = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 45:
            this.GameOver = ((System.Windows.Controls.Grid)(target));
            return;
            case 46:
            this.YouWin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 47:
            this.YouLose = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

