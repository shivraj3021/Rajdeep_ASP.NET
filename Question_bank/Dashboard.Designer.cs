namespace Question_bank
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblAddQuestion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 1375);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(290, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1554, 1216);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.lblTest);
            this.panel3.Controls.Add(this.lblAddQuestion);
            this.panel3.Location = new System.Drawing.Point(294, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1860, 1375);
            this.panel3.TabIndex = 1;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(898, 304);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(168, 40);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Create Test";
            this.lblTest.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAddQuestion
            // 
            this.lblAddQuestion.AutoSize = true;
            this.lblAddQuestion.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuestion.Location = new System.Drawing.Point(388, 304);
            this.lblAddQuestion.Name = "lblAddQuestion";
            this.lblAddQuestion.Size = new System.Drawing.Size(219, 40);
            this.lblAddQuestion.TabIndex = 0;
            this.lblAddQuestion.Text = "Add Questions";
            this.lblAddQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblAddQuestion;
    }
}