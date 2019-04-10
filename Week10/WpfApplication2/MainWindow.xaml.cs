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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EllipseGeometry myEllipseGeometry;

        public MainWindow()
        {
            InitializeComponent();

            myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.Center = new Point(200, 200);
            myEllipseGeometry.RadiusX = 20;
            myEllipseGeometry.RadiusY = 20;

            Path myPath = new Path();
            myPath.Fill = Brushes.SkyBlue;
            myPath.Data = myEllipseGeometry;

            myCanvas.Children.Add(myPath);

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PointAnimation myPointAnimation = new PointAnimation(e.GetPosition(this), TimeSpan.FromSeconds(1));
            myEllipseGeometry.BeginAnimation(EllipseGeometry.CenterProperty, myPointAnimation);
            myPointAnimation.EasingFunction = new CircleEase();
        }
    }
}
