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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle myRect = new Rectangle();
            myRect.Height = 100;
            myRect.Width = 100;
            myRect.Fill = Brushes.Green;
            myRect.Stroke = Brushes.Blue;
            myRect.StrokeThickness = 2;
            Canvas.SetLeft(myRect, 100);
            Canvas.SetTop(myRect, 100);
            myCanvas.Children.Add(myRect);

            Diamond myDiamond = new Diamond();
            myDiamond.Height = 100;
            myDiamond.Width = 100;
            myDiamond.Fill = Brushes.Lavender;
            myDiamond.Stroke = Brushes.Teal;
            myDiamond.StrokeThickness = 2;
            Canvas.SetLeft(myDiamond, 200);
            Canvas.SetTop(myDiamond, 200);
            myCanvas.Children.Add(myDiamond);

            Diamond twoDiamond = new Diamond();
            twoDiamond.Height = 100;
            twoDiamond.Width = 100;
            twoDiamond.Fill = Brushes.Purple;
            twoDiamond.Stroke = Brushes.LightGoldenrodYellow;
            myDiamond.StrokeThickness = 2;
            Canvas.SetLeft(twoDiamond, 300);
            Canvas.SetTop(twoDiamond, 300);

            myCanvas.Children.Add(twoDiamond); Diamond threeDiamond = new Diamond();
            threeDiamond.Height = 100;
            threeDiamond.Width = 100;
            threeDiamond.Fill = Brushes.RosyBrown;
            threeDiamond.Stroke = Brushes.GreenYellow;
            threeDiamond.StrokeThickness = 2;
            Canvas.SetLeft(threeDiamond, 400);
            Canvas.SetTop(threeDiamond, 400);

            myCanvas.Children.Add(threeDiamond); Diamond fourDiamond = new Diamond();
            fourDiamond.Height = 100;
            fourDiamond.Width = 100;
            fourDiamond.Fill = Brushes.Orange;
            fourDiamond.Stroke = Brushes.Purple;
            fourDiamond.StrokeThickness = 2;
            Canvas.SetLeft(fourDiamond, 500);
            Canvas.SetTop(fourDiamond, 500);

            myCanvas.Children.Add(fourDiamond); Diamond fiveDiamond = new Diamond();
            fiveDiamond.Height = 100;
            fiveDiamond.Width = 100;
            fiveDiamond.Fill = Brushes.Salmon;
            fiveDiamond.Stroke = Brushes.LimeGreen;
            fiveDiamond.StrokeThickness = 2;
            Canvas.SetLeft(fiveDiamond, 30);
            Canvas.SetTop(fiveDiamond, 30);
            myCanvas.Children.Add(fiveDiamond);
        }
    }
}
