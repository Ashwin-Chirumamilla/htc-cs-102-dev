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
        GameMovement gm;
        public MainWindow()
        {
            InitializeComponent();
            
            
            PongBall pb = new PongBall();
            int x = 0, y = 0;
            pb.Fill = Brushes.AliceBlue;
            pb.StrokeThickness = 2;
            Canvas.SetLeft(pb, x);
            Canvas.SetTop(pb, y);
            pongCanvas.Children.Add(pb);
          
            gm = new GameMovement(this, pb, 0, 0);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gm.MoveBall();

        }
    }
}
