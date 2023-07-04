namespace Question_bank
{
    partial class StudentRegisteration
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTecher = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registeration Form";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(502, 278);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 44);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(502, 498);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(366, 44);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(1214, 485);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 44);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 40);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(984, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(935, 758);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(338, 82);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTecher
            // 
            this.lblTecher.AutoSize = true;
            this.lblTecher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecher.Location = new System.Drawing.Point(618, 787);
            this.lblTecher.Name = "lblTecher";
            this.lblTecher.Size = new System.Drawing.Size(126, 32);
            this.lblTecher.TabIndex = 17;
            this.lblTecher.TabStop = true;
            this.lblTecher.Text = "Teacher";
            this.lblTecher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(999, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 40);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(964, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 40);
            this.label8.TabIndex = 21;
            this.label8.Text = "RollNo :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(1214, 388);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(366, 35);
            this.dtPicker.TabIndex = 22;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtRollNo
            // 
            this.txtRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(1214, 282);
            this.txtRollNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(366, 44);
            this.txtRollNo.TabIndex = 23;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(502, 380);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(132, 53);
            this.rdbMale.TabIndex = 13;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(662, 380);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(167, 53);
            this.rdbFemale.TabIndex = 14;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbfemale_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 40);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sem : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(976, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 40);
            this.label10.TabIndex = 25;
            this.label10.Text = "Subject :";
            // 
            // cmbSem
            // 
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Items.AddRange(new object[] {
            "Sem -1",
            "Sem -2",
            "Sem -3",
            "Sem -4",
            "Sem -5",
            "Sem -6"});
            this.cmbSem.Location = new System.Drawing.Point(502, 600);
            this.cmbSem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(366, 28);
            this.cmbSem.TabIndex = 26;
            this.cmbSem.Text = "--SELECT YOUR SEMESTER--";
            this.cmbSem.SelectedIndexChanged += new System.EventHandler(this.cmbSem_SelectedIndexChanged);
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "C",
            "C++",
            "C#"});
            this.cmbSubject.Location = new System.Drawing.Point(1214, 600);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(366, 28);
            this.cmbSubject.TabIndex = 27;
            this.cmbSubject.Text = "--SELECT SUBJECT--";
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(524, 679);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 40);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total Marks : ";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(813, 675);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(366, 44);
            this.txtTotal.TabIndex = 29;
            // 
            // StudentRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1854, 863);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTecher);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentRegisteration";
            this.Text = "   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentRegisteration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lblTecher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

