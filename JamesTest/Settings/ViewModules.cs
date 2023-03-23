using Jamesnet.Wpf.Controls;
using JamesTest.Core.Names;
using JamesTest.Forms.UI.Views;
using JamesTest.Main.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesTest.Settings
{
        public class ViewModules : IModule
        {
                public void OnInitialized(IContainerProvider containerProvider)
                {
                }

                public void RegisterTypes(IContainerRegistry containerRegistry)
                {
                        containerRegistry.RegisterSingleton<IViewable, MainContent>(ContentNameManager.Main);
                        containerRegistry.RegisterSingleton<IViewable, SecondContent>(ContentNameManager.Second);
                }
        }
}
