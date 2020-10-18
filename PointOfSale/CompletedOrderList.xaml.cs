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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for CompletedOrderList.xaml
    /// </summary>
    public partial class CompletedOrderList : UserControl
    {
        /* Private Variable Declarations*/
        private MenuContainer menuContainer;
        private Order order;

        public CompletedOrderList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The menu container for the xaml
        /// </summary>
        public MenuContainer Container
        {
            get
            {
                return menuContainer;
            }
            set
            {
                menuContainer = value;
                order = menuContainer.OrderControl;
                DataContext = order;
            }
        }
    }
}
