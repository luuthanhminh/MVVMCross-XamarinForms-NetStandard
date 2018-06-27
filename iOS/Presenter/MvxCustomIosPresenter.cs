using System;
using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Presenters;
using MvvmCross.Forms.Presenters;
using TestDemo.Core.Presenter;
using UIKit;
using Xamarin.Forms;

namespace TestDemo.iOS.Presenter
{
    public class MvxCustomIosPresenter : MvxFormsIosViewPresenter
    {
        public MvxCustomIosPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window, Xamarin.Forms.Application formsApplication) : base(applicationDelegate, window, formsApplication)
        {
        }

        private IMvxFormsPagePresenter _formsPagePresenter;
        public override IMvxFormsPagePresenter FormsPagePresenter
        {
            get
            {
                if (_formsPagePresenter == null)
                {
                    _formsPagePresenter = new MvxFormCustomPresenter(this);
                    Mvx.RegisterSingleton(_formsPagePresenter);
                }
                return _formsPagePresenter;
            }
            set
            {
                _formsPagePresenter = value;
            }
        }
    }
}
