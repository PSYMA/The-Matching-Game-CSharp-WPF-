namespace Midterm_Project_The_Matching_Game_.Classes {
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Media.Imaging;
    using System.Windows.Threading;
    public class Power_ups {
        // NOTE: in Future, Reveal and Hint methods the (List<int> indeces) is the type to store location of buttons in UI
        public void Health(ref ProgressBar lifePointsProgressBar) {
            // health power_up gives +3 Health points
            lifePointsProgressBar.Value += 3;
            if(lifePointsProgressBar.Value >= 20) {
                lifePointsProgressBar.Value = 20;
            }
        }
        public void Future(ref Grid myGrid, ref Dictionary<int, string> power_ups, ref List<string> hiddenImages, ref List<int> futureButtons) {
            // future power_ups select 3 random buttons 2 buttons must be equal in content
            int index = 0;
            bool pair = false;
            List<int> indeces = new List<int>();    // store selected buttons to be future power_up
         
            // Start code
            foreach (Button button in myGrid.Children) {
                // find one pair of buttons(equal content) and one piece of button 
                if (power_ups.ContainsKey(index)) {
                    index++;
                    continue;
                }
                if (button.IsEnabled.Equals(true) && !pair) {   // if condition satisfied
                    for (int i = index + 1; i < hiddenImages.Count; i++) {
                        // find the pair of the button
                        if (hiddenImages[index].Equals(hiddenImages[i])) {
                            if (!power_ups.ContainsKey(i)) {
                                int c = 0;
                                foreach (Button buttonX in myGrid.Children) {
                                    if (i.Equals(c)) {
                                        if (buttonX.IsEnabled.Equals(true)) {   
                                            // if condition satisfied
                                            // one pair of buttons is found, then add to list
                                            indeces.Add(index);
                                            indeces.Add(i);
                                            pair = true;
                                        }
                                        break;
                                    }
                                    c++;
                                }
                            }
                            break;
                        }
                    }
                }
                else if (button.IsEnabled.Equals(true) && pair) {
                    // get one piece of button
                    bool ifContain1 = power_ups.ContainsKey(index);
                    bool ifContain2 = indeces.Contains(index);
                    if (ifContain1.Equals(false) && ifContain2.Equals(false)) {
                        indeces.Add(index);
                        break;
                    }
                }
                index++;
            }
            // End code
            
            // Start code
            if (!indeces.Count.Equals(0)) {
                // start blinking
                indeces.Sort();
                futureButtons = indeces;
                index = 0;
                int j = 0;
                foreach (Button button in myGrid.Children) {
                    if (indeces[j].Equals(index)) {
                        ColorAnimation animation = new ColorAnimation(Colors.Green, new Duration(TimeSpan.FromSeconds(1)));
                        animation.RepeatBehavior = RepeatBehavior.Forever;
                        button.Background = new SolidColorBrush(Colors.Yellow);
                        button.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                        button.Content = new Image {
                            Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                            Stretch = Stretch.Uniform
                        };
                        j++;
                        if (j >= indeces.Count) {
                            break;
                        }
                    }
                    index++;
                }
            }
            // End code
        }
        public void Reveal(ref Grid myGrid, ref Dictionary<int, string> power_ups, ref List<string> hiddenImages, ref List<int> futureButtons) {
            // Reveal power_up select two pair of buttons, pairs is equal in content
            int index = 0;
            List<int> indeces = new List<int>();    // store selected buttons to be reveal power_up
           
            // Start code
            foreach (Button button in myGrid.Children) {
                // get two pair of buttons(equal content)
                if (power_ups.ContainsKey(index)) {
                    index++;
                    continue;
                }
                if (futureButtons.Contains(index)) {
                    index++;
                    continue;
                }
                else if (button.IsEnabled.Equals(true)) {   // if condtion satisfied
                    for (int i = index + 1; i < hiddenImages.Count; i++) {
                        // find the pair of selected button
                        if (hiddenImages[index].Equals(hiddenImages[i])) {
                            if (!power_ups.ContainsKey(i)) {
                                int c = 0;
                                foreach (Button buttonX in myGrid.Children) {
                                    if (c.Equals(i)) {
                                        // if condition satisfied
                                        // one pair of buttons found, then add to list
                                        if (buttonX.IsEnabled.Equals(true)) {
                                            indeces.Add(index);
                                            indeces.Add(i);
                                            break;
                                        }
                                    }
                                    c++;
                                }
                            }
                            break;
                        }
                    }
                    if (indeces.Count.Equals(4)) {
                        // break if two pair of buttons(equal content) found
                        break;
                    }
                }
                index++;
            }
            // End code

            // Start code
            if (!indeces.Count.Equals(0)) {
                // reveal buttons
                indeces.Sort();
                index = 0;
                int j = 0;
                foreach (Button button in myGrid.Children) {
                    if (indeces[j].Equals(index)) {
                        button.Content = new Image {
                            Source = new BitmapImage(new Uri(hiddenImages[index], UriKind.Relative)),
                            Stretch = Stretch.Fill
                        };
                        button.IsEnabled = false;
                        j++;
                        if (j >= indeces.Count) {
                            break;
                        }
                    }
                    index++;
                }
            }
            // End code
        }
        public void Hint(ref Grid myGrid, ref Dictionary<int, string> power_ups, ref List<string> hiddenImages, ref List<int> futureButtons) {
            // hint power_up select 8 random buttons, each buttons is unique in content
            int index = 0;
            List<int> indeces = new List<int>();        // store the selected button to be hint power_up
            List<int> equalIndeces = new List<int>();   // store the pair of the selected buttons
           
            // Start code
            foreach (Button button in myGrid.Children) {
                // get a maximum of 8 buttons(not equal)
                if (power_ups.ContainsKey(index)) {
                    index++;
                    continue;
                }
                if (futureButtons.Contains(index)) {
                    index++;
                    continue;
                }
                if (equalIndeces.Contains(index)) { // check if the pair is already added
                    index++;
                    continue;
                }
                else if (button.IsEnabled.Equals(true)) {   
                    // if condition satisfied
                    // index add to list
                    indeces.Add(index);
                    for (int i = index + 1; i < hiddenImages.Count; i++) {
                        // find the pair of selected button
                        if (hiddenImages[index].Equals(hiddenImages[i])) {
                            equalIndeces.Add(i);
                            break;
                        }
                    }
                    if (indeces.Count.Equals(8)) {
                        break;
                    }
                }
                index++;
            }
            // End code
           
            // Start code
            Button revealButton = new Button();
            Button futureButton = new Button();
            int revealButtonIndex = -1;
            int futureButtonIndex = -1;
            int c = 0;
            foreach(var items in power_ups) {
                // get the button that has reveal power up
                if (items.Value.Contains("Reveal")) {
                    revealButtonIndex = items.Key;
                    c++;
                }
                else if (items.Value.Contains("Future")) {
                    futureButtonIndex = items.Key;
                    c++;
                }
                if (c.Equals(2)) {
                    break;
                }
            }
            index = 0;
            c = 0;
            foreach(Button button in myGrid.Children) {
                if (revealButtonIndex.Equals(index)) {
                    revealButton = button;
                    c++;
                }
                else if (futureButtonIndex.Equals(index)) {
                    futureButton = button;
                    c++;
                }
                if (c.Equals(2)) {
                    break;
                }
                index++;
            }
            // End code

            // Start code
            if (!indeces.Count.Equals(0)) {
                // reveal hint
                indeces.Sort();
                index = 0;
                int j = 0;
                revealButton.IsEnabled = false;
                futureButton.IsEnabled = false;
                foreach (Button button in myGrid.Children) {
                    if (indeces[j].Equals(index)) {
                        button.Content = new Image {
                            Source = new BitmapImage(new Uri(hiddenImages[index], UriKind.Relative)),
                            Stretch = Stretch.Fill
                        };
                        button.IsEnabled = false;
                        j++;
                        if (j >= indeces.Count) {
                            break;
                        }
                    }
                    index++;
                }
                // back to default
                index = 0;
                j = 0;
                Grid copyMyGrid = myGrid;
                var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
                timer.Start();
                timer.Tick += (sender, args) => {
                    timer.Stop();
                    foreach (Button button in copyMyGrid.Children) {
                        if (indeces[j].Equals(index)) {
                            button.Content = new Image {
                                Source = new BitmapImage(new Uri("/Images/Background/Wooden.png", UriKind.Relative)),
                                Stretch = Stretch.Fill
                            };
                            button.IsEnabled = true;
                            j++;
                            if (j >= indeces.Count) {
                                break;
                            }
                        }
                        index++;
                    }
                    revealButton.IsEnabled = true;
                    futureButton.IsEnabled = true;
                };
            }
            // End code
        }
        public void Shield(ref bool isShieldUsed) {
            isShieldUsed = true;
        }
        public void PauseTimer(ref bool isPauseTimeUsed) {
            isPauseTimeUsed = true;
        }
        public void AddTime(ref bool isAddTimeUsed) {
            isAddTimeUsed = true;
        }
        public void SlowTime(ref bool isSlowTimeUsed) {
            isSlowTimeUsed = true;
        }
    }
}
