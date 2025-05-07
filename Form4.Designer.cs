namespace ARRAY
{
    partial class Form4
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
            pictureBox1 = new PictureBox();
            lblName = new Label();
            lblDate = new Label();
            btnActiveS = new Button();
            btnInactiveS = new Button();
            btnLogs = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblActiveS = new Label();
            panel3 = new Panel();
            lblInactiveS = new Label();
            panel4 = new Panel();
            lblGender = new Label();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(51, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(51, 160);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // btnActiveS
            // 
            btnActiveS.Location = new Point(12, 221);
            btnActiveS.Name = "btnActiveS";
            btnActiveS.Size = new Size(126, 71);
            btnActiveS.TabIndex = 3;
            btnActiveS.Text = "Active Students";
            btnActiveS.UseVisualStyleBackColor = true;
            btnActiveS.Click += btnActiveS_Click;
            // 
            // btnInactiveS
            // 
            btnInactiveS.Location = new Point(12, 337);
            btnInactiveS.Name = "btnInactiveS";
            btnInactiveS.Size = new Size(126, 71);
            btnInactiveS.TabIndex = 4;
            btnInactiveS.Text = "Inactive Students";
            btnInactiveS.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            btnLogs.Location = new Point(12, 459);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(126, 71);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 681);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 71);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(btnLogs);
            panel1.Controls.Add(btnInactiveS);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 766);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblActiveS);
            panel2.Location = new Point(209, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 130);
            panel2.TabIndex = 8;
            // 
            // lblActiveS
            // 
            lblActiveS.AutoSize = true;
            lblActiveS.Location = new Point(38, 42);
            lblActiveS.Name = "lblActiveS";
            lblActiveS.Size = new Size(103, 15);
            lblActiveS.TabIndex = 11;
            lblActiveS.Text = "ACTIVE STUDENTS";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblInactiveS);
            panel3.Location = new Point(419, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 130);
            panel3.TabIndex = 9;
            // 
            // lblInactiveS
            // 
            lblInactiveS.AutoSize = true;
            lblInactiveS.Location = new Point(3, 42);
            lblInactiveS.Name = "lblInactiveS";
            lblInactiveS.Size = new Size(115, 15);
            lblInactiveS.TabIndex = 12;
            lblInactiveS.Text = "INACTIVE STUDENTS";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblGender);
            panel4.Location = new Point(626, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(188, 130);
            panel4.TabIndex = 10;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(62, 42);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 15);
            lblGender.TabIndex = 13;
            lblGender.Text = "GENDER";
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Location = new Point(209, 265);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 130);
            panel5.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 61);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 14;
            label1.Text = "COLOR";
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Location = new Point(422, 265);
            panel6.Name = "panel6";
            panel6.Size = new Size(183, 130);
            panel6.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 61);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "HOBBIES";
            // 
            // panel7
            // 
            panel7.Controls.Add(label3);
            panel7.Location = new Point(626, 265);
            panel7.Name = "panel7";
            panel7.Size = new Size(188, 130);
            panel7.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 61);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "COURSE";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 764);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnActiveS);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblName;
        private Label lblDate;
        private Button btnActiveS;
        private Button btnInactiveS;
        private Button btnLogs;
        private Button btnLogout;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lblActiveS;
        private Label lblInactiveS;
        private Label lblGender;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}