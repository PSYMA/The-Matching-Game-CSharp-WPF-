namespace Midterm_Project_The_Matching_Game_ {
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Input;
    using Midterm_Project_The_Matching_Game_.Classes;
    /// <summary>
    /// Interaction logic for MediumTableWindow.xaml
    /// </summary>
    public partial class MediumTableWindow : Window {
        private MainWindow window = Application.Current.Windows[0] as MainWindow;
        private GameFunctions gameFunctions = new GameFunctions();
        private List<string> hiddenImages = new List<string>();
 
        public MediumTableWindow() {
            InitializeComponent();

            bool ifTimerMode = false;
            if (window.preparationWindow._radioButton2GameMode.IsChecked == true) {
                ifTimerMode = true;
            }
            else {
                ifTimerMode = false;
            }

            SetHiddenImages();
            gameFunctions = new GameFunctions(ifTimerMode, this, "MediumTableWindow", ref _timerLabel, ref _lifePointsProgressBar, ref _roundLevelLabel, ref hiddenImages);
            gameFunctions.SetButtonNames(ref myGrid);
            gameFunctions.SetDefaultButtonContent(ref myGrid);
            gameFunctions.SetPower_ups(ref myGrid);
 
            if (window.preparationWindow._radioButton2GameMode.IsChecked == true) {
                gameFunctions.StartTimeNow = true;
            }
        }

        private void SetHiddenImages() {
            // single kind
            if (window.preparationWindow._radioButton1GameType.IsChecked.Equals(true)) {
                string[] singleKind = new string[] {
                    "/Images/MyClassmates/Allan.png",
                    "/Images/MyClassmates/Dudz.png",
                    "/Images/MyClassmates/Jefferson.png",
                    "/Images/MyClassmates/Karl.png",
                    "/Images/MyClassmates/Rickben.png",
                    "/Images/MyClassmates/Prince.png",
                    "/Images/MyClassmates/Marwin.png",
                    "/Images/MyClassmates/Mark.png",
                    "/Images/MyClassmates/Cenfred.png",
                    "/Images/MyClassmates/Jerry.png",
                    "/Images/MyClassmates/Jonald.png",
                    "/Images/MyClassmates/Kervin.png",

                    "/Images/MyClassmates/Allan.png",
                    "/Images/MyClassmates/Dudz.png",
                    "/Images/MyClassmates/Jefferson.png",
                    "/Images/MyClassmates/Karl.png",
                    "/Images/MyClassmates/Rickben.png",
                    "/Images/MyClassmates/Prince.png",
                    "/Images/MyClassmates/Marwin.png",
                    "/Images/MyClassmates/Mark.png",
                    "/Images/MyClassmates/Cenfred.png",
                    "/Images/MyClassmates/Jerry.png",
                    "/Images/MyClassmates/Jonald.png",
                    "/Images/MyClassmates/Kervin.png",
                };
                hiddenImages = new List<string>(singleKind);
            }
            // assorted kind
            else {
                string[] assortedKind = new string[] {
                    "/Images/Animals/Cat.png",
                    "/Images/Animals/Cat1.png",
                    "/Images/Animals/Creature1.png",
                    "/Images/Animals/Creature2.png",
                    "/Images/Animals/Creature3.png",
                    "/Images/Animals/Creature4.png",
                    "/Images/Animals/Creature5.png",
                    "/Images/Animals/Crocodile.png",
                    "/Images/Animals/Dog.png",
                    "/Images/Animals/Horse.png",
                    "/Images/Animals/Monkey.png",
                    "/Images/MyClassmates/Karl.png",

                    "/Images/Animals/Cat.png",
                    "/Images/Animals/Cat1.png",
                    "/Images/Animals/Creature1.png",
                    "/Images/Animals/Creature2.png",
                    "/Images/Animals/Creature3.png",
                    "/Images/Animals/Creature4.png",
                    "/Images/Animals/Creature5.png",
                    "/Images/Animals/Crocodile.png",
                    "/Images/Animals/Dog.png",
                    "/Images/Animals/Horse.png",
                    "/Images/Animals/Monkey.png",
                    "/Images/MyClassmates/Karl.png",
                };
                hiddenImages = new List<string>(assortedKind);
            }
        }
        private void MediumTableWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
        private void IfButtonIsClick_Click(object sender, RoutedEventArgs e) {
            gameFunctions.IfButtonIsClick_Click(ref sender, ref e, ref myGrid);
            
        }
        private void Buttons_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            gameFunctions.Buttons_PreviewMouseDown(ref sender, ref e, ref myGrid);
           
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
