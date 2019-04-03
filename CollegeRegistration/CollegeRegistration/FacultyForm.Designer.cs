namespace CollegeRegistration
{
    partial class FacultyForm
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
            this.facultyName = new System.Windows.Forms.Label();
            this.facultyPhoneNumber = new System.Windows.Forms.Label();
            this.facultySection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // facultyName
            // 
            this.facultyName.AutoSize = true;
            this.facultyName.Location = new System.Drawing.Point(82, 83);
            this.facultyName.Name = "facultyName";
            this.facultyName.Size = new System.Drawing.Size(70, 25);
            this.facultyName.TabIndex = 0;
            this.facultyName.Text = "label1";
            // 
            // facultyPhoneNumber
            // 
            this.facultyPhoneNumber.AutoSize = true;
            this.facultyPhoneNumber.Location = new System.Drawing.Point(82, 132);
            this.facultyPhoneNumber.Name = "facultyPhoneNumber";
            this.facultyPhoneNumber.Size = new System.Drawing.Size(70, 25);
            this.facultyPhoneNumber.TabIndex = 1;
            this.facultyPhoneNumber.Text = "label2";
            // 
            // facultySection
            // 
            this.facultySection.AutoSize = true;
            this.facultySection.Location = new System.Drawing.Point(82, 186);
            this.facultySection.Name = "facultySection";
            this.facultySection.Size = new System.Drawing.Size(70, 25);
            this.facultySection.TabIndex = 2;
            this.facultySection.Text = "label3";
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.facultySection);
            this.Controls.Add(this.facultyPhoneNumber);
            this.Controls.Add(this.facultyName);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facultyName;
        private System.Windows.Forms.Label facultyPhoneNumber;
        private System.Windows.Forms.Label facultySection;
    }
}