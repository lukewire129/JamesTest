using JamesTest.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesTest
{
        public class Stater
        {
                [STAThread]
                private static void Main(string[] args)
                {
                        _ = new App()
                            .AddInversionModule<ViewModules>()
                            .AddInversionModule<DirectModules>()
                            .AddWireDataContext<WireDataContext>()
                            .Run();
                }
        }
}
