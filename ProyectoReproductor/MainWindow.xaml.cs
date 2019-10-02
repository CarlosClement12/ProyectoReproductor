using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoReproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Play();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch ((string)((RadioButton)sender).Tag)
            {
                case "T1":
                    MediaPlayer.Source = new Uri(Environment.CurrentDirectory + "\\trailer1.mp4");
                    break;
                case "T2":
                    MediaPlayer.Source = new Uri(Environment.CurrentDirectory + "\\trailer2.mp4");
                    break;
                default:
                    break;
            }
            MediaPlayer.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Stop();
            MediaPlayer.Play();
        }

        private void MuteCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer.IsMuted = true;
        }

        private void MuteCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MediaPlayer.IsMuted = false;
        }
    }
}
