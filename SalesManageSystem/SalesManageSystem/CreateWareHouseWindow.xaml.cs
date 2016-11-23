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
using SalesManageSystem.Model;
using SalesManageSystem.Dao;

namespace SalesManageSystem
{
    /// <summary>
    /// CreateWareHouseWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CreateWareHouseWindow : Window
    {
        public CreateWareHouseWindow()
        {
            InitializeComponent();
        }

        private void ensureBtnClicked(object sender, RoutedEventArgs e)
        {
            if (wareHouseIdTBox.Text.Length == 0)
            {
                wareHouseIdTBox.Text = "仓库代码不能为空";
            }
            if (wareHouseNameTBox.Text.Length == 0)
            {
                wareHouseIdTBox.Text = "仓库名称不能为空";
            }

            Warehouse warehouse = new Warehouse();
            warehouse.Name = wareHouseNameTBox.Text;
            warehouse.Code = wareHouseIdTBox.Text;
            warehouse.Remark = remarks.Text;

            WarehouseDao dao = new WarehouseDao();
            dao.AddWareHouse(warehouse);
        }

        private void cancelBtnClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
