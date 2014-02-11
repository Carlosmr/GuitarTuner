using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using GuitarTuner.Common;
using Windows.UI.ViewManagement;

namespace GuitarTuner
{
    public sealed partial class MainPage : Common.LayoutAwarePage
    {

        public MainPage()
        {
            this.InitializeComponent();

            Window.Current.SizeChanged += Current_SizeChanged;
            VisualStateManager.GoToState(this, ApplicationView.Value.ToString(), true);

        }

        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private void Current_SizeChanged(Object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            VisualStateManager.GoToState(this, ApplicationView.Value.ToString(), true);
            
        }

        
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int indice = -1;
            ComboBox combo = sender as ComboBox;
            if (combo != null)
            {
                indice = combo.SelectedIndex;
                if(Tunings != null && Tunings_vertical != null)
                    if (Tunings.SelectedIndex != indice)
                        Tunings.SelectedIndex = indice;
                    else
                        Tunings_vertical.SelectedIndex = indice;
            }
            if(string6 != null)
            switch (indice)
            {
                case 0:
                    string6.Text = "E";
                    string6_vertical.Text = "E";
                    player6.Source = new Uri("ms-appx:///Sounds/E(low).mp3");
                    string5.Text = "A";
                    string5_vertical.Text = "A";
                    player5.Source = new Uri("ms-appx:///Sounds/A.mp3");
                    string4.Text = "D";
                    string4_vertical.Text = "D";
                    player4.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    string3.Text = "B";
                    string3_vertical.Text = "B";
                    player3.Source = new Uri("ms-appx:///Sounds/B.mp3");
                    string2.Text = "G";
                    string2_vertical.Text = "G";
                    player2.Source = new Uri("ms-appx:///Sounds/G.mp3");
                    string1.Text = "E";
                    string1_vertical.Text = "E";
                    player1.Source = new Uri("ms-appx:///Sounds/E(high).mp3");
                    break;
                case 1:
                    string6.Text = "D";
                    string6_vertical.Text = "D";
                    player6.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    string5.Text = "A";
                    string5_vertical.Text = "A";
                    player5.Source = new Uri("ms-appx:///Sounds/A.mp3");
                    string4.Text = "D";
                    string4_vertical.Text = "D";
                    player4.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    string3.Text = "B";
                    string3_vertical.Text = "B";
                    player3.Source = new Uri("ms-appx:///Sounds/B.mp3");
                    string2.Text = "G";
                    string2_vertical.Text = "G";
                    player2.Source = new Uri("ms-appx:///Sounds/G.mp3");
                    string1.Text = "E";
                    string1_vertical.Text = "E";
                    player1.Source = new Uri("ms-appx:///Sounds/E(high).mp3");
                    break;
                case 2:
                    string6.Text = "D";
                    string6_vertical.Text = "D";
                    player6.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    string5.Text = "A";
                    string5_vertical.Text = "A";
                    player5.Source = new Uri("ms-appx:///Sounds/A.mp3");
                    string4.Text = "D";
                    string4_vertical.Text = "D";
                    player4.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    string3.Text = "G";
                    string3_vertical.Text = "G";
                    player3.Source = new Uri("ms-appx:///Sounds/G.mp3");
                    string2.Text = "A";
                    string2_vertical.Text = "A";
                    player2.Source = new Uri("ms-appx:///Sounds/A.mp3");
                    string1.Text = "D";
                    string1_vertical.Text = "D";
                    player1.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    break;
                case 3:
                    string6.Text = "D";
                    string6_vertical.Text = "D";
                    player6.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    string5.Text = "G";
                    string5_vertical.Text = "G";
                    player5.Source = new Uri("ms-appx:///Sounds/G.mp3");
                    string4.Text = "D";
                    string4_vertical.Text = "D";
                    player4.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    string3.Text = "G";
                    string3_vertical.Text = "G";
                    player3.Source = new Uri("ms-appx:///Sounds/G.mp3");
                    string2.Text = "B";
                    string2_vertical.Text = "B";
                    player2.Source = new Uri("ms-appx:///Sounds/B.mp3");
                    string1.Text = "D";
                    string1_vertical.Text = "D";
                    player1.Source = new Uri("ms-appx:///Sounds/D.mp3");
                    break;
                default: break;
            
            }

        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            player1.Position = TimeSpan.Zero;
            player1.Play();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            player2.Position = TimeSpan.Zero;
            player2.Play();
        }


        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            player3.Position = TimeSpan.Zero;
            player3.Play();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            player4.Position = TimeSpan.Zero;
            player4.Play();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            player5.Position = TimeSpan.Zero;
            player5.Play();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            player6.Position = TimeSpan.Zero;
            player6.Play();
        }
    }
}
