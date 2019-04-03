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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.collegeBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // majorName
            // 
            this.majorName.AutoSize = true;
            this.majorName.Location = new System.Drawing.Point(42, 45);
            this.majorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(38, 13);
            this.majorName.TabIndex = 0;
            this.majorName.Text = "Name:";
            // 
            // collegeName
            // 
            this.collegeName.AutoSize = true;
            this.collegeName.Location = new System.Drawing.Point(42, 72);
            this.collegeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.collegeName.Name = "collegeName";
            this.collegeName.Size = new System.Drawing.Size(45, 13);
            this.collegeName.TabIndex = 1;
            this.collegeName.Text = "College:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(85, 42);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 2;
            // 
            // collegeBox
            // 
            this.collegeBox.Location = new System.Drawing.Point(92, 68);
            this.collegeBox.Name = "collegeBox";
            this.collegeBox.Size = new System.Drawing.Size(100, 20);
            this.collegeBox.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(45, 136);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "label1";
            // 
            // MajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.collegeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.collegeName);
            this.Controls.Add(this.majorName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MajorForm";
            this.Text = "MajorForm";
            this.Load += new System.EventHandler(this.MajorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label majorName;
        private System.Windows.Forms.Label collegeName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox collegeBox;
        private System.Windows.Forms.Label errorLabel;
    }
}