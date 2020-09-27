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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BriarheartBurgerCustomization.xaml
    /// </summary>
    public partial class BriarheartBurgerCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;

        /// <summary>
        /// Constructor for the BriarheartBurgerCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the BriarheartBurgerCustomization.xaml</param>
        public BriarheartBurgerCustomization(MenuContainer container)
        {
            InitializeComponent();
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
