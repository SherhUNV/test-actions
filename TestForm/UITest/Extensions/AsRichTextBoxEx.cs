using FlaUI.Core.AutomationElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITest.InvokableLements;

namespace UITest.Extensions
{
    public static class AsRichTextBoxEx
    {
        public static RichTextBox? AsRichTextBox(this AutomationElement elem)
        {
            if (elem != null)
                return new RichTextBox(elem.FrameworkAutomationElement);
            return null;
        }
    }
}
