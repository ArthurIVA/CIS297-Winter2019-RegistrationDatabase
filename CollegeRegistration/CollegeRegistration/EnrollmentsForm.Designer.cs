namespace CollegeRegistration
{
    partial class EnrollmentsForm
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
            this.crudList = new System.Windows.Forms.ComboBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.studentBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crudList
            // 
            this.crudList.FormattingEnabled = true;
            this.crudList.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.crudList.Location = new System.Drawing.Point(46, 34);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(223, 21);
            this.crudList.TabIndex = 11;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(46, 102);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(60, 13);
            this.sectionLabel.TabIndex = 12;
            this.sectionLabel.Text = "Section ID:";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(46, 128);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(61, 13);
            this.studentLabel.TabIndex = 13;
            this.studentLabel.Text = "Student ID:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(46, 154);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeLabel.TabIndex = 14;
            this.gradeLabel.Text = "Grade:";
            // 
            // sectionBox
            // 
            this.sectionBox.Location = new System.Drawing.Point(112, 99);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(100, 20);
            this.sectionBox.TabIndex = 15;
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(112, 151);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(100, 20);
            this.gradeBox.TabIndex = 16;
            // 
            // studentBox
            // 
            this.studentBox.Location = new System.Drawing.Point(112, 125);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(100, 20);
            this.studentBox.TabIndex = 17;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(46, 187);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 31);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(43, 249);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 19;
            // 
            // EnrollmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.studentBox);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.crudList);
            this.Name = "EnrollmentsForm";
            this.Text = "EnrollmentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox crudList;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.TextBox studentBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
    }
}