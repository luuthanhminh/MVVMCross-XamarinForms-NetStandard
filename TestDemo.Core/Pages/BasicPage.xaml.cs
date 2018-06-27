using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestDemo.Core.Pages
{
    public partial class BasicPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

        public BasicPage()
        {
            InitializeComponent();
        }
    }
}
