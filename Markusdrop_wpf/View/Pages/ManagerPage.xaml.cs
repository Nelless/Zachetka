using Markusdrop_wpf.Model;
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
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        Core db = new Core();
        public ManagerPage()
        {
            InitializeComponent();
            EmployeesTasksDataGrid.ItemsSource = db.context.users.ToList();
            EmployeesTasksDataGrid.SelectedValuePath = "id_users";
            EmployeesTasksDataGrid.DisplayMemberPath = "last_name";

            EmployeesTasksDataGrid.ItemsSource = db.context.company_task.ToList();
            EmployeesTasksDataGrid.SelectedValuePath = "id_task";
            EmployeesTasksDataGrid.DisplayMemberPath = "task_name";
        }

        private void TaskManagementButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TaskManagementPage());
        }

        private void TaskGiveButton_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new TaskGivePage());
        }
    }
}
