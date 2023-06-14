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
    /// Логика взаимодействия для GiveTaskPage.xaml
    /// </summary>
    public partial class GiveTaskPage : Page
    {
        Core db = new Core();
        public GiveTaskPage()
        {
            InitializeComponent();
            GiveEmployeeTaskCombobox.ItemsSource = db.context.users.ToList();
            GiveEmployeeTaskCombobox.SelectedValuePath = "id_users";
            GiveEmployeeTaskCombobox.DisplayMemberPath = "last_name";

            TaskListCombobox.ItemsSource = db.context.company_task.ToList();
            TaskListCombobox.SelectedValuePath = "id_task";
            TaskListCombobox.DisplayMemberPath = "task_name";
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
            try
            {
                employee_task epltsk = new employee_task()
                {
                    employee_id = Convert.ToInt32(GiveEmployeeTaskCombobox.SelectedValue),
                    task_id = Convert.ToInt32(TaskListCombobox.SelectedValue)
                };
                db.context.employee_task.Add(epltsk);
                db.context.SaveChanges();

                MessageBox.Show("Добавление выполнено успешно !",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Критический сбор в работе приложения:", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
