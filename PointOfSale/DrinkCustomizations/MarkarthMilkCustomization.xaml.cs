/*
 * Author: Stephanie Krass
 * Class name: MarkarthMilkCustomization.xaml.cs
 * Purpose: Class used for interaction logic for MarkarthMilkCustomization.xaml
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
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for MarkarthMilkCustomization.xaml
    /// </summary>
    public partial class MarkarthMilkCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private MarkarthMilk milk;

        /// <summary>
        /// Constructor for the MarkarthMilkCustomization Class
        /// </summary>
        public MarkarthMilkCustomization()
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
        /// The instance to be modified
        /// </summary>
        public MarkarthMilk Milk
        {
            get
            {
                return milk;
            }
            set
            {
                milk = value;
                DataContext = milk;
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
