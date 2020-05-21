using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo.UI.Controls
{
    public partial class LocationPill : ContentView
    {

        public string Distance
        {
            get => (string)GetValue(DistanceProperty);
            set => SetValue(DistanceProperty, value);
        }

        public static readonly BindableProperty DistanceProperty =
            BindableProperty.Create(
                propertyName: "Distance",
                returnType: typeof(string),
                declaringType: typeof(LocationPill),
                defaultValue: default(string),
                defaultBindingMode: BindingMode.OneTime,
                propertyChanged: OnPropertyChanged);

        private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is LocationPill control)
            {
                control.DistanceLabel.Text = newValue.ToString();
            }
        }

        public LocationPill()
        {
            InitializeComponent();
        }
    }
}
