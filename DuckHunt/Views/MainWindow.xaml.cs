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
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;
using System.Windows.Threading;


namespace DuckHunt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GameController c;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void dragable(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void closeGame(object sender, RoutedEventArgs e)
        {
            c.StopGame();
            Dispatcher.CurrentDispatcher.Thread.Abort();
            Close();            
        }

        internal void setLevelLabel(string text)
        {
            if (Dispatcher.CheckAccess())
            {
                levelLabel.Content = text;
            }
            else
            {
                Dispatcher.Invoke(() => levelLabel.Content = text);
            }
        }

        internal void setScoreLabel(string text)
        {
            if (Dispatcher.CheckAccess())
            {
                scoreLabel.Content = text;
            }
            else
            {
                Dispatcher.Invoke(() => scoreLabel.Content = text);
            }
        }

        internal void setFinishedScore(string text)
        {
            if (Dispatcher.CheckAccess())
            {
                finishedScore.Content = text;
            }
            else
            {
                Dispatcher.Invoke(() => finishedScore.Content = text);
            }
        }

        internal void ShowFinishedLabel()
        {
            if (Dispatcher.CheckAccess())
            {
                finishedCanvas.Visibility = Visibility.Visible;
            }
            else
            {
                Dispatcher.Invoke(() => finishedCanvas.Visibility = Visibility.Visible );
            }

            
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            c = new GameController(this);
            startButton.Visibility = Visibility.Hidden;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if( c != null)
            {
                c.StopGame();
            }
        }
    }
}
