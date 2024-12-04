//using System.Text;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace PaintApp
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        bool end = false;
//        bool start = false;
//        Point currentPoint = new Point();

//        public MainWindow()
//        {
//            InitializeComponent();
//        }

//        private void paintCanvas_MouseDown(object sender, MouseButtonEventArgs e)
//        {
//            if (e.ButtonState == MouseButtonState.Pressed)
//                currentPoint = e.GetPosition(this);
//        }

//        private void paintCanvas_MouseMove(object sender, MouseEventArgs e)
//        {
//            if (e.LeftButton == MouseButtonState.Pressed)
//            {
//                Line line = new Line();

//                SolidColorBrush redBrush = new SolidColorBrush();

//                ComboBoxItem ComboItem1 = (ComboBoxItem)comboBox1.SelectedItem;
//                string name1 = ComboItem1.Name;

//                ComboBoxItem ComboItem2 = (ComboBoxItem)comboBox2.SelectedItem;
//                string name2 = ComboItem2.Name;

//                ComboBoxItem ComboItem3 = (ComboBoxItem)drawStyle.SelectedItem;
//                string name3 = ComboItem3.Name;

//                if (name1 == "one")
//                {
//                    line.StrokeThickness = 2;
//                }
//                else if (name1 == "two")
//                {
//                    line.StrokeThickness = 4;
//                }
//                else if (name1 == "three")
//                {
//                    line.StrokeThickness = 6;
//                }
//                else if (name1 == "four")
//                {
//                    line.StrokeThickness = 10;
//                }
//                else
//                {
//                    line.StrokeThickness = 1;
//                }

//                if (name2 == "red")
//                {
//                    redBrush.Color = Colors.Red;
//                }
//                else if (name2 == "black")
//                {
//                    redBrush.Color = Colors.Black;
//                }
//                else if (name2 == "green")
//                {
//                    redBrush.Color = Colors.Green;
//                }

//                line.Stroke = redBrush;

//                if (name3 == "StraightLine")
//                {
//                    if (end)
//                    {
//                        line.X1 = currentPoint.X;
//                        line.Y1 = currentPoint.Y;
//                        line.X2 = e.GetPosition(this).X;
//                        line.Y2 = e.GetPosition(this).Y;
//                    }
//                }
//                else if (name3 == "FreeDraw")
//                {
//                    line.X1 = currentPoint.X;
//                    line.Y1 = currentPoint.Y;
//                    line.X2 = e.GetPosition(this).X;
//                    line.Y2 = e.GetPosition(this).Y;
//                }

//                currentPoint = e.GetPosition(this);

//                paintCanvas.Children.Add(line);
//            }
//        }
//        private void paintCanvas_MouseUp(object sender, MouseButtonEventArgs e)
//        {
//            end = true;
//        }

//        private void Button_Click(object sender, RoutedEventArgs e)
//        {
//            paintCanvas.Children.Clear();
//        }
//    }
//}