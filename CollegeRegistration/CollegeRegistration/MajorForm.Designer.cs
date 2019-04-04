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
            this.submitButton = new System.Windows.Forms.Button();
            this.majorOptions = new System.Windows.Forms.ComboBox();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.majLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.readList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // majorName
            // 
            this.majorName.AutoSize = true;
            this.majorName.Location = new System.Drawing.Point(42, 67);
            this.majorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(38, 13);
            this.majorName.TabIndex = 0;
            this.majorName.Text = "Name:";
            // 
            // collegeName
            // 
            this.collegeName.AutoSize = true;
            this.collegeName.Location = new System.Drawing.Point(42, 93);
            this.collegeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.collegeName.Name = "collegeName";
            this.collegeName.Size = new System.Drawing.Size(45, 13);
            this.collegeName.TabIndex = 1;
            this.collegeName.Text = "College:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(85, 64);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 2;
            // 
            // collegeBox
            // 
            this.collegeBox.Location = new System.Drawing.Point(85, 90);
            this.collegeBox.Name = "collegeBox";
            this.collegeBox.Size = new System.Drawing.Size(100, 20);
            this.collegeBox.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(42, 180);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 6;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(45, 154);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // majorOptions
            // 
            this.majorOptions.FormattingEnabled = true;
            this.majorOptions.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.majorOptions.Location = new System.Drawing.Point(45, 13);
            this.majorOptions.Name = "majorOptions";
            this.majorOptions.Size = new System.Drawing.Size(121, 21);
            this.majorOptions.TabIndex = 8;
            this.majorOptions.SelectedIndexChanged += new System.EventHandler(this.majorOptions_SelectedIndexChanged);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(234, 113);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(100, 20);
            this.deleteBox.TabIndex = 16;
            // 
            // majLabel
            // 
            this.majLabel.AutoSize = true;
            this.majLabel.Location = new System.Drawing.Point(42, 116);
            this.majLabel.Name = "majLabel";
            this.majLabel.Size = new System.Drawing.Size(186, 13);
            this.majLabel.TabIndex = 17;
            this.majLabel.Text = "Major ID (For Updating and Deleting): ";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Location = new System.Drawing.Point(42, 37);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(35, 13);
            this.deleteLabel.TabIndex = 18;
            this.deleteLabel.Text = "label1";
            // 
            // readList
            // 
            this.readList.FormattingEnabled = true;
            this.readList.Location = new System.Drawing.Point(440, 64);
            this.readList.Name = "readList";
            this.readList.Size = new System.Drawing.Size(368, 225);
            this.readList.TabIndex = 20;
            // 
            // MajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 424);
            this.Controls.Add(this.readList);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.majLabel);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.majorOptions);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.collegeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.collegeName);
            this.Controls.Add(this.majorName);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox majorOptions;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Label majLabel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.ListBox readList;
    }
}