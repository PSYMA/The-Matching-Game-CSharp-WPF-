namespace Midterm_Project_The_Matching_Game_ {
    using System.Windows;
    /// <summary>
    /// Interaction logic for PowerUpsWindow.xaml
    /// </summary>
    public partial class PowerUpsWindow : Window {
        public PowerUpsWindow() {
            InitializeComponent();
        }

        private void PowerUpsWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
