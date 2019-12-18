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

namespace BackgroundColorChange
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public System.Windows.Media.Color MyColor { get; set; }
        private void red_Click(object sender, RoutedEventArgs e)
        {
            color.Text = red.Content.ToString();
        }

        private void blue_Click(object sender, RoutedEventArgs e)
        {
            color.Text = blue.Content.ToString();
        }

        private void yellow_Click(object sender, RoutedEventArgs e)
        {
            color.Text = yellow.Content.ToString();
        }
    }
}
