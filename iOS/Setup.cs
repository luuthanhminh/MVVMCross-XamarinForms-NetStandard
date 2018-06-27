using System;
using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.Forms.Presenters;
using MvvmCross.Platforms.Ios.Presenters;
using TestDemo.Core;
using TestDemo.iOS.Presenter;

namespace TestDemo.iOS
{
    public class Setup : MvxFormsIosSetup<CoreApp, App>
    {
        protected override IMvxIosViewPresenter CreateViewPresenter()
        {
            var presenter = new MvxCustomIosPresenter(this.ApplicationDelegate, this.Window, this.FormsApplication);
            Mvx.RegisterSingleton<IMvxFormsViewPresenter>(presenter);
            return presenter;
        }

    }
}
