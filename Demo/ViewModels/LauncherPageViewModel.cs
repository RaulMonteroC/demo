using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Demo.Framework.Keys;
using Prism.Navigation;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class LauncherPageViewModel
    {
        public ICommand LaunchCommand { get; set; }

        private readonly INavigationService _navigationService;

        public LauncherPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            LaunchCommand = new Command(async () => await OnLaunch());
        }

        private async Task OnLaunch()
        {
            await _navigationService.NavigateAsync(PageKeys.MainPage);
        }

    }
}
