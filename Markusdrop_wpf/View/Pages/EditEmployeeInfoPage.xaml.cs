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
	/// Логика взаимодействия для EditEmployeeInfoPage.xaml
	/// </summary>
	public partial class EditEmployeeInfoPage : Page
	{
		Core db = new Core();
		public EditEmployeeInfoPage()
		{
			InitializeComponent();
			EditEmployeeComboBox.ItemsSource = db.context.users.ToList();
			EditEmployeeComboBox.SelectedValuePath = "id_users";
			EditEmployeeComboBox.DisplayMemberPath = "FLP";
		}

		private void EditEmployeeBackButton_Click(object sender, RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new AdminPage());
		}

		private void EditEmployeeAcceptButton_Click(object sender, RoutedEventArgs e)
		{
			int EmployeesList = Convert.ToInt32(EditEmployeeComboBox.SelectedValue);
			if (EmployeesList != 0)
			{
				
			}
			else
			{
				MessageBox.Show("Выберете сотрудника из списка!",
				"Предупреждение",
				MessageBoxButton.OK,
				MessageBoxImage.Error);
			}
		}

		private void EditEmployeeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

			users activeUser = EditEmployeeComboBox.SelectedItem as users;
			this.DataContext = activeUser;

		//users users= db.context.users.FirstOrDefault(x=>x.id_users==userId);

		//	BeforeFirstNameTextBlock.Text = users.first_name;
		//	BeforeLastNameTextBlock.Text = users.last_name;
		//	BeforePatronymicTextBlock.Text = users.patronimyc;
		//	BeforePhoneTextBlock.Text = users.phone;
		//	BeforePassportCodeTextBlock.Text = users.passport_code;
		//	BeforePassportNumberTextBlock.Text = users.passport_number;
		//	BeforeEmailTextBlock.Text = users.email;
		}
	}
}
