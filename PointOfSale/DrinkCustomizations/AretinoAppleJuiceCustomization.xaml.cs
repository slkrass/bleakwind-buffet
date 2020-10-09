/*
 * Author: Stephanie Krass
 * Class name: AretinoAppleJuiceCustomization.xaml.cs
 * Purpose: Class used for interaction logic for AretinoAppleJuiceCustomization.xaml
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
    /// Interaction logic for AretinoAppleJuiceCustomization.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;

        private AretinoAppleJuice appleJuice;

        /// <summary>
        /// Constructor for the AretinoAppleJuiceCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the AretinoAppleJuiceCustomization.xaml</param>
        public AretinoAppleJuiceCustomization(MenuContainer container, AretinoAppleJuice aj)
        {
            InitializeComponent();
            appleJuice = aj;
            DataContext = appleJuice;
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
