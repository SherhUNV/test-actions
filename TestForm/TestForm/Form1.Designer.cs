namespace TestForm
{
    partial class TestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAddCount = new Button();
            btnReset = new Button();
            rtbOutput = new RichTextBox();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(btnAddCount, 0, 1);
            tableLayoutPanel1.Controls.Add(btnReset, 1, 1);
            tableLayoutPanel1.Controls.Add(rtbOutput, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnAddCount
            // 
            resources.ApplyResources(btnAddCount, "btnAddCount");
            btnAddCount.Name = "btnAddCount";
            btnAddCount.UseVisualStyleBackColor = true;
            btnAddCount.Click += btnAddCount_Click;
            // 
            // btnReset
            // 
            resources.ApplyResources(btnReset, "btnReset");
            btnReset.Name = "btnReset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // rtbOutput
            // 
            resources.ApplyResources(rtbOutput, "rtbOutput");
            tableLayoutPanel1.SetColumnSpan(rtbOutput, 3);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TestForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TestForm";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAddCount;
        private Button btnReset;
        private RichTextBox rtbOutput;
        private Button button1;
    }
}
