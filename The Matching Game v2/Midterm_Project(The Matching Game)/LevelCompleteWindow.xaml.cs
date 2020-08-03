namespace Midterm_Project_The_Matching_Game_ {
    using System.Windows;
    using System.Windows.Input;
    /// <summary>
    /// Interaction logic for LevelCompleteWindow.xaml
    /// </summary>
    public partial class LevelCompleteWindow : Window {
        public LevelCompleteWindow() {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {

        }

        private void LevelCompleteWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void ProceedLevelLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount.Equals(1)) {
                this.Close();
            }
        }
    }
}
