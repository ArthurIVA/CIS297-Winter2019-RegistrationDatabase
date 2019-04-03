namespace CollegeRegistration
{
    partial class MajorForm
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
            this.majorName = new System.Windows.Forms.Label();
            this.collegeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // majorName
            // 
            this.majorName.AutoSize = true;
            this.majorName.Location = new System.Drawing.Point(84, 86);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(70, 25);
            this.majorName.TabIndex = 0;
            this.majorName.Text = "label1";
            // 
            // collegeName
            // 
            this.collegeName.AutoSize = true;
            this.collegeName.Location = new System.Drawing.Point(84, 138);
            this.collegeName.Name = "collegeName";
            this.collegeName.Size = new System.Drawing.Size(70, 25);
            this.collegeName.TabIndex = 1;
            this.collegeName.Text = "label2";
            // 
            // MajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.collegeName);
            this.Controls.Add(this.majorName);
            this.Name = "MajorForm";
            this.Text = "MajorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label majorName;
        private System.Windows.Forms.Label collegeName;
    }
}