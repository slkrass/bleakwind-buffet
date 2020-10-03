/*
 * Author: Stephanie Krass
 * Class name: WarriorWaterCustomization.xaml.cs
 * Purpose: Class used for interaction logic for WarriorWaterCustomization.xaml
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
    /// Interaction logic for WarriorWaterCustomization.xaml
    /// </summary>
    public partial class WarriorWaterCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private WarriorWater water;

        /// <summary>
        /// Constructor for the WarriorWaterCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the WarriorWaterCustomization.xaml</param>
        public WarriorWaterCustomization(MenuContainer container)
        {
            InitializeComponent();
            water = new WarriorWater();
            DataContext = water;
            menuContainer = container;
        }

        /// <summary>
        /// Allows the DataContext's Size Property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if (DataContext is WarriorWater water)
            {
                if ((bool)smallSize.IsChecked)
                {
                    water.Size = Data.Enums.Size.Small;
                }
                else if ((bool)largeSize.IsChecked)
                {
                    water.Size = Data.Enums.Size.Large;
                }
                else if ((bool)mediumSize.IsChecked)
                {
                    water.Size = Data.Enums.Size.Medium;
                }
            }
        }

        /// <summary>
        /// Allows the special instructions and size to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection(menuContainer);

        }
    }
}
