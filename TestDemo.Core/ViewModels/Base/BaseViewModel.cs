using System;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Presenters.Hints;
using System.Threading.Tasks;
using System.Collections.Generic;
using TestDemo.Core.Presenter;
using MvvmCross.Commands;

namespace TestDemo.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        protected void PopToPage<TViewModel>() where TViewModel : MvxViewModel
        {
            var hint = new MvxPopPresentationHint(typeof(TViewModel));
            this.NavigationService.ChangePresentation(hint);
        }

        protected async Task ClearStackAndNavigateToPage<TViewModel>() where TViewModel : MvxViewModel
        {
            var presentation = new MvxBundle(new Dictionary<string, string> { { PresentationConstantValue.CLEAR_STACK_AND_SHOW_PAGE, "" } });

            await this.NavigationService.Navigate<TViewModel>(presentationBundle: presentation);
        }

        public IMvxAsyncCommand CloseCommand => new MvxAsyncCommand(ClosePage);

        protected async Task ClosePage()
        {
            await this.NavigationService.Close(this);
        }
    }
}
