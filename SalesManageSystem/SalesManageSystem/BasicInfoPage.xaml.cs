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

namespace SalesManageSystem
{
    /// <summary>
    /// BasicInfoPage.xaml 的交互逻辑
    /// </summary>
    public partial class BasicInfoPage : Page
    {
        public BasicInfoPage()
        {
            InitializeComponent();
        }

        private void goodsInfoBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void wareHouseInfoBtnClicked(object sender, RoutedEventArgs e)
        {
            WareHouseDefinitionWindow whdWindow = new WareHouseDefinitionWindow();
            whdWindow.Show();
        }

        private void supplierInfoBtnClicked(object sender, RoutedEventArgs e)
        {

        }

        private void customerInfoBtnClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
