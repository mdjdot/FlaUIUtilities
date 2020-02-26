using FlaUI.Core.AutomationElements;
using FlaUI.Core.Capturing;
using System.Drawing;

namespace FlaUI.Utilities
{
    public static class CaptureUtil
    {
        public static void CaptureToFile(string filePath, AutomationElement element = null, Rectangle? rectangle = null)
        {
            CaptureImage captureImage;
            if (element == null)
            {
                captureImage = Capture.Screen();
            }
            else if (rectangle == null)
            {
                captureImage = Capture.Element(element);
            }
            else
            {
                captureImage = Capture.ElementRectangle(element, (Rectangle)rectangle);
            }
            captureImage.ToFile(filePath);
        }

        public static void CaptureScreenToFile(this AutomationElement element, string filePath)
        {
            CaptureImage captureImage = Capture.Screen();
            captureImage.ToFile(filePath);
        }

        public static void CaptureElementToFile(this AutomationElement element, string filePath)
        {
            CaptureImage captureImage = Capture.Element(element);
            captureImage.ToFile(filePath);
        }

        public static void CaptureElementRectangleToFile(this AutomationElement element, Rectangle rectangle, string filePath)
        {
            CaptureImage captureImage = Capture.ElementRectangle(element, rectangle);
            captureImage.ToFile(filePath);
        }
    }
}
