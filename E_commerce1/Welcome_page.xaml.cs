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

namespace E_commerce1
{
    /// <summary>
    /// Interaction logic for Welcome_page.xaml
    /// </summary>
    public partial class Welcome_page : Page
    {
        public Welcome_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Signin signin = new Signin();
            this.NavigationService.Navigate(signin);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Signup signup = new Signup();
            this.NavigationService.Navigate(signup);
        }
    }
}
