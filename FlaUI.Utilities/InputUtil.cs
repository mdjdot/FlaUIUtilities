using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System;
using System.Drawing;

namespace FlaUI.Utilities
{
    public class InputUtil
    {
        public static IDisposable PressingKey(VirtualKeyShort[] virtualKeys)
        {
            return Keyboard.Pressing(virtualKeys);
        }

        public static void PressKey(VirtualKeyShort virtualKey)
        {
            Keyboard.Press(virtualKey);
        }

        public static void TypeString(string content)
        {
            Keyboard.Type(content);
        }

        public static void Click(Point? point = null)
        {
            if (point == null)
            {
                Mouse.Click(MouseButton.Left);
            }
            else
            {
                Mouse.Click((Point)point, MouseButton.Left);
            }
        }

        public static void DoubleClick(Point? point = null)
        {
            if (point == null)
            {
                Mouse.DoubleClick(MouseButton.Left);
            }
            else
            {
                Mouse.DoubleClick((Point)point, MouseButton.Left);
            }
        }

        public static void RightClick(Point? point = null)
        {
            if (point == null)
            {
                Mouse.Click(MouseButton.Right);
            }
            else
            {
                Mouse.Click((Point)point, MouseButton.Right);
            }
        }

        public static void RightDoubleClick(Point? point = null)
        {
            if (point == null)
            {
                Mouse.DoubleClick(MouseButton.Right);
            }
            else
            {
                Mouse.DoubleClick((Point)point, MouseButton.Right);
            }
        }

        public static void MoveTo(int x, int y)
        {
            Mouse.MoveTo(x, y);
        }
    }
}
