/*
 * Author: Stephanie Krass
 * Class name: ComboCandlehearthCoffeeCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboCandlehearthCoffeeCustomization.xaml
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
    /// Interaction logic for ComboCandlehearthCoffeeCustomization.xaml
    /// </summary>
    public partial class ComboCandlehearthCoffeeCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private CandlehearthCoffee coffee;

        /// <summary>
        /// Constructor for the ComboCandleheartCoffeeCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboCandleheartCoffeeCustomization.xaml</param>
        public ComboCandlehearthCoffeeCustomization(MenuContainer container, CandlehearthCoffee candle)
        {
            InitializeComponent();
            coffee = candle;
            DataContext = coffee;
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
