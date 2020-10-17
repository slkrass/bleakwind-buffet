using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for ComboSideScreen.xaml
    /// </summary>
    public partial class ComboSideScreen : UserControl
    {

        /* Private variable declaration */
        private MenuContainer menuContainer;
        private Order order;
        private Combo combo;

        public ComboSideScreen()
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
            if ((sender is Button pressedButton) && (DataContext is Order order))
            {
                if (pressedButton.Name == "vokunSaladButton")
                {
                    combo.ComboSide = new VokunSalad();
                    menuContainer.menuBorder.Child = new ComboVokunSaladCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "friedMiraakButton")
                {
                    combo.ComboSide = new FriedMiraak();
                    menuContainer.menuBorder.Child = new ComboFriedMiraakCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "madOtarGritsButton")
                {
                    combo.ComboSide = new MadOtarGrits();
                    menuContainer.menuBorder.Child = new ComboMadOtarGritsCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "dragonbornWaffleFriesButton")
                {
                    combo.ComboSide = new DragonbornWaffleFries();
                    menuContainer.menuBorder.Child = new ComboDragonbornWaffleFriesCustomization() { Container = menuContainer, ComboItem = combo};
                }
            }
        }
        /// <summary>
        /// Allows the special instructions and size to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new ComboSelectionStartScreen { Container = menuContainer, ComboItem = combo};
        }

        /// <summary>
        /// Controls the button click events cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                menuContainer.OrderControl = new Order();
                menuContainer.currentItemsInOrderBorder.Child = new OrderList() { Container = menuContainer };
            }
        }

        /// <summary>
        /// Controls the button click events for complete order menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrder(object sender, RoutedEventArgs e)
        {

        }
    }
}
