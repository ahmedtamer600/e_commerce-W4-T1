using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using System.Xml.Linq;

namespace E_commerce1
{
    /// <summary>
    /// Interaction logic for userinfo.xaml
    /// </summary>
    public partial class userinfo : Page
    {
        e_commeranceEntities db = new e_commeranceEntities();
        public userinfo()
        {
            InitializeComponent();
        }

     

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            User_ user_ = new User_();
            var id = int.Parse(txtSearch.Text);
            datagrid.ItemsSource = db.User_.Where(x => x.UserID == id).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_ user_ = new User_();
            var d = int.Parse(txtSearch.Text);
            user_ = db.User_.First(x => x.UserID == d);
            user_.Username = name.Text;
            user_.Address = address.Text;
            user_.Phone = phone.Text;
            db.User_.AddOrUpdate(user_);
            db.SaveChanges();
            MessageBox.Show("data updated");
            
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            User_ user_ = new User_();

            var i = int.Parse(txtSearch.Text);
            user_ = db.User_.Remove(db.User_.First(x => user_.UserID == i));
            MessageBox.Show("data deleted");

        }
    }
}
