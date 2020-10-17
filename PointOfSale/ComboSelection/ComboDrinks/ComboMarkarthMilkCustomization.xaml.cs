/*
 * Author: Stephanie Krass
 * Class name: ComboMarkarthMilkCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboMarkarthMilkCustomization.xaml
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
using BleakwindBuffet.Data;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboMarkarthMilkCustomization.xaml
    /// </summary>
    public partial class ComboMarkarthMilkCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private MarkarthMilk milk;
        private Combo combo;

        /// <summary>
        /// Constructor for the ComboMarkarthMilkCustomization Class
        /// </summary>
        public ComboMarkarthMilkCustomization()
        {
            InitializeComponent();
            //DataContext = milk;
        }

        /// <summary>
        /// Allows the special instructions and size to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new ComboSelectionStartScreen { Container = menuContainer, ComboItem = combo };

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
                DataContext = (MarkarthMilk)combo.ComboDrink;
            }
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
            set => milk = value;
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
