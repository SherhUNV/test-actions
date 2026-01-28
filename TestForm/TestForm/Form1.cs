namespace TestForm
{
    public partial class TestForm : Form
    {
        private int counter = 0; 

        public TestForm()
        {
            InitializeComponent();
        }

        private void btnAddCount_Click(object sender, EventArgs e)
        {
            rtbOutput.AppendText($"Инкремент: {++counter}\n");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            rtbOutput.AppendText($"Произошла очистка\n");
            counter = 0;
        }
    }
}
