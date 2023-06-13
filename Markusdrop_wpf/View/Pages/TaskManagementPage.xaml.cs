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
    /// Логика взаимодействия для TaskManagementPage.xaml
    /// </summary>
    public partial class TaskManagementPage : Page
    {
        Core db = new Core();
        public TaskManagementPage()
        {
            InitializeComponent();
            TaskEditTComboBox.ItemsSource = db.context.company_task.ToList();
            TaskEditTComboBox.SelectedValuePath = "id_task";
            TaskEditTComboBox.DisplayMemberPath = "task_name";

            TaskDeleteCombobox.ItemsSource = db.context.company_task.ToList();
            TaskDeleteCombobox.SelectedValuePath = "id_task";
            TaskDeleteCombobox.DisplayMemberPath = "task_name";
        }

        private void TaskManagementBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void TaskAddButton_Click(object sender, RoutedEventArgs e)
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

        private void TaskEditTComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            company_task TaskEditCompany = TaskEditTComboBox.SelectedItem as company_task;
            this.DataContext = TaskEditCompany;
        }

        private void TaskDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var delete = TaskDeleteCombobox.SelectedItem as company_task;
            if (TaskDeleteCombobox.SelectedValue != null)
            {
                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить строку?", "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    db.context.company_task.Remove(delete);
                    db.context.SaveChanges();
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
    }
}
