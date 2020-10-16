/*
 * Author: Stephanie Krass
 * Class name: ComboFriedMiraakCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboFriedMiraakCustomization.xaml
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
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboFriedMiraakCustomization.xaml
    /// </summary>
    public partial class ComboFriedMiraakCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private FriedMiraak miraak;

        /// <summary>
        /// Constructor for the ComboFriedMiraakCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboFriedMiraakCustomization.xaml</param>
        public ComboFriedMiraakCustomization(MenuContainer container, FriedMiraak fried)
        {
            InitializeComponent();
            miraak = fried;
            DataContext = miraak;
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
