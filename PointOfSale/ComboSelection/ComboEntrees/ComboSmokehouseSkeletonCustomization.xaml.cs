/*
 * Author: Stephanie Krass
 * Class name: ComboSmokehouseSkeletonCustomization.xaml.cs
 * Purpose: Class used for interaction logic for ComboSmokehouseSkeletonCustomization.xaml
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
    /// Interaction logic for ComboSmokehouseSkeletonCustomization.xaml
    /// </summary>
    public partial class ComboSmokehouseSkeletonCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private SmokehouseSkeleton skeleton;

        /// <summary>
        /// Constructor for the ComboSmokehouseSkeletonCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboSmokehouseSkeletonCustomization.xaml</param>
        public ComboSmokehouseSkeletonCustomization(MenuContainer container, SmokehouseSkeleton shs)
        {
            InitializeComponent();
            skeleton = shs;
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
