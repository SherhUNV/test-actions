using System.Globalization;

namespace TestForm
{
    public partial class TestForm : Form
    {
        private string addButtonOutput = "empty";
        private string resetOuput = "empty";
        private int counter = 0;

        public TestForm()
        {
            InitializeComponent();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            addButtonOutput = resources.GetString("AddBtnOutputText");
            resetOuput = resources.GetString("ResetBtnOutputText");
        }

        private void btnAddCount_Click(object sender, EventArgs e)
        {
            rtbOutput.AppendText($"{addButtonOutput}: {++counter}\n");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            rtbOutput.AppendText($"{resetOuput}\n");
            counter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentUICulture.Name == "en" ? new CultureInfo("ru") : new CultureInfo("en");

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            addButtonOutput = resources.GetString("AddBtnOutputText");
            resetOuput = resources.GetString("ResetBtnOutputText");
        }
    }
}
