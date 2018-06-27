using System;
using System.Threading.Tasks;
using MvvmCross.Commands;

namespace TestDemo.Core.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        public IMvxAsyncCommand NavigateToMainPageCommand => new MvxAsyncCommand(NavigateToMainPage);

        protected async Task NavigateToMainPage()
        {
            await this.NavigationService.Navigate<DashboardViewModel>();
        }
    }
}
