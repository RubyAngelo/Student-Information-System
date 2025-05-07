namespace ARRAY
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
            lblName = new Label();
            lblGender = new Label();
            lblHobbies = new Label();
            lblFavColor = new Label();
            lblSayings = new Label();
            txtName = new TextBox();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            chkBasketball = new CheckBox();
            chkVolleyball = new CheckBox();
            chkBadminton = new CheckBox();
            cmbColor = new ComboBox();
            txtSaying = new TextBox();
            btnSubmit = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtAge = new TextBox();
            dtpBirthday = new DateTimePicker();
            lblId = new Label();
            btnDisplay = new Button();
            lblMessage = new Label();
            txtBrowse = new TextBox();
            btnBrowse = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(47, 81);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 1;
            lblGender.Text = "Gender:";
            // 
            // lblHobbies
            // 
            lblHobbies.AutoSize = true;
            lblHobbies.Location = new Point(47, 133);
            lblHobbies.Name = "lblHobbies";
            lblHobbies.Size = new Size(54, 15);
            lblHobbies.TabIndex = 2;
            lblHobbies.Text = "Hobbies:";
            // 
            // lblFavColor
            // 
            lblFavColor.AutoSize = true;
            lblFavColor.Location = new Point(51, 411);
            lblFavColor.Name = "lblFavColor";
            lblFavColor.Size = new Size(84, 15);
            lblFavColor.TabIndex = 3;
            lblFavColor.Text = "Favorite Color:";
            // 
            // lblSayings
            // 
            lblSayings.AutoSize = true;
            lblSayings.Location = new Point(53, 471);
            lblSayings.Name = "lblSayings";
            lblSayings.Size = new Size(50, 15);
            lblSayings.TabIndex = 4;
            lblSayings.Text = "Sayings:";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 32);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 25);
            txtName.TabIndex = 5;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(114, 81);
            radMale.Name = "radMale";
            radMale.Size = new Size(51, 19);
            radMale.TabIndex = 6;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(183, 81);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(63, 19);
            radFemale.TabIndex = 7;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // chkBasketball
            // 
            chkBasketball.AutoSize = true;
            chkBasketball.Location = new Point(114, 133);
            chkBasketball.Name = "chkBasketball";
            chkBasketball.Size = new Size(79, 19);
            chkBasketball.TabIndex = 8;
            chkBasketball.Text = "Basketball";
            chkBasketball.UseVisualStyleBackColor = true;
            // 
            // chkVolleyball
            // 
            chkVolleyball.AutoSize = true;
            chkVolleyball.Location = new Point(199, 133);
            chkVolleyball.Name = "chkVolleyball";
            chkVolleyball.Size = new Size(76, 19);
            chkVolleyball.TabIndex = 9;
            chkVolleyball.Text = "Volleyball";
            chkVolleyball.UseVisualStyleBackColor = true;
            // 
            // chkBadminton
            // 
            chkBadminton.AutoSize = true;
            chkBadminton.Location = new Point(281, 133);
            chkBadminton.Name = "chkBadminton";
            chkBadminton.Size = new Size(85, 19);
            chkBadminton.TabIndex = 10;
            chkBadminton.Text = "Badminton";
            chkBadminton.UseVisualStyleBackColor = true;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black", "blue", "red", "orange\t", "gray", "blue", "violet", "brown", "green" });
            cmbColor.Location = new Point(138, 403);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(200, 23);
            cmbColor.TabIndex = 11;
            // 
            // txtSaying
            // 
            txtSaying.Location = new Point(144, 463);
            txtSaying.Name = "txtSaying";
            txtSaying.Size = new Size(194, 23);
            txtSaying.TabIndex = 12;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(54, 583);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(129, 64);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "ADD";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(53, 583);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 64);
            btnAdd.TabIndex = 14;
            btnAdd.Text = " UPDATE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 246);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 15;
            label1.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 293);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 16;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 351);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 17;
            label3.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 193);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 18;
            label4.Text = "Age:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(138, 236);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(194, 25);
            txtAddress.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 293);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 25);
            txtEmail.TabIndex = 22;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(138, 183);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(194, 25);
            txtAge.TabIndex = 23;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(138, 351);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 26;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(75, 42);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 27;
            lblId.Text = "Id";
            lblId.Visible = false;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(203, 583);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(129, 64);
            btnDisplay.TabIndex = 28;
            btnDisplay.Text = "DISPLAY";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(418, 32);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(18, 15);
            lblMessage.TabIndex = 29;
            lblMessage.Text = "M";
            // 
            // txtBrowse
            // 
            txtBrowse.Location = new Point(144, 504);
            txtBrowse.Name = "txtBrowse";
            txtBrowse.Size = new Size(194, 23);
            txtBrowse.TabIndex = 30;
            txtBrowse.TextChanged += textBox1_TextChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(54, 504);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(73, 23);
            btnBrowse.TabIndex = 31;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 676);
            Controls.Add(btnBrowse);
            Controls.Add(txtBrowse);
            Controls.Add(lblMessage);
            Controls.Add(btnDisplay);
            Controls.Add(lblId);
            Controls.Add(dtpBirthday);
            Controls.Add(txtAge);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnSubmit);
            Controls.Add(txtSaying);
            Controls.Add(cmbColor);
            Controls.Add(chkBadminton);
            Controls.Add(chkVolleyball);
            Controls.Add(chkBasketball);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(txtName);
            Controls.Add(lblSayings);
            Controls.Add(lblFavColor);
            Controls.Add(lblHobbies);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblGender;
        private Label lblHobbies;
        private Label lblFavColor;
        private Label lblSayings;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox txtName;
        public RadioButton radMale;
        public RadioButton radFemale;
        public CheckBox chkBasketball;
        public CheckBox chkVolleyball;
        public CheckBox chkBadminton;
        public ComboBox cmbColor;
        public TextBox txtSaying;
        public TextBox txtAddress;
        public TextBox txtEmail;
        public TextBox txtAge;
        public DateTimePicker dtpBirthday;
        public Label lblId;
        private Button btnDisplay;
        public Button btnSubmit;
        public Button btnAdd;
        private Label lblMessage;
        private TextBox txtBrowse;
        private Button btnBrowse;
    }
}
