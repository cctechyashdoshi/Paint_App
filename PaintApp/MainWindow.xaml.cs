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

namespace PaintApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool end = false;
        Point currentPoint = new Point();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void paintCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                currentPoint = e.GetPosition(paintCanvas);
                end = false;
            }
        }

        private void paintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                ComboBoxItem ComboItem3 = (ComboBoxItem)drawStyle.SelectedItem;
                string name3 = ComboItem3.Name;

                if (name3 == "FreeDraw")
                {
                    // Create small lines for continuous drawing
                    Line line = new Line
                    {
                        X1 = currentPoint.X,
                        Y1 = currentPoint.Y,
                        X2 = e.GetPosition(paintCanvas).X,
                        Y2 = e.GetPosition(paintCanvas).Y,
                        Stroke = GetSelectedBrush(),
                        StrokeThickness = GetSelectedThickness()
                    };

                    paintCanvas.Children.Add(line);
                    currentPoint = e.GetPosition(paintCanvas); // Update for next segment
                }
            }
        }
        private void paintCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (end || !((ComboBoxItem)drawStyle.SelectedItem).Name.Equals("StraightLine")) return;

            // Complete the line only on mouse up for StraightLine
            Line line = new Line
            {
                X1 = currentPoint.X,
                Y1 = currentPoint.Y,
                X2 = e.GetPosition(paintCanvas).X,
                Y2 = e.GetPosition(paintCanvas).Y,
                Stroke = GetSelectedBrush(),
                StrokeThickness = GetSelectedThickness()
            };

            paintCanvas.Children.Add(line);
            end = true;
        }
        private Brush GetSelectedBrush()
        {
            ComboBoxItem ComboItem2 = (ComboBoxItem)comboBox2.SelectedItem;
            switch (ComboItem2.Name)
            {
                case "red": return Brushes.Red;
                case "black": return Brushes.Black;
                case "green": return Brushes.Green;
                default: return Brushes.Black;
            }
        }
        private double GetSelectedThickness()
        {
            ComboBoxItem ComboItem1 = (ComboBoxItem)comboBox1.SelectedItem;
            switch (ComboItem1.Name)
            {
                case "one": return 2;
                case "two": return 4;
                case "three": return 6;
                case "four": return 10;
                default: return 1;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            paintCanvas.Children.Clear();
        }
    }
}
