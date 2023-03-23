using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using JamesTest.Core.Names;
using Prism.Ioc;
using Prism.Regions;

namespace JamesTest.Forms.Local.ViewModels
{
        public partial class MainViewModel : ObservableBase, IViewLoadable
        {

                private readonly IRegionManager _regionManager;
                private readonly IContainerProvider _containerProvider;
                public MainViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
                {
                        _regionManager = regionManager;
                        _containerProvider = containerProvider;
                }

                public void OnLoaded(IViewable smartWindow)
                {
                        IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
                        IViewable loginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Main);

                        if (!mainRegion.Views.Contains(loginContent))
                        {
                                mainRegion.Add(loginContent);
                        }
                        mainRegion.Activate(loginContent);
                }

                [RelayCommand]
                private void Main()
                {
                        IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
                        IViewable loginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Main);

                        if (!mainRegion.Views.Contains(loginContent))
                        {
                                mainRegion.Add(loginContent);
                        }
                        mainRegion.Activate(loginContent);
                }

                [RelayCommand]
                private void Second()
                {
                        IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
                        IViewable loginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Second);

                        if (!mainRegion.Views.Contains(loginContent))
                        {
                                mainRegion.Add(loginContent);
                        }
                        mainRegion.Activate(loginContent);
                }
        }
}
