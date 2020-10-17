/*
 * Author: Stephanie Krass
 * Class name: VokunSaladCustomization.xaml.cs
 * Purpose: Class used for interaction logic for VokunSaladCustomization.xaml
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
    /// Interaction logic for VokunSaladCustomization.xaml
    /// </summary>
    public partial class VokunSaladCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private VokunSalad salad;

        /// <summary>
        /// Constructor for the VokunSaladCustomization Class
        /// </summary>
        public VokunSaladCustomization()
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
        /// The instance of VokunSalad to be modified
        /// </summary>
        public VokunSalad Salad
        {
            get
            {
                return salad;
            }
            set
            {
                salad = value;
                DataContext = salad;
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
