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

namespace E_commerce1
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        public Homepage()
        {
            InitializeComponent();
        }



        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Signup signup = new Signup();
            this.NavigationService.Navigate(signup);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Reveiws signup = new Reveiws();
            this.NavigationService.Navigate(signup);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Orderdetials orderdetials = new Orderdetials();
            this.NavigationService.Navigate(orderdetials);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            this.NavigationService.Navigate(cart);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userinfo userinfo = new userinfo();
            this.NavigationService.Navigate(userinfo);
        }
    }
}
