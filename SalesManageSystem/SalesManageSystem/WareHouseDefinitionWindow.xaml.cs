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

namespace SalesManageSystem
{
    /// <summary>
    /// WareHouseDefinitionWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WareHouseDefinitionWindow : Window
    {
        public WareHouseDefinitionWindow()
        {
            InitializeComponent();
        }

        //private CreateWareHouseWindow mCreateWareHourcseWindow;
        private void createwareHouseBtnClicked(object sender, RoutedEventArgs e)
        {
          //  if (mCreateWareHourcseWindow == null) {
          //      mCreateWareHourcseWindow = new CreateWareHouseWindow();
           // }
           // mCreateWareHourcseWindow.Show();
            CreateWareHouseWindow cwhWindow = new CreateWareHouseWindow();
            cwhWindow.Show();
        }
    }
}
