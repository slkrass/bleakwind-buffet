/*
 * Author: Stephanie Krass
 * Class name: ComboAretinoAppleJuiceCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboAretinoAppleJuiceCustomization.xaml
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboAretinoAppleJuiceCustomization.xaml
    /// </summary>
    public partial class ComboAretinoAppleJuiceCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private AretinoAppleJuice appleJuice;
        private Combo combo;

        /// <summary>
        /// Constructor for the ComboAretinoAppleJuiceCustomization Class
        /// </summary>
        public ComboAretinoAppleJuiceCustomization()
        {
            InitializeComponent();
            //DataContext = appleJuice;
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
        /// Gets and sets the value of AppleJuice
        /// </summary>
        public AretinoAppleJuice AppleJuice
        {
            get
            {
                return appleJuice;
            }
            set => appleJuice = value;
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
                DataContext = (AretinoAppleJuice)combo.ComboDrink;
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
            }
        }
    }
}
