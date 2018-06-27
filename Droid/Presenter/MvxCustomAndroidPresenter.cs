using System;
using System.Collections.Generic;
using System.Reflection;
using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Presenters;
using MvvmCross.Forms.Presenters;
using TestDemo.Core.Presenter;
using Xamarin.Forms;

namespace TestDemo.Droid.Presenter
{
    public class MvxCustomAndroidPresenter : MvxFormsAndroidViewPresenter
    {
        public MvxCustomAndroidPresenter(IEnumerable<Assembly> androidViewAssemblies, Application formsApplication) : base(androidViewAssemblies, formsApplication)
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
