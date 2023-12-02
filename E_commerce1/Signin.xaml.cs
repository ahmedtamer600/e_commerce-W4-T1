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
    /// Interaction logic for Signin.xaml
    /// </summary>
    public partial class Signin : Page
    {
        e_commeranceEntities db = new e_commeranceEntities();
        public Signin()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_ user = new User_();
            try
            {
                db.User_.First(x => x.Username == name.Text && x.Password_ == password.Text);
                Homepage homepage = new Homepage();
                this.NavigationService.Navigate(homepage);
            }
            catch
            {
                MessageBox.Show("sike wrong DATA");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Signup signup = new Signup();
            this.NavigationService.Navigate(signup);
        }
    }
}
