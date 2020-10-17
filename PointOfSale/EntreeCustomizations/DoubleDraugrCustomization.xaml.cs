/*
 * Author: Stephanie Krass
 * Class name: DoubleDraugrCustomization.xaml.cs
 * Purpose: Class used for interaction logic for DoubleDraugrCustomization.xaml
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
    /// Interaction logic for DoubleDraugrCustomization.xaml
    /// </summary>
    public partial class DoubleDraugrCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private DoubleDraugr burger;

        /// <summary>
        /// Constructor for the DoubleDraugrCustomization Class
        /// </summary>
        public DoubleDraugrCustomization()
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
            menuContainer.menuBorder.Child = new MenuSelection(){ Container = menuContainer};

        }

        /// <summary>
        /// The instance to be modified
        /// </summary>
        public DoubleDraugr Burger
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
