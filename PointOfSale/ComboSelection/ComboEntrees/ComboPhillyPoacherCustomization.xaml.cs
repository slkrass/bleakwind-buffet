/*
 * Author: Stephanie Krass
 * Class name: ComboPhillyPoacherCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboPhillyPoacherCustomization.xaml
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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboPhillyPoacherCustomization.xaml
    /// </summary>
    public partial class ComboPhillyPoacherCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private PhillyPoacher philly;

        /// <summary>
        /// Constructor for the ComboPhillyPoacherCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboPhillyPoacherCustomization.xaml</param>
        public ComboPhillyPoacherCustomization(MenuContainer container, PhillyPoacher pp)
        {
            InitializeComponent();
            philly = pp;
            DataContext = philly;
            menuContainer = container;
        }

        /// <summary>
        /// Allows the special instructions and size to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection(menuContainer);

        }
    }
}
