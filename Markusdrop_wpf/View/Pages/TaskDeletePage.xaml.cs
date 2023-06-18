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
    /// Логика взаимодействия для TaskDeletePage.xaml
    /// </summary>
    public partial class TaskDeletePage : Page
    {
        Core db = new Core();
        public TaskDeletePage()
        {
            InitializeComponent();
            NavigationService.Refresh();
        }

        private void TaskDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var delete = TaskDeleteCombobox.SelectedItem as employee_task;
            if (TaskDeleteCombobox.SelectedValue != null)
            {
                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить строку?", "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    db.context.employee_task.Remove(delete);
                    db.context.SaveChanges();
                    NavigationService.Refresh();
                    MessageBox.Show("Удаление выполнено успешно !",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("пожалуйста, выберете задачу для удаления", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void TaskDeleteBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
