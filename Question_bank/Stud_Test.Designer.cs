namespace Question_bank
{
    partial class Stud_Test
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Green;
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(523, 26);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(105, 26);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Start your Test";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Stud_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(909, 476);
            this.Controls.Add(this.btnDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Stud_Test";
            this.Text = "Stud_Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stud_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
    }
}