﻿using System;
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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddEmployeePage());
        }

        private void AreaEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AreaEmployeePage());
        }

        private void EditEmployeeInfoButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EditEmployeeInfoPage());
        }

        private void RemoveEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RemoveEmployeePage());
        }

        private void EmployeeCountRewiewButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
