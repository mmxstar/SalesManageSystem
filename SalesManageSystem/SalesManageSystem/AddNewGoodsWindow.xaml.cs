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
    /// AddNewGoodsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddNewGoodsWindow : Window
    {
        public AddNewGoodsWindow()
        {
            InitializeComponent();
        }

        private void ensureBtnClicked(object sender, RoutedEventArgs e)
        {
            if(goodsNumTBox.Text.Length == 0)
            {
                goodsNumTBox.Text = "货号不可以为空!";
                return;
            }
            if (categoryTBox.Text.Length == 0)
            {
                goodsNumTBox.Text = "类别不可以为空!";
                return;
            }

            Goods goods = new Goods();
            goods.GoodsNumber = goodsNumTBox.Text;
            goods.Category = categoryTBox.Text;
            goods.BarCode = codeTBox.Text;
            goods.Name = nameTBox.Text;
            goods.ProductionPlace = productionPlaceTBox.Text;
            goods.Specification = specificationTBox.Text;
            goods.Unit = unitTBox.Text;
            goods.Version = versionTBox.Text;
            goods.Remark = remarksTBox.Text;

            GoodsDao dao = new GoodsDao();
            dao.AddNewGoods(goods);
        }

        private void cancelBtnClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearBtnClicked(object sender, RoutedEventArgs e)
        {
            goodsNumTBox.Text = "";
            categoryTBox.Text = "";
            codeTBox.Text = "";
            nameTBox.Text = "";
            unitTBox.Text = "";
            specificationTBox.Text = "";
            productionPlaceTBox.Text = "";
            versionTBox.Text = "";
        }
    }
}
