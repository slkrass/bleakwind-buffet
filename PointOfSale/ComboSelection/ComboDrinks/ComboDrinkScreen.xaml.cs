using BleakwindBuffet.Data;
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
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboDrinkScreen.xaml
    /// </summary>
    public partial class ComboDrinkScreen : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private Order order;
        private Combo combo;

        public ComboDrinkScreen()
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
        /// Controls the button click events for the menu options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemToOrder(object sender, RoutedEventArgs e)
        {
            if ((sender is Button pressedButton) && (DataContext is Order))
            {
                if (pressedButton.Name == "sailorSodaButton")
                {
                    combo.ComboDrink = new SailorSoda();
                    menuContainer.menuBorder.Child = new ComboSailorSodaCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "markarthMilkButton")
                {
                    combo.ComboDrink = new MarkarthMilk();
                    menuContainer.menuBorder.Child = new ComboMarkarthMilkCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "aretinoAppleJuiceButton")
                {
                    combo.ComboDrink = new AretinoAppleJuice();
                    menuContainer.menuBorder.Child = new ComboAretinoAppleJuiceCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "candlehearthCoffeeButton")
                {
                    combo.ComboDrink = new CandlehearthCoffee();
                    menuContainer.menuBorder.Child = new ComboCandlehearthCoffeeCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "warriorWaterButton")
                {
                    combo.ComboDrink = new WarriorWater();
                    menuContainer.menuBorder.Child = new ComboWarriorWaterCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "doneButton")
                {
                    menuContainer.menuBorder.Child = new ComboSelectionStartScreen { Container = menuContainer, ComboItem = combo };
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
