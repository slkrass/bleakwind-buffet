/*
 * Author: Stephanie Krass
 * Class name: AretinoAppleJuiceCustomization.xaml.cs
 * Purpose: Class used for interaction logic for AretinoAppleJuiceCustomization.xaml
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
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceCustomization.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;

        private AretinoAppleJuice appleJuice;

        /// <summary>
        /// Constructor for the AretinoAppleJuiceCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the AretinoAppleJuiceCustomization.xaml</param>
        public AretinoAppleJuiceCustomization(MenuContainer container)
        {
            InitializeComponent();
            appleJuice = new AretinoAppleJuice();
            DataContext = appleJuice;
            menuContainer = container;
        }

        /// <summary>
        /// Allows the DataContext's Size Property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if (DataContext is AretinoAppleJuice aj)
            {
                if((bool)smallSize.IsChecked)
                {
                    aj.Size = Data.Enums.Size.Small;
                }
                else if ((bool)largeSize.IsChecked)
                {
                    aj.Size = Data.Enums.Size.Large;
                }
                else if((bool) mediumSize.IsChecked)
                {
                    aj.Size = Data.Enums.Size.Medium;
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
