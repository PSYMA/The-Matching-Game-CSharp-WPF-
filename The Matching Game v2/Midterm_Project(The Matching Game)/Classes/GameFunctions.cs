namespace Midterm_Project_The_Matching_Game_.Classes {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Controls;
    using System.Windows.Media.Imaging;
    using System.Windows.Media;
    using System.Windows.Input;
    using System.Windows;
    using System.Windows.Threading;
    using System.Windows.Media.Animation;
    using System.Media;
    public class GameFunctions {
        /* 
         * I created this class because 3 window(EasyTableWindow, MediumTableWindow and HardTableWindow) 
         * share the same functionality and to lessen the code size
        */

        private List<string> hiddenImages = new List<string>(); // store location of images
        private List<string> buttonNames = new List<string>();  // store names of buttons
        private List<int> futureButtons = new List<int>();      // store the index of button(future power up)
        private Dictionary<int, string> power_ups = new Dictionary<int, string>();  // store power_ups buttons
        private Button button1 = new Button();
        private Button button2 = new Button();
        private Power_ups power = new Power_ups();  // Class for power_ups(future,hint,reveal,health,shield)
        private ProgressBar lifePointsProgressBar = new ProgressBar();
        private Label roundLevelLabel = new Label();
        private Label timerLabel = new Label();
        private DispatcherTimer timer = new DispatcherTimer();

        private string image1 = string.Empty;
        private string image2 = string.Empty;
        private string windowName = string.Empty;

        private int countClick = 1;
        private int round = 1;
        private int timeDeduction = 0;
        private int countTimer = 300;
        private int countPause = 0;
        private int countSlow = 0;

        private bool ifButtonContentIsEqual = false;
        private bool isShieldUsed = false;
        private bool isAddTimeUsed = false;
        private bool isPauseTimeUsed = false;
        private bool isSlowTimeUsed = false;
        private bool ifTimerMode = false;
        public bool StartTimeNow { get; set; }

        private object currentWindow = null;

        public GameFunctions() { }
        public GameFunctions(bool ifTimerMode, object currentWindow, string windowName, ref Label timerLabel, ref ProgressBar lifePointsProgressBar, ref Label roundLevelLabel, ref List<string> hiddenImages) {
            this.timerLabel = timerLabel;
            this.lifePointsProgressBar = lifePointsProgressBar;
            this.roundLevelLabel = roundLevelLabel;
            this.hiddenImages = hiddenImages;
            this.windowName = windowName;
            this.currentWindow = currentWindow;
            this.ifTimerMode = ifTimerMode;
            ShuffleHiddenImages(); 

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(StartTimer);
            timer.Start();

        }

        public void StartTimer(object sender, EventArgs e) {
            if (StartTimeNow) {
                if (isPauseTimeUsed) {
                    countPause++;
                    countTimer++;
                    if(countPause == 10) {
                        countPause = 0;
                        isPauseTimeUsed = false;
                    }
                }
                if (isSlowTimeUsed) {
                    timer.Interval = TimeSpan.FromSeconds(1.5);
                    countSlow++;
                    if(countSlow == 5) {
                        countSlow = 0;
                        timer.Interval = TimeSpan.FromSeconds(1);
                        isSlowTimeUsed = false;
                    }
                }
                else if (isAddTimeUsed) {
                    countTimer += 20;
                    isAddTimeUsed = false;
                }
                if(countTimer <= 10) {
                    timerLabel.Foreground = Brushes.Red;
                }
                else if(countTimer > 10) {
                    timerLabel.Foreground = Brushes.Black;
                }
                countTimer--;
                timerLabel.Content = countTimer;
                if (countTimer <= 0) {
                    SoundPlayer soundPlayer = new SoundPlayer("../../Images/Sound/lose sound.wav");
                    soundPlayer.Load();
                    soundPlayer.Play();
                    soundPlayer.Dispose();

                    PowerUpsWindow powerUpsWindow = new PowerUpsWindow();
                    powerUpsWindow._powerUpsNameLabel.Content = string.Empty;
                    powerUpsWindow._powerUpsIconLabel.Content = new Image {
                        Source = new BitmapImage(new Uri("/Images/Background/YouLose.png", UriKind.Relative)),
                        Stretch = Stretch.Fill
                    };
                    powerUpsWindow.ShowDialog();
                    if (windowName == "EasyTableWindow") {
                        EasyTableWindow window = currentWindow as EasyTableWindow;
                        window.Close();
                    }
                    else if (windowName == "MediumTableWindow") {
                        MediumTableWindow window = currentWindow as MediumTableWindow;
                        window.Close();
                    }
                    else if (windowName == "HardTableWindow") {
                        HardTableWindow window = currentWindow as HardTableWindow;
                        window.Close();
                    }
                    timer.Stop();
                }
            }
            else {
                timer.Stop();
            }
        }
        public  void SetButtonNames(ref Grid myGrid) {
            buttonNames.Clear();
            int i = 0;
            foreach(Button button in myGrid.Children) {
                button.Name = "index" + i + "Button";
                buttonNames.Add(button.Name);
                i++;
            }
        }
        private void ShuffleHiddenImages() {
            Random random = new Random();
            // shuffle the List (hiddenImages)
            for (int i = 0; i < hiddenImages.Count; i++) {
                int index = random.Next(hiddenImages.Count);
                string temp = hiddenImages[i];
                hiddenImages[i] = hiddenImages[index];
                hiddenImages[index] = temp;
            }
        }
        public  void SetPower_ups(ref Grid myGrid) {
            power_ups.Clear();
            string[] str = null;
            if (ifTimerMode) {
                str = new string[] {
                    "../../Images/Power-ups/Future.png",
                    "../../Images/Power-ups/Health.png",
                    "../../Images/Power-ups/Hint.png",
                    "../../Images/Power-ups/Reveal.png",
                    "../../Images/Power-ups/Shield.png",
                    "../../Images/Power-ups/AddTime.png",
                    "../../Images/Power-ups/PauseTime.png",
                    "../../Images/Power-ups/SlotTime.png"
                };
            }
            else {
                timerLabel.Visibility = Visibility.Hidden;
                str = new string[] {
                    "../../Images/Power-ups/Future.png",
                    "../../Images/Power-ups/Health.png",
                    "../../Images/Power-ups/Hint.png",
                    "../../Images/Power-ups/Reveal.png",
                    "../../Images/Power-ups/Shield.png"
                };
            }
            Random random = new Random();
            List<int> indeces = new List<int>();
            for (int i = 0; i < str.Length; i++) {
                int key = random.Next(hiddenImages.Count);
                if (power_ups.ContainsKey(key)) {
                    i--;
                    continue;
                }
                else {
                    indeces.Add(key);
                    power_ups.Add(key, str[i]);
                }
            }
            indeces.Sort();
            int x = 0;
            int j = 0;
            foreach (Button button in myGrid.Children) {
                if (indeces[j].Equals(x)) {
                    foreach (var items in power_ups) {
                        if (items.Key.Equals(x)) {
                            button.Content = new Image {
                                Source = new BitmapImage(new Uri(items.Value, UriKind.Relative)),
                                Stretch = Stretch.Fill
                            };
                            break;
                        }
                    }
                    j++;
                    if (j >= indeces.Count) {
                        break;
                    }
                }
                x++;
            }
        }
        public  void SetDefaultButtonContent(ref Grid myGrid) {
            foreach (Button button in myGrid.Children) {
                button.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                button.IsEnabled = true;
                ColorAnimation animation = new ColorAnimation(Colors.White, new Duration(TimeSpan.FromSeconds(1)));
                button.Background = new SolidColorBrush(Colors.White);
                button.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
        }
        public  void Buttons_PreviewMouseDown(ref object sender, ref MouseButtonEventArgs e, ref Grid myGrid) {
            if (ifButtonContentIsEqual) {
                ifButtonContentIsEqual = false;
                return;
            }
            if (e.ClickCount.Equals(1) && (!image1.Equals(string.Empty) && !image2.Equals(string.Empty))) {
                ifButtonContentIsEqual = CheckIfButtonContentIsEqual();
                image1 = string.Empty;
                image2 = string.Empty;
                if (!ifButtonContentIsEqual) {
                    var button = sender as Button;
                    for (int i = 0; i < buttonNames.Count; i++) {
                        if (button.Name.Equals(buttonNames[i])) {
                            if (CheckIfButtonHasPower_ups(ref myGrid, ref button, ref i)) {
                                button.Content = new Image {
                                    Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                                    Stretch = Stretch.Fill
                                };
                                button.IsEnabled = true;
                                return;
                            }
                        }
                    }
                    button.Content = new Image {
                        Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                        Stretch = Stretch.Fill
                    };
                    button.IsEnabled = true;
                }
            }
        }
        public  void IfButtonIsClick_Click(ref object sender, ref RoutedEventArgs e, ref Grid myGrid) {
            var button = sender as Button;
            for (int i = 0; i < buttonNames.Count; i++) {
                if (button.Name.Equals(buttonNames[i])) {
                    if (CheckIfButtonHasPower_ups(ref myGrid, ref button, ref i)) {
                        button.Content = new Image {
                            Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                            Stretch = Stretch.Fill
                        };
                        return;
                    }
                    button.Content = new Image {
                        Source = new BitmapImage(new Uri(hiddenImages[i], UriKind.Relative)),
                        Stretch = Stretch.Fill
                    };
                    button.IsEnabled = false;
                    if (countClick.Equals(1)) {
                        button1 = button;
                        image1 = hiddenImages[i];
                        countClick++;
                    }
                    else if (countClick.Equals(2)) {
                        button2 = button;
                        image2 = hiddenImages[i];
                        countClick = 1;
                    }
                    break;
                }
            }
            if (CheckIfPlayerWin(ref myGrid)) {
                timer.Stop();
                SoundPlayer soundPlayer = new SoundPlayer("../../Images/Sound/win sound.wav");
                soundPlayer.Load(); 
                soundPlayer.Play();
                soundPlayer.Dispose();

                LevelCompleteWindow levelCompleteWindow = new LevelCompleteWindow();
                levelCompleteWindow._levelLabel.Content = round.ToString();
                levelCompleteWindow._proceedLabel.Content = (++round).ToString();
                levelCompleteWindow.ShowDialog();

                SetDefaultButtonContent(ref myGrid);
                ShuffleHiddenImages();
                SetPower_ups(ref myGrid);
                roundLevelLabel.Content = "Round " + round.ToString();

                lifePointsProgressBar.Value = 20;
                futureButtons.Clear();

                timeDeduction += 3;
                countTimer = 300;
                countTimer -= timeDeduction;
                if(countTimer <= 100) {
                    countTimer = 100;
                }
                timer.Start();
            }
           
        }


        public bool CheckIfPlayerLose() {
            if(lifePointsProgressBar.Value <= 0) {
                return true;
            }
            return false;
        }
        private bool CheckIfPlayerWin(ref Grid myGrid) {
            foreach (Button button in myGrid.Children) {
                if (button.IsEnabled.Equals(true)) {
                    return false;
                }
            }
            return true;
        }
        private bool CheckIfButtonContentIsEqual() {
            if (!image1.Equals(image2)) {
                button1.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                button1.IsEnabled = true;
                button2.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                button2.IsEnabled = true;
                // if futureButton is click, then set stretch to uniform
                string button1Name = new string(button1.Name.Where(Char.IsDigit).ToArray());
                string button2Name = new string(button2.Name.Where(Char.IsDigit).ToArray());
                foreach (var items in futureButtons) {
                    if (Convert.ToInt32(button1Name).Equals(items)) {
                        button1.Content = new Image {
                            Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                            Stretch = Stretch.Uniform
                        };
                    }
                    else if (Convert.ToInt32(button2Name).Equals(items)) {
                        button2.Content = new Image {
                            Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                            Stretch = Stretch.Uniform
                        };
                    }
                }
                // life points deduction
                if (!isShieldUsed) {
                    lifePointsProgressBar.Value -= 1;
                    if (CheckIfPlayerLose()) {
                        SoundPlayer soundPlayer = new SoundPlayer("../../Images/Sound/lose sound.wav");
                        soundPlayer.Load();
                        soundPlayer.Play();
                        soundPlayer.Dispose();

                        PowerUpsWindow powerUpsWindow = new PowerUpsWindow();
                        powerUpsWindow._powerUpsNameLabel.Content = string.Empty;
                        powerUpsWindow._powerUpsIconLabel.Content = new Image {
                            Source = new BitmapImage(new Uri("/Images/Background/YouLose.png", UriKind.Relative)),
                            Stretch = Stretch.Fill
                        };
                        powerUpsWindow.ShowDialog();
                        if (windowName == "EasyTableWindow") {
                            EasyTableWindow window = currentWindow as EasyTableWindow;
                            window.Close();
                        }
                        else if (windowName == "MediumTableWindow") {
                            MediumTableWindow window = currentWindow as MediumTableWindow;
                            window.Close();
                        }
                        else if (windowName == "HardTableWindow") {
                            HardTableWindow window = currentWindow as HardTableWindow;
                            window.Close();
                        }
                    }
                }
                else {
                    isShieldUsed = false;
                }
                return false;
            }
            return true;
        }
        private bool CheckIfButtonHasPower_ups(ref Grid myGrid, ref Button button, ref int i) {
            foreach (var items in power_ups) {
                if (items.Key.Equals(i)) {
                    button.Content = new Image {
                        Source = new BitmapImage(new Uri(items.Value, UriKind.Relative)),
                        Stretch = Stretch.Fill
                    };
                    if (items.Value.Contains("Reveal")) {
                        power.Reveal(ref myGrid, ref power_ups, ref hiddenImages, ref futureButtons);
                    }
                    else if (items.Value.Contains("Future")) {
                        power.Future(ref myGrid, ref power_ups, ref hiddenImages, ref futureButtons);
                    }
                    else if (items.Value.Contains("Health")) {
                        power.Health(ref lifePointsProgressBar);
                    }
                    else if (items.Value.Contains("Hint")) {
                        power.Hint(ref myGrid, ref power_ups, ref hiddenImages, ref futureButtons);
                    }
                    else if (items.Value.Contains("Shield")) {
                        power.Shield(ref isShieldUsed);
                    }
                    else if (items.Value.Contains("Add")) {
                        power.AddTime(ref isAddTimeUsed);
                    }
                    else if (items.Value.Contains("Pause")) {
                        power.AddTime(ref isPauseTimeUsed);
                    }
                    else if (items.Value.Contains("Slot")) {
                        power.AddTime(ref isSlowTimeUsed);
                    }
                    power_ups.Remove(i);
                    return true;
                }
            }
            return false;
        }
    }
}
