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
        public OrderList()
        {
            InitializeComponent();

            
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
                order = menuContainer.OrderControl;
                DataContext = order;
            }
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
                    if (list.SelectedItem is AretinoAppleJuice aj) { menuContainer.menuBorder.Child = new AretinoAppleJuiceCustomization() { Container = menuContainer, AppleJuice = aj }; }
                    else if (list.SelectedItem is CandlehearthCoffee cc) { menuContainer.menuBorder.Child = new CandlehearthCoffeeCustomization() { Container = menuContainer, Coffee = cc }; }
                    else if (list.SelectedItem is MarkarthMilk mm) { menuContainer.menuBorder.Child = new MarkarthMilkCustomization() { Container = menuContainer, Milk = mm }; }
                    else if (list.SelectedItem is SailorSoda ss) { menuContainer.menuBorder.Child = new SailorSodaCustomization() { Container = menuContainer, Soda = ss }; }
                    else if (list.SelectedItem is WarriorWater ww) { menuContainer.menuBorder.Child = new WarriorWaterCustomization() { Container = menuContainer, Water = ww }; }
                    else if (list.SelectedItem is BriarheartBurger briar) { menuContainer.menuBorder.Child = new BriarheartBurgerCustomization() { Container = menuContainer, Burger = briar }; }
                    else if (list.SelectedItem is DoubleDraugr draugr) { menuContainer.menuBorder.Child = new DoubleDraugrCustomization() { Container = menuContainer, Burger = draugr }; }
                    else if (list.SelectedItem is GardenOrcOmelette goo) { menuContainer.menuBorder.Child = new GardenOrcOmeletteCustomization() { Container = menuContainer, Omelette = goo }; }
                    else if (list.SelectedItem is PhillyPoacher pp) { menuContainer.menuBorder.Child = new PhillyPoacherCustomization() { Container = menuContainer, Philly = pp }; }
                    else if (list.SelectedItem is SmokehouseSkeleton shs) { menuContainer.menuBorder.Child = new SmokehouseSkeletonCustomization() { Container = menuContainer, Skeleton = shs }; }
                    else if (list.SelectedItem is ThalmorTriple thal) { menuContainer.menuBorder.Child = new ThalmorTripleCustomization() { Container = menuContainer, Burger = thal }; }
                    else if (list.SelectedItem is ThugsTBone tBone) { menuContainer.menuBorder.Child = new ThugsTBoneCustomization() { Container = menuContainer, TBone = tBone }; }
                    else if (list.SelectedItem is DragonbornWaffleFries dwf) { menuContainer.menuBorder.Child = new DragonbornWaffleFriesCustomization() { Container = menuContainer, Fries = dwf }; }
                    else if (list.SelectedItem is FriedMiraak fm) { menuContainer.menuBorder.Child = new FriedMiraakCustomization() { Container = menuContainer, Miraak = fm }; }
                    else if (list.SelectedItem is MadOtarGrits mog) { menuContainer.menuBorder.Child = new MadOtarGritsCustomization() { Container = menuContainer, Grits = mog }; }
                    else if (list.SelectedItem is VokunSalad vs) { menuContainer.menuBorder.Child = new VokunSaladCustomization() { Container = menuContainer, Salad = vs }; }
            }
            
        }

    }
}
