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
            myRect.Fill = Brushes.Red;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;

            Canvas.SetLeft(myRect, 100);
            Canvas.SetTop(myRect, 100);

            myCanvas.Children.Add(myRect);


            Triangle myTriangle = new Triangle();
            myTriangle.Height = 150;
            myTriangle.Width = 150;
            myTriangle.Fill = Brushes.Blue;
            myTriangle.Stroke = Brushes.Green;
            myTriangle.StrokeThickness = 2;

            Canvas.SetLeft(myTriangle, 150);
            Canvas.SetTop(myTriangle, 200);

            myCanvas.Children.Add(myTriangle);


            Diamond myDiamond = new Diamond();
            myDiamond.Height = 150;
            myDiamond.Width = 150;
            myDiamond.Fill = Brushes.Orange;
            myDiamond.Stroke = Brushes.Purple;
            myDiamond.StrokeThickness = 2;

            Canvas.SetLeft(myDiamond, 300);
            Canvas.SetTop(myDiamond, 250);

            myCanvas.Children.Add(myDiamond);
        }
    }
}
