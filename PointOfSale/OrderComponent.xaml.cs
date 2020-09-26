using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuContainer.xaml
    /// </summary>
    public partial class MenuContainer : UserControl
    {
        MenuSelection menuSelection = new MenuSelection();
        OrderList orderList = new OrderList();
        public MenuContainer()
        {
            InitializeComponent();
            menuBorder.Child = menuSelection;
            currentItemsInOrderBorder.Child = orderList;
        }
    }
}
