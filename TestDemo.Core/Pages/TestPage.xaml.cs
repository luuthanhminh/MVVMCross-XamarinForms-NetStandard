using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MvvmCross.Forms.Views;
using TestDemo.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;

namespace TestDemo.Core.Pages
{
    [MvxContentPagePresentation()]
    public partial class TestPage : MvxContentPage<TestViewModel>
    {
        public TestPage()
        {
            InitializeComponent();
        }
    }
}
