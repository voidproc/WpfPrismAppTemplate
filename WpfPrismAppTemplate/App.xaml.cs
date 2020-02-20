using WpfPrismAppTemplate.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using Prism.Regions;

namespace WpfPrismAppTemplate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ExampleView>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", "ExampleView");

        }
    }
}
