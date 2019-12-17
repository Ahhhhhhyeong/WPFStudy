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

namespace TestEvent
{
    /// <summary>
    /// Menu1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu1 : Page
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void join_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/JoinT.xaml", UriKind.Relative));
        }

        private void survey_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/Survey.xaml", UriKind.Relative));
        }
    }
}
