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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAddCount = new Button();
            btnReset = new Button();
            rtbOutput = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAddCount, 0, 1);
            tableLayoutPanel1.Controls.Add(btnReset, 1, 1);
            tableLayoutPanel1.Controls.Add(rtbOutput, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.14176F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8582382F));
            tableLayoutPanel1.Size = new Size(334, 261);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAddCount
            // 
            btnAddCount.Location = new Point(3, 220);
            btnAddCount.Name = "btnAddCount";
            btnAddCount.Size = new Size(75, 23);
            btnAddCount.TabIndex = 1;
            btnAddCount.Text = "Добавить";
            btnAddCount.UseVisualStyleBackColor = true;
            btnAddCount.Click += btnAddCount_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(170, 220);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 0;
            btnReset.Text = "Обнулить";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // rtbOutput
            // 
            tableLayoutPanel1.SetColumnSpan(rtbOutput, 2);
            rtbOutput.Dock = DockStyle.Fill;
            rtbOutput.Location = new Point(3, 3);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(328, 211);
            rtbOutput.TabIndex = 2;
            rtbOutput.Text = "";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 261);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(350, 300);
            MinimumSize = new Size(350, 300);
            Name = "TestForm";
            Text = "TestForm";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAddCount;
        private Button btnReset;
        private RichTextBox rtbOutput;
    }
}
