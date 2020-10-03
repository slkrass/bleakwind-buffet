/*
 * Author: Stephanie Krass
 * Class name: SmokehouseSkeletonCustomization.xaml.cs
 * Purpose: Class used for interaction logic for SmokehouseSkeletonCustomization.xaml
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
    /// Interaction logic for SmokehouseSkeletonCustomization.xaml
    /// </summary>
    public partial class SmokehouseSkeletonCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private SmokehouseSkeleton skeleton;

        /// <summary>
        /// Constructor for the SmokehouseSkeletonCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the SmokehouseSkeletonCustomization.xaml</param>
        public SmokehouseSkeletonCustomization(MenuContainer container)
        {
            InitializeComponent();
            skeleton = new SmokehouseSkeleton();
            DataContext = skeleton;
            menuContainer = container;
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
