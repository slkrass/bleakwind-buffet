/*
 * Author: Stephanie Krass
 * Class name: OrderList.xaml.cs
 * Purpose: Class used for interaction logic for OrderList.xaml
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /* Private Variable Declarations */
        private MenuContainer menuContainer;
        private Order order;

        /// <summary>
        /// Constructor for OrderList
        /// </summary>
        public OrderList(MenuContainer container)
        {
            InitializeComponent();
            menuContainer = container;
            order = container.OrderControl;
            DataContext = order;
            
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RemoveFromOrder(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is Button button)
                    order.Remove((IOrderItem)button.DataContext);
            }
        }

        /// <summary>
        /// Updates an item in the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateItem(object sender, SelectionChangedEventArgs e)
        {

            if (sender is ListView list)
            {
                //if (list.SelectedItem is IOrderItem item)
               // {
                    if (list.SelectedItem is AretinoAppleJuice aj) { menuContainer.menuBorder.Child = new AretinoAppleJuiceCustomization(menuContainer, aj); }
                    else if (list.SelectedItem is CandlehearthCoffee cc) { menuContainer.menuBorder.Child = new CandlehearthCoffeeCustomization(menuContainer, cc); }
                    else if (list.SelectedItem is MarkarthMilk mm) { menuContainer.menuBorder.Child = new MarkarthMilkCustomization(menuContainer, mm); }
                    else if (list.SelectedItem is SailorSoda ss) { menuContainer.menuBorder.Child = new SailorSodaCustomization(menuContainer, ss); }
                    else if (list.SelectedItem is WarriorWater ww) { menuContainer.menuBorder.Child = new WarriorWaterCustomization(menuContainer, ww); }
                    else if (list.SelectedItem is BriarheartBurger briar) { menuContainer.menuBorder.Child = new BriarheartBurgerCustomization(menuContainer, briar); }
                    else if (list.SelectedItem is DoubleDraugr draugr) { menuContainer.menuBorder.Child = new DoubleDraugrCustomization(menuContainer, draugr); }
                    else if (list.SelectedItem is GardenOrcOmelette goo) { menuContainer.menuBorder.Child = new GardenOrcOmeletteCustomization(menuContainer, goo); }
                    else if (list.SelectedItem  is PhillyPoacher pp) { menuContainer.menuBorder.Child = new PhillyPoacherCustomization(menuContainer, pp); }
                    else if (list.SelectedItem is SmokehouseSkeleton shs) { menuContainer.menuBorder.Child = new SmokehouseSkeletonCustomization(menuContainer, shs); }
                    else if (list.SelectedItem is ThalmorTriple thal) { menuContainer.menuBorder.Child = new ThalmorTripleCustomization(menuContainer, thal); }
                    else if (list.SelectedItem is ThugsTBone tBone) { menuContainer.menuBorder.Child = new ThugsTBoneCustomization(menuContainer, tBone); }
                    else if (list.SelectedItem is DragonbornWaffleFries dwf) { menuContainer.menuBorder.Child = new DragonbornWaffleFriesCustomization(menuContainer, dwf); }
                    else if (list.SelectedItem is FriedMiraak fm) { menuContainer.menuBorder.Child = new FriedMiraakCustomization(menuContainer, fm); }
                    else if (list.SelectedItem is MadOtarGrits mog) { menuContainer.menuBorder.Child = new MadOtarGritsCustomization(menuContainer, mog); }
                    else if (list.SelectedItem is VokunSalad vs) { menuContainer.menuBorder.Child = new VokunSaladCustomization(menuContainer, vs); }
                //}
            }
            
        }
    }
}
