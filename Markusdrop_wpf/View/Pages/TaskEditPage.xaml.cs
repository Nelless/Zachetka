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
    /// Логика взаимодействия для TaskEditPage.xaml
    /// </summary>
    public partial class TaskEditPage : Page
    {
        Core db = new Core();
        public TaskEditPage()
        {
            InitializeComponent();
            TaskEditTComboBox.ItemsSource = db.context.company_task.ToList();
            TaskEditTComboBox.SelectedValuePath = "id_task";
            TaskEditTComboBox.DisplayMemberPath = "task_name";
        }

        private void TaskEditBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void TaskEditButton_Click(object sender, RoutedEventArgs e)
        {
            int TaskList = Convert.ToInt32(TaskEditTComboBox.SelectedValue);
            if (TaskList != 0)
            {
                MessageBox.Show("Изменение произошло успешно!",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберете задачу из списка",
                "Предупреждение",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            }
        }

        private void TaskEditTComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            company_task TaskEditCompany = TaskEditTComboBox.SelectedItem as company_task;
            this.DataContext = TaskEditCompany;
        }
    }
}
