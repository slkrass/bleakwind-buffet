/*
 * Author: Stephanie Krass
 * Class name: CandlehearthCoffeeCustomization.xaml.cs
 * Purpose: Class used for interaction logic for CandlehearthCoffeeCustomization.xaml
 */
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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffeeCustomization.xaml
    /// </summary>
    public partial class CandlehearthCoffeeCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private CandlehearthCoffee coffee;

        /// <summary>
        /// Constructor for the CandleheartCoffeeCustomization Class
        /// </summary>
        public CandlehearthCoffeeCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows the special instructions and size to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };

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
            }
        }

        /// <summary>
        /// gets and sets the value of coffee
        /// </summary>
        public CandlehearthCoffee Coffee
        {
            get
            {
                return coffee;
            }
            set
            {
                coffee = value;
                DataContext = coffee;
            }
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
        /// Controls the button click events for complete order menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrder(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new PaymentTypeSelection() { Container = menuContainer };
            menuContainer.currentItemsInOrderBorder.Child = new CompletedOrderList() { Container = menuContainer };
        }
    }
}
