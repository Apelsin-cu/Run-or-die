using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace Run_or_die
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer();
        Rect playerHitBox;
        Rect groundHitBox;
        Rect obstacleHitBox;

        bool jumping;

        int force = 20;
        int speed = 5;

        Random rnd = new Random();

        bool gameOver;

        double spriteIndex = 0;

        ImageBrush playerSprite = new ImageBrush();
        ImageBrush backgroundSprite = new ImageBrush();
        ImageBrush obstacleSprite = new ImageBrush();

        int[] obstaclePosition = { 320, 310, 300, 305, 315 };

        int score = 0;

        public MainWindow()
        {
            InitializeComponent();

            MyCanvas.Focus();

            gameTimer.Tick += GameEngine;
            gameTimer.Interval = TimeSpan.FromMicroseconds(20);

            backgroundSprite.ImageSource = new BitmapImage(new Uri("image/fon.gif"));

            background.Fill = backgroundSprite;
            background2.Fill = backgroundSprite;

            StartGame;
        }

        private void GameEngine(object sender, EventArgs e)
        {
           
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void StatGame()
        {
            Canvas.SetLeft(background, 0);
        }

        private void RunSprite(double i)
        {

        }

    }
}