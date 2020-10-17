/*
 * Author: Stephanie Krass
 * Class name: ComboSailorSodaCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboSailorSodaCustomization.xaml
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
    /// Interaction logic for ComboSailorSodaCustomization.xaml
    /// </summary>
    public partial class ComboSailorSodaCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private SailorSoda soda;
        private Combo combo;

        /// <summary>
        /// Constructor for the ComboSailorSodaCustomization Class
        /// </summary>
        public ComboSailorSodaCustomization()
        {
            InitializeComponent();
            //DataContext = soda;
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
                DataContext = (SailorSoda)combo.ComboDrink;
            }
        }

        /// <summary>
        /// Holds the value for the sailor soda instance being changed
        /// </summary>
        public SailorSoda Soda
        {
            get
            {
                return soda;
            }

            set
            {
                soda = value;
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
