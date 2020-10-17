﻿/*
 * Author: Stephanie Krass
 * Class name: ComboBriarheartBurgerCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboBriarheartBurgerCustomization.xaml
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboBriarheartBurgerCustomization.xaml
    /// </summary>
    public partial class ComboBriarheartBurgerCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private BriarheartBurger burger;
        private Combo combo;

        /// <summary>
        /// Constructor for the ComboBriarheartBurgerCustomization Class
        /// </summary>
        public ComboBriarheartBurgerCustomization()
        {
            InitializeComponent();
            //ataContext = burger;
        }

        /// <summary>
        /// Allows the special instructions and size to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new ComboSelectionStartScreen() { Container = menuContainer, ComboItem = combo };

        }

        /// <summary>
        /// The combo that will be modified
        /// </summary>
        public Combo ComboItem
        {
            get
            {
                return combo;
            }
            set
            {
                combo = value;
                DataContext = (BriarheartBurger)combo.ComboEntree;
            }
        }


        /// <summary>
        /// The instance to be modified
        /// </summary>
        public BriarheartBurger Burger
        {
            get
            {
                return burger;
            }
            set
            {
                burger = value;
            }
        }

        /// <summary>
        /// The menu container for the xaml
        /// </summary>
        public MenuContainer Container
        {
            get
            {
                return menuContainer;
            }
            set
            {
                menuContainer = value;
            }
        }
    }
}
