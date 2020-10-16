/*
 * Author: Stephanie Krass
 * Class name: ComboMarkarthMilkCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboMarkarthMilkCustomization.xaml
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
    /// Interaction logic for ComboMarkarthMilkCustomization.xaml
    /// </summary>
    public partial class ComboMarkarthMilkCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private MarkarthMilk milk;

        /// <summary>
        /// Constructor for the ComboMarkarthMilkCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboMarkarthMilkCustomization.xaml</param>
        public ComboMarkarthMilkCustomization(MenuContainer container, MarkarthMilk marMilk)
        {
            InitializeComponent();
            milk = marMilk;
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
