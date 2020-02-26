using FlaUI.Core.WindowsAPI;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace FlaUI.Utilities.MSTest
{
    [TestClass]
    public class NotepadTest
    {
        [TestMethod]
        [Priority(1)]
        public void TestLaunchNotepad()
        {
            // 1. 打开 notepad 应用，查看notepad页面
            var app = ApplicationUtil.Launch("notepad.exe");
            var automation = new UIA3Automation();
            var mainWindow = app.GetMainWindow();
            Thread.Sleep(3 * 1000);
            mainWindow.CaptureElementToFile("./0001.jpg");

            // 2. 点击主菜单中的”文件“，查看”文件“菜单
            var menuBar = mainWindow.FindChildByAutomationId("MenuBar");
            var fileItem = menuBar.FindChildByName("文件(F)");
            fileItem.Click();
            Thread.Sleep(2 * 1000);
            mainWindow.CaptureElementToFile("./0002.jpg");
            InputUtil.PressKey(VirtualKeyShort.ESC);

            // 3. notepad 编辑区输入”测试输入内容“并查看
            var edit = mainWindow.FindChildByClassName("Edit");
            edit.Focus();
            InputUtil.TypeString("测试输入内容");
            Thread.Sleep(2 * 1000);
            mainWindow.CaptureElementToFile("./0003.jpg");

            // 4. 关闭 notepad 应用
            app.Close();




        }
    }
}
