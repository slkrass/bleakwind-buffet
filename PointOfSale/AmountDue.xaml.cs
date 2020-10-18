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

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for AmountDue.xaml
    /// </summary>
    public partial class AmountDue : UserControl
    {
        /// <summary>
        /// A dependency property representing the number this control represents
        /// </summary>
        public static DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(double), typeof(AmountDue), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// The Number this control represents
        /// </summary>
        public double Number
        {
            get
            {
                return (double)GetValue(NumberProperty);
            }
            set
            {
                SetValue(NumberProperty, value);
            }
        }
        public AmountDue()
        {
            InitializeComponent();
        }
    }
}
