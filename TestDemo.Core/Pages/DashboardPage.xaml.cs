using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MvvmCross.Forms.Views;
using TestDemo.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;

namespace TestDemo.Core.Pages
{
    [MvxContentPagePresentation()]
    public partial class DashboardPage : MvxContentPage<DashboardViewModel>
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await this.Navigation.PushAsync(new BasicPage());
        }

        public DashboardPage()
        {
            InitializeComponent();
        }
    }
}
