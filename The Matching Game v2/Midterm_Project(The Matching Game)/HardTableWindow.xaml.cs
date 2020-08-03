namespace Midterm_Project_The_Matching_Game_ {
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Input;
    using Midterm_Project_The_Matching_Game_.Classes;
    /// <summary>
    /// Interaction logic for HardTableWindow.xaml
    /// </summary>
    public partial class HardTableWindow : Window {
        private MainWindow window = Application.Current.Windows[0] as MainWindow;
        private GameFunctions gameFunctions = new GameFunctions();
        private List<string> hiddenImages = new List<string>();

        public HardTableWindow() {
            InitializeComponent();

            bool ifTimerMode = false;
            if (window.preparationWindow._radioButton2GameMode.IsChecked == true) {
                ifTimerMode = true;
            }
            else {
                ifTimerMode = false;
            }

            SetHiddenImages();
            gameFunctions = new GameFunctions(ifTimerMode, this, "HardTableWindow", ref _timerLabel, ref _lifePointsProgressBar, ref _roundLevelLabel, ref hiddenImages);
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
                    "/Images/MyClassmates/Cenfred.png",
                    "/Images/MyClassmates/Dudz.png",
                    "/Images/MyClassmates/Jay.png",
                    "/Images/MyClassmates/Jefferson.png",
                    "/Images/MyClassmates/Jerry.png",
                    "/Images/MyClassmates/Jobert.png",
                    "/Images/MyClassmates/Jonald.png",
                    "/Images/MyClassmates/Joseph.png",
                    "/Images/MyClassmates/Karl.png",
                    "/Images/MyClassmates/Kervin.png",
                    "/Images/MyClassmates/Mark.png",
                    "/Images/MyClassmates/Marwin.png",
                    "/Images/MyClassmates/Meljane.png",
                    "/Images/MyClassmates/Prince.png",
                    "/Images/MyClassmates/Rickben.png",
                    "/Images/MyClassmates/Vincent.png",
                    "/Images/MyClassmates/Zeus.png",

                    "/Images/MyClassmates/Allan.png",
                    "/Images/MyClassmates/Cenfred.png",
                    "/Images/MyClassmates/Dudz.png",
                    "/Images/MyClassmates/Jay.png",
                    "/Images/MyClassmates/Jefferson.png",
                    "/Images/MyClassmates/Jerry.png",
                    "/Images/MyClassmates/Jobert.png",
                    "/Images/MyClassmates/Jonald.png",
                    "/Images/MyClassmates/Joseph.png",
                    "/Images/MyClassmates/Karl.png",
                    "/Images/MyClassmates/Kervin.png",
                    "/Images/MyClassmates/Mark.png",
                    "/Images/MyClassmates/Marwin.png",
                    "/Images/MyClassmates/Meljane.png",
                    "/Images/MyClassmates/Prince.png",
                    "/Images/MyClassmates/Rickben.png",
                    "/Images/MyClassmates/Vincent.png",
                    "/Images/MyClassmates/Zeus.png",
                };
                hiddenImages = new List<string>(singleKind);
            }
            // assorted kind
            else {
                string[] assortedKind = new string[] {
                    "/Images/MyClassmates/Mark.png",
                    "/Images/MyClassmates/Marwin.png",
                    "/Images/MyClassmates/Meljane.png",
                    "/Images/MyClassmates/Prince.png",
                    "/Images/MyClassmates/Rickben.png",
                    "/Images/MyClassmates/Vincent.png",
                    "/Images/MyClassmates/Zeus.png",
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


                    "/Images/MyClassmates/Mark.png",
                    "/Images/MyClassmates/Marwin.png",
                    "/Images/MyClassmates/Meljane.png",
                    "/Images/MyClassmates/Prince.png",
                    "/Images/MyClassmates/Rickben.png",
                    "/Images/MyClassmates/Vincent.png",
                    "/Images/MyClassmates/Zeus.png",
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
                };
                hiddenImages = new List<string>(assortedKind);
            }
        }
        private void HardTableWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
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
