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

namespace InventoryManagement
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemPurchase_Click(object sender, RoutedEventArgs e)
        {
            PurchaseList purchaseList = new PurchaseList();
            purchaseList.Show();
            purchaseList.Focus();
        }

        private void MenuItemSales_Click(object sender, RoutedEventArgs e)
        {
            SalesList salesList = new SalesList();
            salesList.Show();
            salesList.Focus();
        }
    }
}
