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
    /// Interaction logic for Orderdetials.xaml
    /// </summary>
    public partial class Orderdetials : Page
    {
        e_commeranceEntities db = new e_commeranceEntities();
        public Orderdetials()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var i = int.Parse(name.Text);
            datagrid.ItemsSource= db.order_details.Where(x => x.ProductID == i).ToList();
         
        }

      
    }
}
