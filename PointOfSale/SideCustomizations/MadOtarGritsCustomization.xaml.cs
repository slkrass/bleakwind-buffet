/*
 * Author: Stephanie Krass
 * Class name: MadOtarGritsCustomization.xaml.cs
 * Purpose: Class used for interaction logic for MadOtarGritsCustomization.xaml
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
    /// Interaction logic for MadOtarGritsCustomization.xaml
    /// </summary>
    public partial class MadOtarGritsCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private MadOtarGrits madGrits;

        /// <summary>
        /// Constructor for the MadOtarGritsCustomization Class
        /// </summary>>
        public MadOtarGritsCustomization()
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
        /// The instance of MadOtarGrits to be modified
        /// </summary>
        public MadOtarGrits Grits
        {
            get
            {
                return madGrits;
            }
            set
            {
                madGrits = value;
                DataContext = madGrits;
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
