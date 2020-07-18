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

namespace DevHours_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ColorMatch> colors;
        public MainWindow()
        {
            InitializeComponent();
            colors = new List<ColorMatch>()
            {
                new ColorMatch()
                {
                    Color = Brushes.Red,
                    DecisiveCounter = 0
                },
                new ColorMatch()
                {
                    Color = Brushes.Green,
                    DecisiveCounter = 1
                },
                new ColorMatch()
                {
                    Color = Brushes.Purple,
                    DecisiveCounter = 2
                }
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            redGrid1.Background = redGrid2.Background = redGrid3.Background = redGrid4.Background = colors.First(i => i.DecisiveCounter == 0).Color;
            greenGrid1.Background = greenGrid2.Background = greenGrid3.Background = greenGrid4.Background = colors.First(i => i.DecisiveCounter == 1).Color;
            purpleGrid1.Background = colors.First(i => i.DecisiveCounter == 2).Color;

            foreach(var colorMatch in colors)
            {
                colorMatch.DecisiveCounter++;
                colorMatch.DecisiveCounter %= 3;
            }
            //testLabel.Content += "a";
            //testLabel.Background = Brushes.Aqua;
        }
    }

    public class ColorMatch
    {
        public Brush Color { get; set; }
        public int DecisiveCounter { get; set; }
    }
}
