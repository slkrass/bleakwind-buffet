/*
 * Author: Stephanie Krass
 * Class name: ComboPhillyPoacherCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboPhillyPoacherCustomization.xaml
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
    /// Interaction logic for ComboPhillyPoacherCustomization.xaml
    /// </summary>
    public partial class ComboPhillyPoacherCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private PhillyPoacher philly;
        private Combo combo;

        /// <summary>
        /// Constructor for the ComboPhillyPoacherCustomization Class
        /// </summary>
        public ComboPhillyPoacherCustomization()
        {
            InitializeComponent();
            //DataContext = philly;
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
                DataContext = (PhillyPoacher)combo.ComboEntree;
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
            }
        }
    }
}
