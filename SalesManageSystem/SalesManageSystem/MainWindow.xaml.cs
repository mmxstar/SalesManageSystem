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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            
            switch (listBox.SelectedIndex) {
                case 0:
                    sceneFrame.Content = new BasicInfoPage();
                    currentItemName.Text = "基础资料";
                    break;
                case 1:
                    sceneFrame.Content = new PurchaseManagementPage();
                    currentItemName.Text = "进货管理";
                    break;
                case 2:
                    sceneFrame.Content = new SalesManagementPage();
                    currentItemName.Text = "销售管理";
                    break;
                case 3:
                    sceneFrame.Content = new InventoryManagementPage();
                    currentItemName.Text = "库存管理";
                    break;
                default:
                    break; 
            }
        }
    }
}
