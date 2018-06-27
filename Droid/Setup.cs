using System;
using Android.Content;
using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Presenters;
using MvvmCross.Logging;
using MvvmCross.Platforms.Android.Presenters;
using TestDemo.Core;
using TestDemo.Droid.Presenter;

namespace TestDemo.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp, App>
    {
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = new MvxCustomAndroidPresenter(this.GetViewAssemblies(), this.FormsApplication);
            Mvx.RegisterSingleton<IMvxFormsViewPresenter>(presenter);
            return presenter;
        }
    }
}
