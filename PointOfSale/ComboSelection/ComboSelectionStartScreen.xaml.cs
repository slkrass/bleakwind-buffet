/*
 * Author: Stephanie Krass
 * Class name: ComboSelectionStartScreen.xaml.cs
 * Purpose: Class used for interaction logic forComboSelectionStartScreen.xaml
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;


namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelectionStartScreen.xaml
    /// </summary>
    public partial class ComboSelectionStartScreen : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private Order order;
        private Combo combo;

        /// <summary>
        /// Constructor for the ComboSelectionStartScreen.xaml class
        /// </summary>
        public ComboSelectionStartScreen()
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

        /// <summary>
        /// The combo that will be modified
        /// </summary>
        public Combo ComboItem
        {
            get
            {
                return combo;
            }
            set
            {
                combo = value;
            }
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
        /// Controls the button click events for the menu options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemToCombo(object sender, RoutedEventArgs e)
        {
            if ((sender is Button pressedButton) && (DataContext is Order))
            {
                if (pressedButton.Name == "sideButton")
                {
                    menuContainer.menuBorder.Child = new ComboSideScreen() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "drinkButton")
                {
                    menuContainer.menuBorder.Child = new ComboDrinkScreen() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "entreeButton")
                {
                    menuContainer.menuBorder.Child = new ComboEntreeScreen() { Container = menuContainer, ComboItem = combo };
                }
                
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
