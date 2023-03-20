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
    /// Логика взаимодействия для AuthTypePage.xaml
    /// </summary>
    public partial class AuthTypePage : Page
    {
        public AuthTypePage()
        {
            InitializeComponent();
        }

        private void EmployeeAuthButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeeAuthPage());
        }

        private void ManagerAuthButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ManagerAuthPage());
        }

        private void AdminAuthButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminAuthPage());
        }
    }
}
