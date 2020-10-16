/*
 * Author: Stephanie Krass
 * Class name: ComboThugsTBoneCustomization.xaml.cs
 * Purpose: Class used for the interaction logic for ComboThugsTBoneCustomization.xaml
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
    /// Interaction logic for ComboThugsTBoneCustomization.xaml
    /// </summary>
    public partial class ComboThugsTBoneCustomization : UserControl
    {
        /* Private variable declaration */
        private MenuContainer menuContainer;
        private ThugsTBone tBone;

        /// <summary>
        /// Constructor for the ComboThugsTBoneCustomization Class
        /// </summary>
        /// <param name="container">The MenuContainer instance that contains the ComboThugsTBoneCustomization.xaml</param>
        public ComboThugsTBoneCustomization(MenuContainer container, ThugsTBone bone)
        {
            InitializeComponent();
            tBone = bone;
            DataContext = tBone;
            menuContainer = container;
        }

        /// <summary>
        /// Allows the special instructions to be recorded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSpecialInstructions(object sender, RoutedEventArgs e)
        {
            menuContainer.menuBorder.Child = new MenuSelection(menuContainer);

        }
    }
}
