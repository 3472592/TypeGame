namespace TypeGame
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            statusStrip1 = new StatusStrip();
            correctLabel = new ToolStripStatusLabel();
            missedLabel = new ToolStripStatusLabel();
            totalLabel = new ToolStripStatusLabel();
            accuracyLabel = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            difficultyProgressBar = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 159;
            listBox1.Location = new Point(0, 0);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(854, 162);
            listBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { correctLabel, missedLabel, totalLabel, accuracyLabel, toolStripStatusLabel1, difficultyProgressBar });
            statusStrip1.Location = new Point(0, 136);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(854, 26);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new Size(0, 20);
            // 
            // missedLabel
            // 
            missedLabel.Name = "missedLabel";
            missedLabel.Size = new Size(0, 20);
            // 
            // totalLabel
            // 
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 20);
            // 
            // accuracyLabel
            // 
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(698, 20);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "Difficulty";
            toolStripStatusLabel1.TextAlign = ContentAlignment.TopRight;
            // 
            // difficultyProgressBar
            // 
            difficultyProgressBar.Name = "difficultyProgressBar";
            difficultyProgressBar.Size = new Size(100, 18);
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 162);
            Controls.Add(statusStrip1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel correctLabel;
        private ToolStripStatusLabel missedLabel;
        private ToolStripStatusLabel totalLabel;
        private ToolStripStatusLabel accuracyLabel;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar difficultyProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}