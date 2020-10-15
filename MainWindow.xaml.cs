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

namespace SignatureAnalysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    class Cinema
    {
        private bool[,] seats = new bool[30, 15];
        private const int size = 16;
        private const int space = 2;

        public void DrawRectangles(Canvas MyCanvas)
        {
            for (int j = 0; j < seats.GetLength(1); j++)
            {
                for (int i = 0; i < seats.GetLength(0); i++)
                {
                    Rectangle rectangle = new Rectangle
                    {
                        Height = size,
                        Width = size,
                    };

                    rectangle.Fill = seats[i, j] ? Brushes.Red : Brushes.Green;
                    MyCanvas.Children.Add(rectangle);

                    Canvas.SetLeft(rectangle, i * (size + space));
                    Canvas.SetTop(rectangle, j * (size + space));
                }
            }
        }

    }
    public partial class MainWindow : Window
    {
        private Cinema cinema = new Cinema();
       
        public MainWindow()
        {
            InitializeComponent();
            cinema.DrawRectangles(MyCanvas);
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Analysis Signature");
            Valid();
        }

        private void Valid() {
            MessageBox.Show("You Have Access");
        }
        private void InValid() {
            MessageBox.Show("Access Denied");
        }

    }
}
