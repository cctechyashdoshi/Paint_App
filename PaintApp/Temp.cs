//using System.Windows.Controls;
//using System.Windows.Input;
//using System.Windows.Media.Media3D;
//using System.Windows.Media;
//using System.Windows.Shapes;
//using System.Windows;

//using System.Xml.Linq;

//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Input;
//using System.Windows.Shapes;

//namespace WpfApplication1
//{
//    public partial class MainWindow : Window
//    {

//        Point currentPoint = new Point();

//        public MainWindow()
//        {
//            InitializeComponent();
//        }

//        private void Canvas_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
//        {
//            if (e.ButtonState == MouseButtonState.Pressed)
//                currentPoint = e.GetPosition(this);
//        }

//        private void Canvas_MouseMove_1(object sender, System.Windows.Input.MouseEventArgs e)
//        {
//            if (e.LeftButton == MouseButtonState.Pressed)
//            {
//                Line line = new Line();

//                line.Stroke = SystemColors.WindowFrameBrush;
//                line.X1 = currentPoint.X;
//                line.Y1 = currentPoint.Y;
//                line.X2 = e.GetPosition(this).X;
//                line.Y2 = e.GetPosition(this).Y;

//                currentPoint = e.GetPosition(this);

//                paintSurface.Children.Add(line);
//            }
//        }

//    }
//}