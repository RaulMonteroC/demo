using System;
using Demo.Framework.Keys;
using Demo.ViewModels;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();
        }
        
        protected override void OnInitialized()
        {
            Device.SetFlags(new string[] { "IndicatorView_Experimental", "CarouselView_Experimental" });

            NavigationService.NavigateAsync(PageKeys.LauncherPage);
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LaucherPage,LauncherPageViewModel>();
        }
    }
}
