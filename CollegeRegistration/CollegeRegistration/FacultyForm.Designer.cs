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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.crudList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // facultyName
            // 
            this.facultyName.AutoSize = true;
            this.facultyName.Location = new System.Drawing.Point(41, 43);
            this.facultyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyName.Name = "facultyName";
            this.facultyName.Size = new System.Drawing.Size(38, 13);
            this.facultyName.TabIndex = 0;
            this.facultyName.Text = "Name:";
            // 
            // facultyPhoneNumber
            // 
            this.facultyPhoneNumber.AutoSize = true;
            this.facultyPhoneNumber.Location = new System.Drawing.Point(41, 69);
            this.facultyPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyPhoneNumber.Name = "facultyPhoneNumber";
            this.facultyPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.facultyPhoneNumber.TabIndex = 1;
            this.facultyPhoneNumber.Text = "Phone Number:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(84, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 3;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(127, 66);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(100, 20);
            this.numberBox.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(44, 105);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 31);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(41, 151);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 7;
            // 
            // crudList
            // 
            this.crudList.FormattingEnabled = true;
            this.crudList.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.crudList.Location = new System.Drawing.Point(44, 12);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(121, 21);
            this.crudList.TabIndex = 8;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 331);
            this.Controls.Add(this.crudList);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.facultyPhoneNumber);
            this.Controls.Add(this.facultyName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facultyName;
        private System.Windows.Forms.Label facultyPhoneNumber;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox crudList;
    }
}