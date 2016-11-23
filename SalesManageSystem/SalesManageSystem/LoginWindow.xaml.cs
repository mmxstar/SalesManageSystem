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
using SalesManageSystem.Dao;
using SalesManageSystem.Model;

namespace SalesManageSystem
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtnClicked(object sender, RoutedEventArgs e)
        {
            //do something check user
            LoginDao loginDao = new LoginDao();
            User user = new User();
            user.UserName = userNameTextBox.Text;
            user.Password = passwordBox.Password;
            if (loginDao.Login(user))
            {
                //show main window
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else {
                errorMessageTBlock.Visibility = Visibility.Visible;
            }
            
        }
    }
}
