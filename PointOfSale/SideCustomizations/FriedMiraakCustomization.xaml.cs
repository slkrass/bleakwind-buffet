/*
 * Author: Stephanie Krass
 * Class name: FriedMiraakCustomization.xaml.cs
 * Purpose: Class used for interaction logic for FriedMiraakCustomization.xaml
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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for FriedMiraakCustomization.xaml
    /// </summary>
    public partial class FriedMiraakCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;

        /// <summary>
        /// Constructor for the FriedMiraakCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the FriedMiraakCustomization.xaml</param>
        public FriedMiraakCustomization(MenuContainer container)
        {
            InitializeComponent();
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
