namespace FormHospital
{
    partial class Listele
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
            lstList = new ListView();
            SuspendLayout();
            // 
            // lstList
            // 
            lstList.Location = new Point(28, 22);
            lstList.Name = "lstList";
            lstList.Size = new Size(678, 381);
            lstList.TabIndex = 0;
            lstList.UseCompatibleStateImageBehavior = false;
            // 
            // Listele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstList);
            Name = "Listele";
            Text = "Listele";
            Load += Listele_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstList;
    }
}