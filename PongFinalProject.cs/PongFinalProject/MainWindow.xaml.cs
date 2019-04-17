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
using System.Windows.Media.Animation;
namespace PongFinalProject.cs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Rect myRect = new Rect();
            myRect.X = 395;
            myRect.Y = 245;
            myRect.Width = 20;
            myRect.Height = 20;
            RectangleGeometry Ball = new RectangleGeometry();
            Ball.Rect = myRect;

            Path myPath = new Path();
            myPath.Fill = Brushes.White;
            myPath.Data = Ball;

            while (Playing == true)
            {
                PointAnimation myPointAnimation = new PointAnimation(e.GetPosition(this), TimeSpan.FromSeconds(1)); //the new possition and how long it takes to move
                Ball.BeginAnimation(RectangleGeometry.CenterProperty, myPointAnimation); // trigger
            }
            myCanvas.Children.Add(myPath);
           

            Rectangle paddle1 = new Rectangle();
            paddle1.Height = 70;
            paddle1.Width = 20;
            Canvas.SetLeft(paddle1, 75);
            Canvas.SetTop(paddle1, 215);
            paddle1.Fill = Brushes.CornflowerBlue;
            paddle1.Stroke = Brushes.White;
            myCanvas.Children.Add(paddle1);

            Rectangle paddle2 = new Rectangle();
            paddle2.Height = 70;
            paddle2.Width = 20;
            paddle2.Fill = Brushes.Orange;
            paddle2.Stroke = Brushes.White;
            Canvas.SetLeft(paddle2, 685);
            Canvas.SetTop(paddle2, 215);
            myCanvas.Children.Add(paddle2);

        }
    }
}
