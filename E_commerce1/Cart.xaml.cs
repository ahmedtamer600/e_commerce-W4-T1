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
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Page
    {
        e_commeranceEntities db = new e_commeranceEntities();
        public Cart()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cart_ cart_ = new cart_();
            var i = int.Parse(name.Text);
            datagrid.ItemsSource = db.cart_.Where(x => x.UserID == i).ToList();
        }

       
    }
}
