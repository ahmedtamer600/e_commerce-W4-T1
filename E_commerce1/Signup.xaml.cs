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
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        e_commeranceEntities db = new e_commeranceEntities();
        public Signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           User_ user = new User_();

            user.Username = name.Text;
            user.Address = address.Text;
            user.Email = email.Text;
            user.Phone = phone.Text;
            user.Password_ =pass.Text;
            db.User_.Add(user);
            db.SaveChanges();
            Homepage homepage = new Homepage();
            this.NavigationService.Navigate(homepage);
        }

     
    }
}
