using BleakwindBuffet.Data;
using BleakwindBuffet.PointOfSale;
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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentScreen.xaml
    /// </summary>
    public partial class CashPaymentScreen : UserControl
    {

        /* Private variable declaration */
        private MenuContainer menuContainer;

        public CashPaymentScreen()
        {
            InitializeComponent();
            
            
        }

        /// <summary>
        /// Controls the button click events for returning to the ordering screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };
            menuContainer.currentItemsInOrderBorder.Child = new OrderList() { Container = menuContainer };
        }

        /// <summary>
        /// Controls the button click events for returning to the ordering screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToPaymentSelection(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new PaymentTypeSelection() { Container = menuContainer };
        }

        /// <summary>
        /// Controls the button click events cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                menuContainer.OrderControl = new Order();
                menuContainer.currentItemsInOrderBorder.Child = new OrderList() { Container = menuContainer };
                menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };
            }
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
                var reg = new CashDrawerViewModel();
                reg.OrderCost = Math.Round(menuContainer.OrderControl.Total, 2);
                DataContext = reg;
            }
        }
    }
}
