/*
 * Author: Stephanie Krass
 * Class name: ThalmorTripleCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ThalmorTripleCustomization.xaml
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
    /// Interaction logic for ThalmorTripleCustomization.xaml
    /// </summary>
    public partial class ThalmorTripleCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private ThalmorTriple burger;

        /// <summary>
        /// Constructor for the ThalmorTripleCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ThalmorTripleCustomization.xaml</param>
        public ThalmorTripleCustomization(MenuContainer container, ThalmorTriple tt)
        {
            InitializeComponent();
            burger = tt;
            DataContext = burger;
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
