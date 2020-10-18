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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomerQuantity.xaml
    /// </summary>
    public partial class CustomerQuantity : UserControl
    {

        /// <summary>
        /// Identifies the CustomerQuantity.Step XAML attached property
        /// </summary>
        public static DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(int), typeof(CustomerQuantity), new PropertyMetadata(1));

        /// <summary>
        /// The amount each increment or decrement operation should change the value by
        /// </summary>
        public int Step
        {
            get { return (int)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        /// <summary>
        /// Identifies the CustomerQuantity.MaxValue property
        /// </summary>
        public static DependencyProperty MaxValueProperty = DependencyProperty.Register("MaxValue", typeof(int), typeof(CustomerQuantity), new PropertyMetadata(int.MaxValue));

        /// <summary>
        /// The maximum value this CustomerQuantity will allow
        /// </summary>
        public int MaxValue
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        /// <summary>
        /// Identifies theCustomerQuantity.MaxValue property
        /// </summary>
        public static DependencyProperty MinValueProperty = DependencyProperty.Register("MinValue", typeof(int), typeof(CustomerQuantity), new PropertyMetadata(int.MinValue));

        /// <summary>
        /// The maximum value this NumberBox will allow
        /// </summary>
        public int MinValue
        {
            get { return (int)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        /// <summary>
        /// Identifies the CustomerQuantity.Value XAML attached property
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(CustomerQuantity), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandleValueChanged));

        /// <summary>
        /// The CustomerQuantity's displayed value
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        /// <summary>
        /// Identifies theCustomerQuantity.ValueClamped event
        /// </summary>
        public static readonly RoutedEvent ValueClampedEvent = EventManager.RegisterRoutedEvent("ValueClamped", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomerQuantity));

        /// <summary>
        /// Event that is triggered when the value of this CustomerQuantity is clamped to the 
        /// range between MinValue and MaxValue
        /// </summary>
        public event RoutedEventHandler ValueClamped
        {
            add { AddHandler(ValueClampedEvent, value); }
            remove { RemoveHandler(ValueClampedEvent, value); }
        }



        /// <summary>
        /// Constructs a new CustomerQuantity
        /// </summary>
        public CustomerQuantity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructs a new CustomerQuantity
        /// </summary>
        /// <param name="value">The initial value of the CustomerQuantity</param>
        public CustomerQuantity(int value)
        {
            InitializeComponent();
            Value = value;
        }

        /// <summary>
        /// Constructs a new CustomerQuantity
        /// </summary>
        /// <param name="value">The initial value of the CustomerQuantity</param>
        /// <param name="min">The minimum allowable value</param>
        /// <param name="max">The maximum allowable value</param>
        public CustomerQuantity(int value, int min, int max)
        {
            InitializeComponent();
            Value = value;
            MinValue = min;
            MaxValue = max;
        }


        /// <summary>
        /// Handles the click of the increment or decrement button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        Value += Step;
                        break;
                    case "Decrement":
                        Value -= Step;
                        break;
                }
            }
            e.Handled = true;
        }

        /// <summary>
        /// Callback for the ValueProperty, which clamps the Value to the range 
        /// defined by MinValue and MaxValue
        /// </summary>
        /// <param name="sender">The CustomerQuantity whose value is changing</param>
        /// <param name="e">The event args</param>
        static void HandleValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name == "Value" && sender is CustomerQuantity box)
            {
                if (box.Value < box.MinValue)
                {
                    box.Value = box.MinValue;
                    box.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
                if (box.Value > box.MaxValue)
                {
                    box.Value = box.MaxValue;
                    box.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
            }
        }
    }
}
