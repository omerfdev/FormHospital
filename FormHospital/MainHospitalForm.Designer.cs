namespace FormHospital
{
    partial class MainHospitalForm
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
            btnTest = new Button();
            lstHospitalDoctor = new ListView();
            btnList = new Button();
            btnAddDoctor = new Button();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(932, 27);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += buttonTest_Click;
            // 
            // lstHospitalDoctor
            // 
            lstHospitalDoctor.Location = new Point(25, 30);
            lstHospitalDoctor.Name = "lstHospitalDoctor";
            lstHospitalDoctor.Size = new Size(855, 383);
            lstHospitalDoctor.TabIndex = 1;
            lstHospitalDoctor.UseCompatibleStateImageBehavior = false;
            // 
            // btnList
            // 
            btnList.Location = new Point(932, 125);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 2;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += buttonListele_Click;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Location = new Point(932, 191);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(94, 71);
            btnAddDoctor.TabIndex = 3;
            btnAddDoctor.Text = "AddDoctor Page";
            btnAddDoctor.UseVisualStyleBackColor = true;
            btnAddDoctor.Click += buttonDoktorEkle_Click;
            // 
            // MainHospitalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 450);
            Controls.Add(btnAddDoctor);
            Controls.Add(btnList);
            Controls.Add(lstHospitalDoctor);
            Controls.Add(btnTest);
            MaximumSize = new Size(1167, 497);
            MinimumSize = new Size(1167, 497);
            Name = "MainHospitalForm";
            Text = "Hospital";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private ListView lstHospitalDoctor;
        private Button btnList;
        private Button btnAddDoctor;
    }
}