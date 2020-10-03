/*
 * Author: Stephanie Krass
 * Class name: CandlehearthCoffeeCustomization.xaml.cs
 * Purpose: Class used for interaction logic for CandlehearthCoffeeCustomization.xaml
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
    /// Interaction logic for CandlehearthCoffeeCustomization.xaml
    /// </summary>
    public partial class CandlehearthCoffeeCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;

        private CandlehearthCoffee coffee;

        /// <summary>
        /// Constructor for the CandleheartCoffeeCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the CandleheartCoffeeCustomization.xaml</param>
        public CandlehearthCoffeeCustomization(MenuContainer container)
        {
            InitializeComponent();
            coffee = new CandlehearthCoffee();
            DataContext = coffee;
            menuContainer = container;
        }

        /// <summary>
        /// Allows the DataContext's Size Property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if (DataContext is CandlehearthCoffee coffee)
            {
                if ((bool)smallSize.IsChecked)
                {
                    coffee.Size = Data.Enums.Size.Small;
                }
                else if ((bool)largeSize.IsChecked)
                {
                    coffee.Size = Data.Enums.Size.Large;
                }
                else if ((bool)mediumSize.IsChecked)
                {
                    coffee.Size = Data.Enums.Size.Medium;
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
            menuContainer.menuBorder.Child = new MenuSelection(menuContainer);

        }
    }
}
