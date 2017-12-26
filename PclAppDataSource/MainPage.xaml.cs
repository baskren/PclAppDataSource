using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PclAppDataSource
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            var label = new Label
            {
                Text = "This is a label"
            };
            CustomFontEffect.ApplyTo(label);

            Content = label;
        }
    }
}
