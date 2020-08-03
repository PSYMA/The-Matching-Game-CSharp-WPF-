using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm_Project_The_Matching_Game_ {
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window {
        public AboutWindow() {
            InitializeComponent();
            ColorAnimation animation = new ColorAnimation(Colors.ForestGreen, new Duration(TimeSpan.FromSeconds(1)));
            animation.RepeatBehavior = RepeatBehavior.Forever;
            _aboutCloseButton.Background = new SolidColorBrush(Colors.Yellow);
            _aboutCloseButton.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
        }

        private void AboutWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
