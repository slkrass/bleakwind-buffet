/*
 * Author: Stephanie Krass
 * Class name: BriarheartBurgerCustomization.xaml.cs
 * Purpose: Class used for interaction logic for BriarheartBurgerCustomization.xaml
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
    /// Interaction logic for BriarheartBurgerCustomization.xaml
    /// </summary>
    public partial class BriarheartBurgerCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private BriarheartBurger burger;

        /// <summary>
        /// Constructor for the BriarheartBurgerCustomization Class
        /// </summary>
        public BriarheartBurgerCustomization()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Allows the special instructions to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };


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
                DataContext = burger;
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
