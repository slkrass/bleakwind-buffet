﻿/*
 * Author: Stephanie Krass
 * Class name: ComboDragonbornWaffleFriesCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboDragonbornWaffleFriesCustomization.xaml
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
    /// Interaction logic for ComboDragonbornWaffleFriesCustomization.xaml
    /// </summary>
    public partial class ComboDragonbornWaffleFriesCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private DragonbornWaffleFries fries;

        /// <summary>
        /// Constructor for the ComboDragonbornWaffleFriesCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboDragonbornWaffleFriesCustomization.xaml</param>
        public ComboDragonbornWaffleFriesCustomization(MenuContainer container, DragonbornWaffleFries dragonborn)
        {
            InitializeComponent();
            fries = dragonborn;
            DataContext = fries;
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
