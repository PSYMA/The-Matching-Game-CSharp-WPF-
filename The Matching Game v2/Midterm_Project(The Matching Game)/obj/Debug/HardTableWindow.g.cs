﻿#pragma checksum "..\..\HardTableWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E151DF8D62E9C467F3E83012AA80924EFED561529BD8CFEE260FC9CDA06A7AAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Midterm_Project_The_Matching_Game_;
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


namespace Midterm_Project_The_Matching_Game_ {
    
    
    /// <summary>
    /// HardTableWindow
    /// </summary>
    public partial class HardTableWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _timerLabel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _playerName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _playerAvatarLabel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _roundLevelLabel;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _difficultyLabel;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _gameType;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar _lifePointsProgressBar;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\HardTableWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Midterm_Project(The Matching Game);component/hardtablewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HardTableWindow.xaml"
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
            
            #line 8 "..\..\HardTableWindow.xaml"
            ((Midterm_Project_The_Matching_Game_.HardTableWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.HardTableWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this._timerLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this._playerName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this._playerAvatarLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this._roundLevelLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this._difficultyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this._gameType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this._lifePointsProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            
            #line 142 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 142 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 143 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 143 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 144 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 144 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 145 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 145 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 146 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 146 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 147 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 147 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 149 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 149 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 150 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 150 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 151 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 151 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 152 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 152 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 153 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 153 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 154 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 154 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 156 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 156 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 157 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 157 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 158 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 158 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 159 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 159 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 160 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 160 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 161 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 161 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 163 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 163 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 164 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 164 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 165 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 165 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 166 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 166 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 167 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 167 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 168 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 168 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 170 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 170 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 171 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 171 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 172 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 172 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 173 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 173 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 174 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 174 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 175 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 175 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 177 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 177 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 178 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 178 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 179 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 179 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 180 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 180 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 181 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 181 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 182 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Buttons_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 182 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IfButtonIsClick_Click);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 193 "..\..\HardTableWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
