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

namespace WpfGraphicsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Path path = new Path();
            path.Fill = Brushes.Red;
            path.Stroke = Brushes.Yellow;
            path.StrokeThickness = 5;
            PathGeometry pathGeometry = new PathGeometry();
            
            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = new Point(50, 50);
            pathFigure.IsClosed = true;

            LineSegment line1 = new LineSegment();
            line1.Point = new Point(150, 100);

            LineSegment line2 = new LineSegment();
            line2.Point = new Point(250, 250);

            pathFigure.Segments.Add(line1);
            pathFigure.Segments.Add(line2);

            pathGeometry.Figures.Add(pathFigure);

            path.Data = pathGeometry;

            grid.Children.Add(path);


            //Ellipse ellipse = new();
            //ellipse.Width = 200;
            //ellipse.Height = 200;
            //ellipse.VerticalAlignment = VerticalAlignment.Top;
            //LinearGradientBrush gradient = new LinearGradientBrush();
            //gradient.StartPoint = new Point(0, 0);
            //gradient.EndPoint = new Point(0, 1);
            //gradient.GradientStops.Add(new GradientStop() { Color = Colors.Red, Offset = 0 });
            //gradient.GradientStops.Add(new GradientStop() { Color = Colors.Blue, Offset = 1 });
            //ellipse.Fill = gradient;
            //ellipse.Stroke = Brushes.Yellow;
            //ellipse.StrokeThickness = 5;

            //grid.Children.Add(ellipse);
        }
    }
}
