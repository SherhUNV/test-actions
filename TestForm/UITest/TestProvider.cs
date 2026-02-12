using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest
{
    public class TestProvider
    {
        public static FlaUI.Core.AutomationElements.Window GetMainWindow(FlaUI.UIA3.UIA3Automation automation, string appExePath)
        {
            var app = FlaUI.Core.Application.Launch(appExePath);
            return app.GetMainWindow(automation);
        }
    }
}
