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
            buttonTest = new Button();
            listView1 = new ListView();
            buttonList = new Button();
            buttonAddDoctor = new Button();
            SuspendLayout();
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(649, 30);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(94, 29);
            buttonTest.TabIndex = 0;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(25, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(568, 383);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonList
            // 
            buttonList.Location = new Point(649, 128);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(94, 29);
            buttonList.TabIndex = 2;
            buttonList.Text = "List";
            buttonList.UseVisualStyleBackColor = true;
            buttonList.Click += buttonListele_Click;
            // 
            // buttonAddDoctor
            // 
            buttonAddDoctor.Location = new Point(649, 194);
            buttonAddDoctor.Name = "buttonAddDoctor";
            buttonAddDoctor.Size = new Size(94, 71);
            buttonAddDoctor.TabIndex = 3;
            buttonAddDoctor.Text = "AddDoctor Page";
            buttonAddDoctor.UseVisualStyleBackColor = true;
            buttonAddDoctor.Click += buttonDoktorEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddDoctor);
            Controls.Add(buttonList);
            Controls.Add(listView1);
            Controls.Add(buttonTest);
            Name = "Form1";
            Text = "Hospital";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTest;
        private ListView listView1;
        private Button buttonList;
        private Button buttonAddDoctor;
    }
}