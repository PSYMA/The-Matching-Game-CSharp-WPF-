namespace Midterm_Project_The_Matching_Game_ {
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    /// <summary>
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window {
        public HelpWindow() {
            InitializeComponent();

            PageOneNormalMode();
            countNormalMode++;
        }
        private int countNormalMode = 0;

        private void PageOneNormalMode() {
            _imagePagesLabelNormalMode.Content = new Image {
                Source = new BitmapImage(new Uri("/Images/Pages/Page1.png", UriKind.Relative)),
                Stretch = Stretch.Fill
            };
            _textGuideTextBlockNormalMode.Text = "This is the Main Menu of the game\n\n" +
                                       "Press Start Game to play\n\n" +
                                       "Press Help to know the mechanics of the game\n\n" +
                                       "Press About to know about the developer\n\n" +
                                       "Press Exit to terminate the game";
 
            _OneButtonNormalMode.Background = Brushes.Orange;
            _FiveButtonNormalMode.Background = Brushes.Transparent;
            _TwoButtonNormalMode.Background = Brushes.Transparent;
        }
        private void PageTwoNormalMode() {
            _imagePagesLabelNormalMode.Content = new Image {
                Source = new BitmapImage(new Uri("/Images/Pages/Page2.png", UriKind.Relative)),
                Stretch = Stretch.Fill
            };
            _textGuideTextBlockNormalMode.Text = "Preparation Mode\n\n" +
                                       "You must enter your Name/Nickname\n\n" +
                                       "You must also select an Avatar\n\n" +
                                       "You must choose the Difficulty of the game\n\n" +
                                       "You must choose the Game type of the game";
            _TwoButtonNormalMode.Background = Brushes.Orange;
            _OneButtonNormalMode.Background = Brushes.Transparent;
            _ThreeButtonNormalMode.Background = Brushes.Transparent;
        }
        private void PageThreeNormalMode() {
            _imagePagesLabelNormalMode.Content = new Image {
                Source = new BitmapImage(new Uri("/Images/Pages/Page3.png", UriKind.Relative)),
                Stretch = Stretch.Fill
            };
            _textGuideTextBlockNormalMode.Text = "Easy mode Difficulty and Single kind pairing game type\n\n" +
                                       "The game is very easy all you need is to click the board\n\n" +
                                       "And take a guess you need a pair of same object,\n\n" +
                                       "Clear all the board and proceed to next level, Levels is endless!";
            _ThreeButtonNormalMode.Background = Brushes.Orange;
            _TwoButtonNormalMode.Background = Brushes.Transparent;
            _FourButtonNormalMode.Background = Brushes.Transparent;
        }
        private void PageFourNormalMode() {
            _imagePagesLabelNormalMode.Content = new Image {
                Source = new BitmapImage(new Uri("/Images/Pages/Page4.png", UriKind.Relative)),
                Stretch = Stretch.Fill
            };
            _textGuideTextBlockNormalMode.Text = "Medium mode Difficulty and Assorted kind pairing game type\n\n" +
                                       "The Difficulty of the game matters, medium is a bit annoying " +
                                       "plus the assorted game type\n\n" +
                                       "Make sure to clear all the board before your life points gets to zero " +
                                       "once its reached to ZERO you lose the game";
            _FourButtonNormalMode.Background = Brushes.Orange;
            _ThreeButtonNormalMode.Background = Brushes.Transparent;
            _FiveButtonNormalMode.Background = Brushes.Transparent;
        }
        private void PageFiveNormalMode() {
            _imagePagesLabelNormalMode.Content = new Image {
                Source = new BitmapImage(new Uri("/Images/Pages/Page5.png", UriKind.Relative)),
                Stretch = Stretch.Fill
            };
            _textGuideTextBlockNormalMode.Text = "Hard mode Difficulty and Single kind pairing game type\n\n" +
                                       "This is the hardest mode you need a high level pure luck " +
                                       "in order to win this mode\n\n" +
                                       "But in this game there are FOUR different types of POWER-UP places randomly in the board\n\n" +
                                       "Each power_up has different effect, Goodluck and Have fun!";
            _FiveButtonNormalMode.Background = Brushes.Orange;
            _FourButtonNormalMode.Background = Brushes.Transparent;
        }


        private void HelpWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
            _OneButtonNormalMode.Background = Brushes.Transparent;
            _TwoButtonNormalMode.Background = Brushes.Transparent;
            _ThreeButtonNormalMode.Background = Brushes.Transparent;
            _FourButtonNormalMode.Background = Brushes.Transparent;
            _FiveButtonNormalMode.Background = Brushes.Transparent;
            _PrevButtonNormalMode.Foreground = Brushes.White;
            _NextButtonNormalMode.Foreground = Brushes.White;
            PageOneNormalMode();
            countNormalMode = 1;
        }

        private void PrevButtonNormalMode_Button(object sender, RoutedEventArgs e) {
            _PrevButtonNormalMode.Foreground = Brushes.Orange;
            _NextButtonNormalMode.Foreground = Brushes.White;
            countNormalMode--;
            if (countNormalMode.Equals(1)) {
                PageOneNormalMode();
            }
            else if (countNormalMode.Equals(2)) {
                PageTwoNormalMode();
            }
            else if (countNormalMode.Equals(3)) {
                PageThreeNormalMode();
            }
            else if (countNormalMode.Equals(4)) {
                PageFourNormalMode();
            }
            else if (countNormalMode.Equals(5)) {
                PageFiveNormalMode();
            }
            if (countNormalMode <= 1) {
                countNormalMode = 1;
            }
        }

        private void NextButtonNormalMode_Button(object sender, RoutedEventArgs e) {
            _NextButtonNormalMode.Foreground = Brushes.Orange;
            _PrevButtonNormalMode.Foreground = Brushes.White;
            countNormalMode++;
            if (countNormalMode.Equals(1)) {
                PageOneNormalMode();
            }
            else if (countNormalMode.Equals(2)) {
                PageTwoNormalMode();
            }
            else if (countNormalMode.Equals(3)) {
                PageThreeNormalMode();
            }
            else if (countNormalMode.Equals(4)) {
                PageFourNormalMode();
            }
            else if (countNormalMode.Equals(5)) {
                PageFiveNormalMode();
            }
            if(countNormalMode >= 5) {
                countNormalMode = 5;
            }
        }

    }
}
