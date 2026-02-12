using FlaUI.Core.AutomationElements;
using UITest.Extensions;

namespace UITest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using (var automation = new FlaUI.UIA3.UIA3Automation())
            {
                var window = TestProvider.GetMainWindow(automation, @"D:\source\repos\GitHubActions\test-actions\TestForm\TestForm\bin\Debug\net8.0-windows\TestForm.exe");
                var addButton = window.FindFirstDescendant("btnAddCount")?.AsButton();
                var clearButton = window.FindFirstDescendant("btnReset")?.AsButton();
                var rtb = window.FindFirstDescendant("rtbOutput")?.AsRichTextBox();

                addButton.Click();
                Assert.That(rtb.Text == "Инкремент: 1\r\r");

                clearButton.Click();
                Assert.That(rtb.Text == "Произошла очистка\r\r");

                window.Close();
            }
        }
    }
}