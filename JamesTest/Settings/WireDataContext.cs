using Jamesnet.Wpf.Global.Location;
using JamesTest.Forms.Local.ViewModels;
using JamesTest.Forms.UI.Views;
using JamesTest.Main.Local.ViewModels;
using JamesTest.Main.UI.Views;

namespace JamesTest.Settings
{
        public class WireDataContext : ViewModelLocationScenario
        {
                protected override void Match(ViewModelLocatorCollection items)
                {
                        items.Register<JamesTestWindow, MainViewModel>();
                        items.Register<MainContent, MainContentViewModel>();
                        items.Register<SecondContent, SecondContentViewModel>();
                }
        }
}
