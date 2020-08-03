namespace Midterm_Project_The_Matching_Game_ {
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    /// <summary>
    /// Interaction logic for PreparationWindow.xaml
    /// </summary>
    public partial class PreparationWindow : Window {
        public PreparationWindow() {
            InitializeComponent();
            AddAvatars();
        }
        class Avatar {
            public string Avatars { get; set; }
        }
        private List<Avatar> avatars = new List<Avatar>();
        private void AddAvatars() {
            avatars.Add(new Avatar { Avatars = "Select Avatar" });
            avatars.Add(new Avatar { Avatars = "MaleAvatar1" });
            avatars.Add(new Avatar { Avatars = "MaleAvatar2" });
            avatars.Add(new Avatar { Avatars = "MaleAvatar3" });
            avatars.Add(new Avatar { Avatars = "MaleAvatar4" });
            avatars.Add(new Avatar { Avatars = "FemaleAvatar1" });
            avatars.Add(new Avatar { Avatars = "FemaleAvatar2" });
            avatars.Add(new Avatar { Avatars = "FemaleAvatar4" });
            avatars.Add(new Avatar { Avatars = "FemaleAvatar3" });
            _selectAvatarComboBox.ItemsSource = avatars;
            _selectAvatarComboBox.SelectedIndex = 0;
        }
        private void PreperationWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
            
        }
        private void PlayButton_Click(object sender, RoutedEventArgs e) {
#if true
            if(_enterNameTextBox.Text.Equals("Enter Name")) {
                MessageBox.Show("Please enter your Name/Nickname", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else if (_selectAvatarComboBox.SelectedIndex <= 0) {
                MessageBox.Show("Please select your avatar", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else if(_radioButton1Difficulty.IsChecked.Equals(false) &&
                    _radioButton2Difficulty.IsChecked.Equals(false) &&
                    _radioButton3Difficulty.IsChecked.Equals(false)) {
                MessageBox.Show("Please choose difficulty level", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else if(_radioButton1GameType.IsChecked.Equals(false) &&
                    _radioButton2GameType.IsChecked.Equals(false)) {
                MessageBox.Show("Please choose game type", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
#endif
            this.Hide();
            if (_radioButton1Difficulty.IsChecked.Equals(true) && _radioButton1GameType.IsChecked.Equals(true)) {
                // easy and single pairing
                EasyTableWindow easyTableWindow = new EasyTableWindow();
                easyTableWindow._playerName.Content = _enterNameTextBox.Text;
                easyTableWindow._gameType.Text = "Single kind pairing";
                easyTableWindow._difficultyLabel.Content = "Easy";
                easyTableWindow._playerAvatarLabel.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Avatars/" + avatars[_selectAvatarComboBox.SelectedIndex].Avatars + ".png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                easyTableWindow.ShowDialog();
            }
            else if (_radioButton1Difficulty.IsChecked.Equals(true) && _radioButton2GameType.IsChecked.Equals(true)) {
                // easy and assorted pairing
                EasyTableWindow easyTableWindow = new EasyTableWindow();
                easyTableWindow._playerName.Content = _enterNameTextBox.Text;
                easyTableWindow._gameType.Text = "Assorted kind pairing";
                easyTableWindow._difficultyLabel.Content = "Easy";
                easyTableWindow._playerAvatarLabel.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Avatars/" + avatars[_selectAvatarComboBox.SelectedIndex].Avatars + ".png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                easyTableWindow.ShowDialog();
            }
            else if (_radioButton2Difficulty.IsChecked.Equals(true) && _radioButton1GameType.IsChecked.Equals(true)) {
                // medium and single pairing
                MediumTableWindow mediumTableWindow = new MediumTableWindow();
                mediumTableWindow._playerName.Content = _enterNameTextBox.Text;
                mediumTableWindow._gameType.Text = "Single kind pairing";
                mediumTableWindow._difficultyLabel.Content = "Medium";
                mediumTableWindow._playerAvatarLabel.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Avatars/" + avatars[_selectAvatarComboBox.SelectedIndex].Avatars + ".png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                mediumTableWindow.ShowDialog();
            }
            else if (_radioButton2Difficulty.IsChecked.Equals(true) && _radioButton2GameType.IsChecked.Equals(true)) {
                // medium and assorted pairing
                MediumTableWindow mediumTableWindow = new MediumTableWindow();
                mediumTableWindow._playerName.Content = _enterNameTextBox.Text;
                mediumTableWindow._gameType.Text = "Assorted kind pairing";
                mediumTableWindow._difficultyLabel.Content = "Medium";
                mediumTableWindow._playerAvatarLabel.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Avatars/" + avatars[_selectAvatarComboBox.SelectedIndex].Avatars + ".png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                mediumTableWindow.ShowDialog();
            }
            else if (_radioButton3Difficulty.IsChecked.Equals(true) && _radioButton1GameType.IsChecked.Equals(true)) {
                // Hard and single pairing
                HardTableWindow hardTableWindow = new HardTableWindow();
                hardTableWindow._playerName.Content = _enterNameTextBox.Text;
                hardTableWindow._gameType.Text = "Single kind pairing";
                hardTableWindow._difficultyLabel.Content = "Hard";
                hardTableWindow._playerAvatarLabel.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Avatars/" + avatars[_selectAvatarComboBox.SelectedIndex].Avatars + ".png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                hardTableWindow.ShowDialog();
            }
            else if (_radioButton3Difficulty.IsChecked.Equals(true) && _radioButton2GameType.IsChecked.Equals(true)) {
                // Hard and assorted pairing
                HardTableWindow hardTableWindow = new HardTableWindow();
                hardTableWindow._playerName.Content = _enterNameTextBox.Text;
                hardTableWindow._gameType.Text = "Assorted kind pairing";
                hardTableWindow._difficultyLabel.Content = "Hard";
                hardTableWindow._playerAvatarLabel.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Avatars/" + avatars[_selectAvatarComboBox.SelectedIndex].Avatars + ".png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
                hardTableWindow.ShowDialog();
            }
            this.ShowDialog();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e) {
            _enterNameTextBox.Text = "Enter Name";
            _enterNameTextBox.FontSize = 12;
            _enterNameTextBox.FontWeight = FontWeights.Normal;
            _enterNameTextBox.Foreground = Brushes.Gray;

            _selectAvatarComboBox.SelectedIndex = 0;

            _radioButton1Difficulty.IsChecked = false;
            _radioButton2Difficulty.IsChecked = false;
            _radioButton3Difficulty.IsChecked = false;
            _radioButton1GameType.IsChecked = false;
            _radioButton2GameType.IsChecked = false;
            this.Close();
        }
        private void EnterNameTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount.Equals(1)) {
                _enterNameTextBox.Text = string.Empty;
                _enterNameTextBox.FontSize = 14;
                _enterNameTextBox.FontWeight = FontWeights.Bold;
                _enterNameTextBox.Foreground = Brushes.Black;
            }
        }
        private void SelectAvatarComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (!_selectAvatarComboBox.SelectedIndex.Equals(-1)) {
                int index = _selectAvatarComboBox.SelectedIndex;
                _avatarLabel.Content = new Image {
                    Source = new BitmapImage(new Uri("/Images/Avatars/" + avatars[index].Avatars + ".png", UriKind.Relative)),
                    Stretch = Stretch.Fill
                };
            }
        }
        private void EasyLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount.Equals(1)) {
                _radioButton1Difficulty.IsChecked = true;
            }
        }
        private void MediumLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount.Equals(1)) {
                _radioButton2Difficulty.IsChecked = true;
            }
        }
        private void HardLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount.Equals(1)) {
                _radioButton3Difficulty.IsChecked = true;
            }
        }
        private void SinglePairingLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount.Equals(1)) {
                _radioButton1GameType.IsChecked = true;
            }
        }
        private void AssortedPairingLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ClickCount.Equals(1)) {
                _radioButton2GameType.IsChecked = true;
            }
        }
    }
}
