using Jamesnet.Wpf.Controls;
using JamesTest.Forms.UI.Views;
using System.Windows;

namespace JamesTest
{
        public class App : JamesApplication
        {
                protected override Window CreateShell()
                {
                        return new JamesTestWindow();
                }
        }
}
