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
    /// Логика взаимодействия для AreaEmployeePage.xaml
    /// </summary>
    public partial class AreaEmployeePage : Page
    {
        Core db = new Core();
        public AreaEmployeePage()
        {
            InitializeComponent();
            EmployeeComboBox.ItemsSource = db.context.users.ToList();
            EmployeeComboBox.SelectedValuePath = "id_users";
            EmployeeComboBox.DisplayMemberPath = "FLP";

            AreaComboBox.ItemsSource = db.context.company_areas.ToList();
            AreaComboBox.SelectedValuePath = "id_area";
            AreaComboBox.DisplayMemberPath = "area_name";
        }

        private void AreaEmployeeBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void AreaConnectButton_Click(object sender, RoutedEventArgs e)
        {
            users users = new users()
            {
                id_users = Convert.ToInt32(EmployeeComboBox.SelectedValue),
            };
            /*
             * 
             */
        }
    }
}
