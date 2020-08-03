namespace Midterm_Project_The_Matching_Game_ {
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Threading;
    using Midterm_Project_The_Matching_Game_.Classes;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            preparationWindow = new PreparationWindow();
            powerUpWindow = new PowerUpsWindow();
            power_ups = new Power_ups();
            levelCompleteWindow = new LevelCompleteWindow();
            helpWindow = new HelpWindow();
            aboutWindow = new AboutWindow();

            moveTitle.Interval = TimeSpan.FromSeconds(.05);
            moveTitle.Tick += new EventHandler(MoveGameTitle);
            moveTitle.Start();

            moveMainMenu.Interval = TimeSpan.FromSeconds(.5);
            moveMainMenu.Tick += new EventHandler(MoveGameMainMenu);

            transition.Interval = TimeSpan.FromSeconds(.1);
            transition.Tick += new EventHandler(StartTransition);
            transition.Start();
        }
        public LevelCompleteWindow levelCompleteWindow;
        public Power_ups power_ups;
        public PowerUpsWindow powerUpWindow;
        public PreparationWindow preparationWindow;
        private HelpWindow helpWindow;
        private AboutWindow aboutWindow;

        private DispatcherTimer moveTitle = new DispatcherTimer();
        private DispatcherTimer moveMainMenu = new DispatcherTimer();
        private DispatcherTimer transition = new DispatcherTimer();

        private void StartTransition(object sender, EventArgs e) {
            Canvas.SetLeft(_backGround1, Canvas.GetLeft(_backGround1) - 10);
            Canvas.SetLeft(_backGround2, Canvas.GetLeft(_backGround2) - 10);

            if(Canvas.GetLeft(_backGround1) <= -350) {
                Canvas.SetLeft(_backGround1, 350);
            }
            if (Canvas.GetLeft(_backGround2) <= -350) {
                Canvas.SetLeft(_backGround2, 350);
            }
        }
        private void MoveGameTitle(object sender, EventArgs e) {
            if(Canvas.GetTop(_theTitleLabel) < 0) {
                Canvas.SetTop(_theTitleLabel, Canvas.GetTop(_theTitleLabel) + 10);
            }
            if (Canvas.GetTop(_matchingTitleLabel) < 100 && Canvas.GetTop(_theTitleLabel) >= 0) {
                Canvas.SetTop(_matchingTitleLabel, Canvas.GetTop(_matchingTitleLabel) + 20);
            }
            if (Canvas.GetTop(_gameTitleLabel) < 200 && Canvas.GetTop(_matchingTitleLabel) >= 100) {
                Canvas.SetTop(_gameTitleLabel, Canvas.GetTop(_gameTitleLabel) + 30);
            }
            if(Canvas.GetTop(_gameTitleLabel) >= 200) {
                _theTitleLabel.Opacity -= 0.05;
                _matchingTitleLabel.Opacity -= 0.05;
                _gameTitleLabel.Opacity -= 0.05;
                if(_gameTitleLabel.Opacity <= 0) {
                    moveMainMenu.Start();
                    moveTitle.Stop();
                }
            }
        }
        private void MoveGameMainMenu(object sender, EventArgs e) {
            if(Canvas.GetLeft(_mainMenuCanvas) < 0) {
                Canvas.SetLeft(_mainMenuCanvas, Canvas.GetLeft(_mainMenuCanvas) + 50);
            }
            if(Canvas.GetLeft(_mainMenuCanvas) >= 0) {
                moveMainMenu.Stop();
            }
        }
        private void StartGameButton_Click(object sender, RoutedEventArgs e) {
            this.Hide();
            preparationWindow.ShowDialog(); 
            this.ShowDialog();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e) {
            this.Hide();
            helpWindow.ShowDialog();
            this.ShowDialog();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e) {
            this.Hide();
            aboutWindow.ShowDialog();
            this.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown(); 
        }

         
    }
}
