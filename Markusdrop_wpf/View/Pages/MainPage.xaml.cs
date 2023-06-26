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
using Markusdrop_wpf.Model;

namespace Markusdrop_wpf.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Core db = new Core();
        public MainPage()
        {
            InitializeComponent();
            //AuthPage auth = new AuthPage();
            //users userauth = db.context.users.Where(
            //    x => x.login == auth.LoginTextBox.Text && x.password == auth.PasswordTextBox.Password
            //    ).FirstOrDefault();
            //if ( userauth == null)
            //{
            //    MessageBox.Show("Такой пользователь отсутствует!",
            //        "Уведомление",
            //        MessageBoxButton.OK,
            //        MessageBoxImage.Information);
            //}
            //else
            //{
            //    EmployeeFirstNameTextblock.Text
            //}
        }

        private void EmpoloyeeTaskListButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeeTaskListPage());
        }

        private void EmployeeTaskCompleteButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeeTaskCompletePage());
        }
    }
}
