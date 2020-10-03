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
        /// Allows the DataContext's Size Property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if (DataContext is SailorSoda soda)
            {
                if ((bool)smallSize.IsChecked)
                {
                    soda.Size = Data.Enums.Size.Small;
                }
                else if ((bool)largeSize.IsChecked)
                {
                    soda.Size = Data.Enums.Size.Large;
                }
                else if ((bool)mediumSize.IsChecked)
                {
                    soda.Size = Data.Enums.Size.Medium;
                }
            }
        }

        /// <summary>
        /// Allows the DataContext's Size Property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is SailorSoda soda)
            {
                if ((bool)Blackberry.IsChecked)          soda.Flavor = Data.Enums.SodaFlavor.Blackberry;
                else if ((bool)Cherry.IsChecked)     soda.Flavor = Data.Enums.SodaFlavor.Cherry;
                else if ((bool)Grapefruit.IsChecked)    soda.Flavor = Data.Enums.SodaFlavor.Grapefruit;
                else if ((bool)Lemon.IsChecked)     soda.Flavor = Data.Enums.SodaFlavor.Lemon;
                else if ((bool)Peach.IsChecked)    soda.Flavor = Data.Enums.SodaFlavor.Peach;
                else if ((bool)Watermelon.IsChecked)     soda.Flavor = Data.Enums.SodaFlavor.Watermelon;

            }
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
