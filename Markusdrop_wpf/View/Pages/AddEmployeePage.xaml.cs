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
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        Core db = new Core();
        public AddEmployeePage()
        {
            InitializeComponent();
            UserRoleComboBox.ItemsSource = db.context.user_role.ToList();
            UserRoleComboBox.DisplayMemberPath = "user_role_name";
            UserRoleComboBox.SelectedValuePath = "id_user_role";
        }

        private void AuthEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                users us = new users()
                {
                    first_name = FirstNameTextBox.Text,
                    last_name = LastNameTextBox.Text,
                    patronimyc = PatronymicTextBox.Text,
                    phone = PhoneTextBox.Text,
                    passport_code = PassportCodeTextBox.Text,
                    passport_number = PassportNumberTextBox.Text,
                    INN = INNTextBox.Text,
                    SNILS = SNILSTextBox.Text,
                    email = EmailTextBox.Text,
                    login = LoginTextBox.Text,
                    password = PasswordBox.Password,
                    user_role_fk = Convert.ToInt32(UserRoleComboBox.SelectedValue)

                };
                db.context.users.Add(us);
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

        private void AddEmployeeBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
