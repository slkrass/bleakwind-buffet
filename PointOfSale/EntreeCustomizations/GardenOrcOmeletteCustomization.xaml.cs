/*
 * Author: Stephanie Krass
 * Class name: GardenOrcOmeletteCustomization.xaml.cs
 * Purpose: Class used for interaction logic for GardenOrcOmeletteCustomization.xaml
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
    /// Interaction logic for GardenOrcOmeletteCustomization.xaml
    /// </summary>
    public partial class GardenOrcOmeletteCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private GardenOrcOmelette omelette;

        /// <summary>
        /// Constructor for the GardenOrcOmeletteCustomization Class
        /// </summary>
        public GardenOrcOmeletteCustomization()
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
        public GardenOrcOmelette Omelette
        {
            get
            {
                return omelette;
            }
            set
            {
                omelette = value;
                DataContext = omelette;
            }
        }
    }
}
