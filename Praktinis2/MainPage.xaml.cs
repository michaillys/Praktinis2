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

namespace Praktinis2
{ 
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TestPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("TestPage.xaml", UriKind.Relative));
        }

        private void LoginPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Login.xaml", UriKind.Relative));
        }

        
    }
}
