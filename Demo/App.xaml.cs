using System;
using Demo.Framework.Keys;
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
            NavigationService.NavigateAsync(PageKeys.MainPage);
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
