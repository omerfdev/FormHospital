namespace FormHospital.Concreate
{
    partial class AddDoctor
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
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxTurkishID = new TextBox();
            textBoxAge = new TextBox();
            textBoxDailyPatientCount = new TextBox();
            textBoxMonthlyVigilCount = new TextBox();
            textBoxExpertiseField = new TextBox();
            textBoxPaycheck = new TextBox();
            textBoxTitle = new TextBox();
            textBoxExtraMoneyBank = new TextBox();
            comboBoxGender = new ComboBox();
            groupBoxDoctorFields = new GroupBox();
            radioButtonPsikiyatri = new RadioButton();
            radioButtonOrtopedi = new RadioButton();
            buttonAddDoctor = new Button();
            groupBoxDoctorFields.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(65, 28);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(190, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(65, 61);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.PlaceholderText = "Surname";
            textBoxSurname.Size = new Size(190, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxTurkishID
            // 
            textBoxTurkishID.Location = new Point(65, 94);
            textBoxTurkishID.MaxLength = 11;
            textBoxTurkishID.Name = "textBoxTurkishID";
            textBoxTurkishID.PlaceholderText = "Turkish ID";
            textBoxTurkishID.Size = new Size(190, 27);
            textBoxTurkishID.TabIndex = 2;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(65, 127);
            textBoxAge.MaxLength = 3;
            textBoxAge.Name = "textBoxAge";
            textBoxAge.PlaceholderText = "Age";
            textBoxAge.Size = new Size(190, 27);
            textBoxAge.TabIndex = 3;
            // 
            // textBoxDailyPatientCount
            // 
            textBoxDailyPatientCount.Location = new Point(65, 160);
            textBoxDailyPatientCount.MaxLength = 3;
            textBoxDailyPatientCount.Name = "textBoxDailyPatientCount";
            textBoxDailyPatientCount.PlaceholderText = "Daily Patient Count";
            textBoxDailyPatientCount.Size = new Size(190, 27);
            textBoxDailyPatientCount.TabIndex = 4;
            // 
            // textBoxMonthlyVigilCount
            // 
            textBoxMonthlyVigilCount.Location = new Point(65, 193);
            textBoxMonthlyVigilCount.MaxLength = 3;
            textBoxMonthlyVigilCount.Name = "textBoxMonthlyVigilCount";
            textBoxMonthlyVigilCount.PlaceholderText = "Monthly Vigil Count";
            textBoxMonthlyVigilCount.Size = new Size(190, 27);
            textBoxMonthlyVigilCount.TabIndex = 5;
            // 
            // textBoxExpertiseField
            // 
            textBoxExpertiseField.Location = new Point(65, 226);
            textBoxExpertiseField.MaxLength = 4;
            textBoxExpertiseField.Name = "textBoxExpertiseField";
            textBoxExpertiseField.PlaceholderText = "Expertise Field";
            textBoxExpertiseField.Size = new Size(190, 27);
            textBoxExpertiseField.TabIndex = 6;
            // 
            // textBoxPaycheck
            // 
            textBoxPaycheck.Location = new Point(65, 259);
            textBoxPaycheck.MaxLength = 10;
            textBoxPaycheck.Name = "textBoxPaycheck";
            textBoxPaycheck.PlaceholderText = "Paycheck";
            textBoxPaycheck.Size = new Size(190, 27);
            textBoxPaycheck.TabIndex = 7;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(65, 292);
            textBoxTitle.MaxLength = 20;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Title";
            textBoxTitle.Size = new Size(190, 27);
            textBoxTitle.TabIndex = 8;
            // 
            // textBoxExtraMoneyBank
            // 
            textBoxExtraMoneyBank.Location = new Point(65, 325);
            textBoxExtraMoneyBank.MaxLength = 10;
            textBoxExtraMoneyBank.Name = "textBoxExtraMoneyBank";
            textBoxExtraMoneyBank.PlaceholderText = "Extra Money Bank";
            textBoxExtraMoneyBank.Size = new Size(190, 27);
            textBoxExtraMoneyBank.TabIndex = 9;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(65, 358);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(190, 28);
            comboBoxGender.TabIndex = 10;
            // 
            // groupBoxDoctorFields
            // 
            groupBoxDoctorFields.Controls.Add(radioButtonPsikiyatri);
            groupBoxDoctorFields.Controls.Add(radioButtonOrtopedi);
            groupBoxDoctorFields.Location = new Point(418, 39);
            groupBoxDoctorFields.Name = "groupBoxDoctorFields";
            groupBoxDoctorFields.Size = new Size(332, 181);
            groupBoxDoctorFields.TabIndex = 11;
            groupBoxDoctorFields.TabStop = false;
            groupBoxDoctorFields.Text = "groupBox1";
            // 
            // radioButtonPsikiyatri
            // 
            radioButtonPsikiyatri.AutoSize = true;
            radioButtonPsikiyatri.Location = new Point(88, 98);
            radioButtonPsikiyatri.Name = "radioButtonPsikiyatri";
            radioButtonPsikiyatri.Size = new Size(95, 24);
            radioButtonPsikiyatri.TabIndex = 1;
            radioButtonPsikiyatri.TabStop = true;
            radioButtonPsikiyatri.Text = "Psychiatry";
            radioButtonPsikiyatri.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrtopedi
            // 
            radioButtonOrtopedi.AutoSize = true;
            radioButtonOrtopedi.Location = new Point(90, 57);
            radioButtonOrtopedi.Name = "radioButtonOrtopedi";
            radioButtonOrtopedi.Size = new Size(111, 24);
            radioButtonOrtopedi.TabIndex = 0;
            radioButtonOrtopedi.TabStop = true;
            radioButtonOrtopedi.Text = "Orthopedics";
            radioButtonOrtopedi.UseVisualStyleBackColor = true;
            // 
            // buttonAddDoctor
            // 
            buttonAddDoctor.Location = new Point(533, 247);
            buttonAddDoctor.Name = "buttonAddDoctor";
            buttonAddDoctor.Size = new Size(94, 29);
            buttonAddDoctor.TabIndex = 12;
            buttonAddDoctor.Text = "AddDoctor";
            buttonAddDoctor.UseVisualStyleBackColor = true;
            buttonAddDoctor.Click += buttonDoktorEkle_Click;
            // 
            // AddDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddDoctor);
            Controls.Add(groupBoxDoctorFields);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxExtraMoneyBank);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxPaycheck);
            Controls.Add(textBoxExpertiseField);
            Controls.Add(textBoxMonthlyVigilCount);
            Controls.Add(textBoxDailyPatientCount);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxTurkishID);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Name = "AddDoctor";
            Text = "AddDoctor";
            Load += DoktorEkle_Load;
            groupBoxDoctorFields.ResumeLayout(false);
            groupBoxDoctorFields.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxTurkishID;
        private TextBox textBoxAge;
        private TextBox textBoxDailyPatientCount;
        private TextBox textBoxMonthlyVigilCount;
        private TextBox textBoxExpertiseField;
        private TextBox textBoxPaycheck;
        private TextBox textBoxTitle;
        private TextBox textBoxExtraMoneyBank;
        private ComboBox comboBoxGender;
        private GroupBox groupBoxDoctorFields;
        private RadioButton radioButtonPsikiyatri;
        private RadioButton radioButtonOrtopedi;
        private Button buttonAddDoctor;
    }
}