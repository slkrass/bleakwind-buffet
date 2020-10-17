/*
 * Author: Stephanie Krass
 * Class name: MenuContainer.xaml.cs
 * Purpose: Class used for interaction logic for MenuContainer.xaml
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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuContainer.xaml
    /// </summary>
    public partial class MenuContainer : UserControl
    {
        /* Private variable declaration */
        private MenuSelection menuSelection;
        private OrderList orderList;
        private Order order;


        /// <summary>
        /// Constructor for the MenuContainer
        /// </summary>
        public MenuContainer()
        {
            InitializeComponent();
            order = new Order();
            menuSelection = new MenuSelection() { Container = this };
            orderList = new OrderList() { Container = this };
            menuBorder.Child = menuSelection;
            currentItemsInOrderBorder.Child = orderList;
        }

        /// <summary>
        /// Gets and sets the current order object
        /// </summary>
        public Order OrderControl
        {
            get { return order; }
            set
            {
                order = value;
            }
        }

    }
}
