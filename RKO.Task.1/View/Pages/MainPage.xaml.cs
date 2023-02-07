using RKO.Task._1.Core;
using RKO.Task._1.View.Pages.TaskPages;
using System.Windows;
using System.Windows.Controls;

namespace RKO.Task._1.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task1Page());
        }
    }
}
