/*
 * Author: Stephanie Krass
 * Class name: ComboSailorSodaCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboSailorSodaCustomization.xaml
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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSailorSodaCustomization.xaml
    /// </summary>
    public partial class ComboSailorSodaCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private SailorSoda soda;

        /// <summary>
        /// Constructor for the ComboSailorSodaCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboSailorSodaCustomization.xaml</param>
        public ComboSailorSodaCustomization(MenuContainer container, SailorSoda sailor)
        {
            InitializeComponent();
            soda = sailor;
            DataContext = soda;
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
