using FlaUI.Core.AutomationElements;

namespace FlaUI.Utilities
{
    public static class AutomationElemementUtil
    {
        public static AutomationElement FindChildByAutomationId(this AutomationElement parentElement, string automationID)
        {
            AutomationElement[] elements = parentElement.FindAllChildren();
            foreach (AutomationElement element in elements)
            {
                if (element.AutomationId == automationID)
                    return element;
            }
            return null;
        }

        public static AutomationElement FindChildByName(this AutomationElement parentElement, string name)
        {
            AutomationElement[] elements = parentElement.FindAllChildren();
            foreach (AutomationElement element in elements)
            {
                if (element.Name == name)
                    return element;
            }
            return null;
        }

        public static AutomationElement FindChildByClassName(this AutomationElement parentElement, string className)
        {
            AutomationElement[] elements = parentElement.FindAllChildren();
            foreach (AutomationElement element in elements)
            {
                if (element.ClassName == className)
                    return element;
            }
            return null;
        }

        public static AutomationElement FindChildByControlType(this AutomationElement parentElement, string controlType)
        {
            AutomationElement[] elements = parentElement.FindAllChildren();
            foreach (AutomationElement element in elements)
            {
                if (element.ControlType.ToString() == controlType)
                    return element;
            }
            return null;
        }

        public static AutomationElement FindChildByIndex(this AutomationElement parentElement, int index)
        {
            AutomationElement[] elements = parentElement.FindAllChildren();
            if (index > -1 && index < elements.Length)
            {
                return elements[index];
            }
            else
            {
                return null;
            }
        }
    }
}