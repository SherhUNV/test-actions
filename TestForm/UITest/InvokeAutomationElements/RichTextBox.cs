using FlaUI.Core;
using FlaUI.Core.AutomationElements.PatternElements;
using FlaUI.Core.Exceptions;
using FlaUI.Core.Input;
using FlaUI.Core.Patterns;
using FlaUI.Core.WindowsAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest.InvokableLements
{
    public class RichTextBox : InvokeAutomationElement
    {
        public RichTextBox(FrameworkAutomationElementBase frameworkAutomationElement) : base(frameworkAutomationElement)
        {
        }

        public string Text
        {
            get
            {
                if (base.Properties.IsPassword.TryGetValue(out var value) && value)
                {
                    throw new MethodNotSupportedException("Text from element '" + ToString() + "' cannot be retrieved because it is set as password.");
                }

                if (base.Patterns.Value.TryGetPattern(out IValuePattern pattern) && pattern.Value.TryGetValue(out string value2))
                {
                    return value2;
                }

                if (base.Patterns.Text.TryGetPattern(out ITextPattern pattern2))
                {
                    return pattern2.DocumentRange.GetText(int.MaxValue);
                }

                if (Win32Fallback.GetTextWin32(this, out string textOut))
                {
                    return textOut;
                }

                throw new MethodNotSupportedException("AutomationElement '" + ToString() + "' supports neither ValuePattern or TextPattern");
            }
            set
            {
                if (base.Patterns.Value.TryGetPattern(out IValuePattern pattern))
                {
                    pattern.SetValue(value);
                }
                else if (!Win32Fallback.SetTextWin32(this, value))
                {
                    Enter(value);
                }
            }
        }

        public void Enter(string value)
        {
            Focus();
            base.Patterns.Value.PatternOrDefault?.SetValue(string.Empty);
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            string[] array = value.Replace("\r\n", "\n").Split(new char[1] { '\n' });
            Keyboard.Type(array[0]);
            foreach (string item in array.Skip(1))
            {
                Keyboard.Type(VirtualKeyShort.RETURN);
                Keyboard.Type(item);
            }

            Wait.UntilInputIsProcessed();
        }
    }
}
