using Jamesnet.Wpf.Controls;
using System.Windows;

namespace JamesTest.Forms.UI.Views
{
        public class JamesTestWindow : JamesWindow
        {
                static JamesTestWindow()
                {
                        DefaultStyleKeyProperty.OverrideMetadata(typeof(JamesTestWindow), new FrameworkPropertyMetadata(typeof(JamesTestWindow)));
                }
        }
}
