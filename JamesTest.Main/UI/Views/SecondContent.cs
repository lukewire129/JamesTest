using Jamesnet.Wpf.Controls;
using System.Windows;

namespace JamesTest.Main.UI.Views
{
        public class SecondContent : JamesContent
        {
                static SecondContent()
                {
                        DefaultStyleKeyProperty.OverrideMetadata(typeof(SecondContent), new FrameworkPropertyMetadata(typeof(SecondContent)));
                }
        }
}
