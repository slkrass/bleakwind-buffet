/*
 * Author: Stephanie Krass
 * Class name: ComboMadOtarGritsCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboMadOtarGritsCustomization.xaml
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
using BleakwindBuffet.Data;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboMadOtarGritsCustomization.xaml
    /// </summary>
    public partial class ComboMadOtarGritsCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private Combo combo;

        /// <summary>
        /// Constructor for the ComboMadOtarGritsCustomization Class
        /// </summary>
        public ComboMadOtarGritsCustomization()
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
                DataContext = (MadOtarGrits)combo.ComboSide;
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
