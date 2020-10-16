/*
 * Author: Stephanie Krass
 * Class name: ComboGardenOrcOmeletteCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboGardenOrcOmeletteCustomization.xaml
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
    /// Interaction logic for ComboGardenOrcOmeletteCustomization.xaml
    /// </summary>
    public partial class ComboGardenOrcOmeletteCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private GardenOrcOmelette omelette;

        /// <summary>
        /// Constructor for the ComboGardenOrcOmeletteCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboGardenOrcOmeletteCustomization.xaml</param>
        public ComboGardenOrcOmeletteCustomization(MenuContainer container, GardenOrcOmelette goo)
        {
            InitializeComponent();
            omelette = goo;
            DataContext = omelette;
            menuContainer = container;
        }

        /// <summary>
        /// Allows the special instructions to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection(menuContainer);

        }
    }
}
