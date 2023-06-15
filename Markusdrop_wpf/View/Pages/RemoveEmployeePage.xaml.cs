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
    /// Логика взаимодействия для RemoveEmployeePage.xaml
    /// </summary>
    public partial class RemoveEmployeePage : Page
    {
        Core db = new Core();
        public RemoveEmployeePage()
        {
            InitializeComponent();
            DeleteEmployeeComboBox.ItemsSource = db.context.users.ToList();
            DeleteEmployeeComboBox.SelectedValuePath = "id_users";
            DeleteEmployeeComboBox.DisplayMemberPath = "FLP";
        }

        private void RemoveEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            var delete = DeleteEmployeeComboBox.SelectedItem as users;
            if (DeleteEmployeeComboBox.SelectedValue != null)
            {
                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    db.context.users.Remove(delete);
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

        private void RemoveEmployeeBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
