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
    /// Interaction logic for Reveiws.xaml
    /// </summary>
    public partial class Reveiws : Page
    {
        e_commeranceEntities db = new e_commeranceEntities();
        public Reveiws()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var u = int.Parse(ID.Text);
            datagrid.ItemsSource = db.Reviews.Where(x => x.UserID == u).ToList();
        }

      
    }
}