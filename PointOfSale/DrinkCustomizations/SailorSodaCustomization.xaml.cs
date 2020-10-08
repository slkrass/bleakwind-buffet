/*
 * Author: Stephanie Krass
 * Class name: SailorSodaCustomization.xaml.cs
 * Purpose: Class used for interaction logic for SailorSodaCustomization.xaml
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
    /// Interaction logic for SailorSodaCustomization.xaml
    /// </summary>
    public partial class SailorSodaCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private SailorSoda soda;

        /// <summary>
        /// Constructor for the SailorSodaCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the SailorSodaCustomization.xaml</param>
        public SailorSodaCustomization(MenuContainer container)
        {
            InitializeComponent();
            soda = new SailorSoda();
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
