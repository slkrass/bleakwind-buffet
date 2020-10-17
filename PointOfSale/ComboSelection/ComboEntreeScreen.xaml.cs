using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ComboEntreeScreen.xaml
    /// </summary>
    public partial class ComboEntreeScreen : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private Order order;
        private Combo combo;

        public ComboEntreeScreen()
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
                if (pressedButton.Name == "briarheartBurgerButton")
                {
                    combo.ComboEntree = new BriarheartBurger();
                    menuContainer.menuBorder.Child = new ComboBriarheartBurgerCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "doubleDraugrButton")
                {
                    combo.ComboEntree = new DoubleDraugr();
                    menuContainer.menuBorder.Child = new ComboDoubleDraugrCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "thalmorTripleButton")
                {
                    combo.ComboEntree = new ThalmorTriple();
                    menuContainer.menuBorder.Child = new ComboThalmorTripleCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "smokehouseSkeletonButton")
                {
                    combo.ComboEntree = new SmokehouseSkeleton();
                    menuContainer.menuBorder.Child = new ComboSmokehouseSkeletonCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "gardenOrcOmeletteButton")
                {
                    combo.ComboEntree = new GardenOrcOmelette();
                    menuContainer.menuBorder.Child = new ComboGardenOrcOmeletteCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "phillyPoacherButton")
                {
                    combo.ComboEntree = new PhillyPoacher();
                    menuContainer.menuBorder.Child = new ComboPhillyPoacherCustomization() { Container = menuContainer, ComboItem = combo };
                }
                else if (pressedButton.Name == "thugsTBoneButton")
                {
                    combo.ComboEntree = new ThugsTBone();
                    menuContainer.menuBorder.Child = new ComboThugsTBoneCustomization() { Container = menuContainer, ComboItem = combo };
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
            menuContainer.menuBorder.Child = new ComboSelectionStartScreen { Container = menuContainer, ComboItem = combo };
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
