/*
 * Author: Stephanie Krass
 * Class name: MarkarthMilkCustomization.xaml.cs
 * Purpose: Class used for interaction logic for MarkarthMilkCustomization.xaml
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
    /// Interaction logic for MarkarthMilkCustomization.xaml
    /// </summary>
    public partial class MarkarthMilkCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private MarkarthMilk milk;

        /// <summary>
        /// Constructor for the MarkarthMilkCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the MarkarthMilkCustomization.xaml</param>
        public MarkarthMilkCustomization(MenuContainer container)
        {
            InitializeComponent();
            milk = new MarkarthMilk();
            DataContext = milk;
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
