/*
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

        /// <summary>
        /// Constructor for the ComboBriarheartBurgerCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboBriarheartBurgerCustomization.xaml</param>
        public ComboBriarheartBurgerCustomization(MenuContainer container, BriarheartBurger briar)
        {
            InitializeComponent();
            burger = briar;
            DataContext = burger;
            menuContainer = container;
        }

        /// <summary>
        /// Allows the special instructions to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
             menuContainer.menuBorder.Child = new MenuSelection(menuContainer);
            
        }
    }
}
