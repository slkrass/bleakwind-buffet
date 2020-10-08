/*
 * Author: Stephanie Krass
 * Class name: VokunSaladCustomization.xaml.cs
 * Purpose: Class used for interaction logic for VokunSaladCustomization.xaml
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
    /// Interaction logic for VokunSaladCustomization.xaml
    /// </summary>
    public partial class VokunSaladCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private VokunSalad salad;

        /// <summary>
        /// Constructor for the VokunSaladCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the VokunSaladCustomization.xaml</param>
        public VokunSaladCustomization(MenuContainer container)
        {
            InitializeComponent();
            salad = new VokunSalad();
            DataContext = salad;
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
