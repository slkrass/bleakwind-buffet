/*
 * Author: Stephanie Krass
 * Class name: ThugsTBoneCustomization.xaml.cs
 * Purpose: Class used for the interaction logic for ThugsTBoneCustomization.xaml
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ThugsTBoneCustomization.xaml
    /// </summary>
    public partial class ThugsTBoneCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private ThugsTBone tBone;

        /// <summary>
        /// Constructor for the ThugsTBoneCustomization Class
        /// </summary>
        public ThugsTBoneCustomization()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Allows the special instructions to be recorded 
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
        /// The instance to be modified
        /// </summary>
        public ThugsTBone TBone
        {
            get
            {
                return tBone;
            }
            set
            {
                tBone = value;
                DataContext = tBone;
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
