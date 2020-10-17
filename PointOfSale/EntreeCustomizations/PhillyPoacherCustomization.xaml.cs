/*
 * Author: Stephanie Krass
 * Class name: PhillyPoacherCustomization.xaml.cs
 * Purpose: Class used for interaction logic for PhillyPoacherCustomization.xaml
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
    /// Interaction logic for PhillyPoacherCustomization.xaml
    /// </summary>
    public partial class PhillyPoacherCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private PhillyPoacher philly;

        /// <summary>
        /// Constructor for the PhillyPoacherCustomization Class
        /// </summary>
        public PhillyPoacherCustomization()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Allows the special instructions and size to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection() { Container = menuContainer };

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

        /// <summary>
        /// The instance to be modified
        /// </summary>
        public PhillyPoacher Philly
        {
            get
            {
                return philly;
            }
            set
            {
                philly = value;
                DataContext = philly;
            }
        }
    }
}
