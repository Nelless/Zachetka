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
    /// Логика взаимодействия для TaskCreatePage.xaml
    /// </summary>
    public partial class TaskCreatePage : Page
    {
        Core db = new Core();
        public TaskCreatePage()
        {
            InitializeComponent();
        }

        private void TaskCreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskNameAddTextBox.Text != null & TasktextAddTextBox.Text != null)
            {
                MessageBox.Show("Вы уверены, что хотите добавить строку?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Question);
                try
                {
                    company_task comptask = new company_task
                    {
                        task_name = TaskNameAddTextBox.Text,
                        task_text = TasktextAddTextBox.Text,
                    };
                    db.context.company_task.Add(comptask);
                    db.context.SaveChanges();

                    MessageBox.Show("Добавление выполнено успешно !",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Критический сбор в работе приложения:", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("поля:Название задачи/текст задачи не заполнены" +
                    "Пожалуйста, заполните поля.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void TaskCreateBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
