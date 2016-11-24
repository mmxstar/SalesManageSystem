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
    /// GoodsInfoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class GoodsInfoWindow : Window
    {
        public GoodsInfoWindow()
        {
            InitializeComponent();

            GoodsDao goodsDao = new GoodsDao();
            goodsDataGrid.ItemsSource = goodsDao.SelectAll();
        }

        private void addNewGoods_BtnClicked(object sender, RoutedEventArgs e)
        {
            AddNewGoodsWindow addNewGoodsWindow = new AddNewGoodsWindow();
            addNewGoodsWindow.Show();
        }

        private void modifyGoods_BtnClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
