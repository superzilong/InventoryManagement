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
using System.Windows.Shapes;

namespace InventoryManagement
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            //try
            //{
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.Focus();
            this.Close();


            //string strSqlcon = "server=localhost;user id=root;password=;database=inventory_management"; //根据自己的设置
            //MySqlConnection myCon = new MySqlConnection(strSqlcon);
            //if(myCon == null)
            //{
            //    throw new Exception("Connect failed!");
            //}
            //myCon.Open();
            //MySqlDataReader reader = null;
            //MySqlCommand cmd = new MySqlCommand("SELECT name FROM users", myCon);
            //reader = cmd.ExecuteReader();
            //List<string> names = new List<string>();
            //while (reader.Read())
            //{
            //    names.Add(reader.GetString(0));
            //}
            //reader.Close();
            //string strUserName = (string)this.uiUserName.Text;
            //bool bExisted = names.Contains(strUserName);
            //if(bExisted)
            //{
            //    MySqlCommand cmd1 = new MySqlCommand(String.Format("SELECT password FROM users WHERE name=\"{0}\"", strUserName), myCon);
            //    reader = cmd1.ExecuteReader();
            //    if(reader.Read())
            //    {
            //        string strPassWord = (string)this.uiPassWord.Password;
            //        if(strPassWord == reader.GetString(0))
            //        {
            //            MainWindow mainWindow = new MainWindow();
            //            mainWindow.Show();
            //            mainWindow.Focus();
            //        }
            //        else
            //        {
            //            MessageBox.Show("密码不正确！");
            //        }
            //    }
            //    reader.Close();
            //}
            //else
            //{
            //    MessageBox.Show("用户名不存在！");
            //}
            //myCon.Close();
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
