using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System.Diagnostics;

namespace FlaUI.Utilities
{
    static public class ApplicationUtil
    {

        public static Application Launch(string fileName, string arguments = null)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(fileName, arguments);
            return Application.AttachOrLaunch(processStartInfo);
        }

        public static Window GetMainWindow(this Application app)
        {
            UIA3Automation automation = new UIA3Automation();
            Window window = app.GetMainWindow(automation);
            window.SetForeground();
            return window;
        }
    }
}
