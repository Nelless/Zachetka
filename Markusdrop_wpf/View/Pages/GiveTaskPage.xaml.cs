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

namespace Markusdrop_wpf.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для GiveTaskPage.xaml
    /// </summary>
    public partial class GiveTaskPage : Page
    {
        public GiveTaskPage()
        {
            InitializeComponent();
        }

        private void GiveTaskBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void GiveEmployeeTaskButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
