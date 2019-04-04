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
            this.deleteLabel = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.readList = new System.Windows.Forms.ListBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.optionsBox = new System.Windows.Forms.ComboBox();
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
            this.crudList.Location = new System.Drawing.Point(46, 72);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(223, 21);
            this.crudList.TabIndex = 11;
            this.crudList.SelectedIndexChanged += new System.EventHandler(this.crudList_SelectedIndexChanged);
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(46, 131);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(60, 13);
            this.sectionLabel.TabIndex = 12;
            this.sectionLabel.Text = "Section ID:";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(45, 154);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(61, 13);
            this.studentLabel.TabIndex = 13;
            this.studentLabel.Text = "Student ID:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(46, 180);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeLabel.TabIndex = 14;
            this.gradeLabel.Text = "Grade:";
            // 
            // sectionBox
            // 
            this.sectionBox.Location = new System.Drawing.Point(112, 128);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(100, 20);
            this.sectionBox.TabIndex = 15;
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(112, 177);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(100, 20);
            this.gradeBox.TabIndex = 16;
            // 
            // studentBox
            // 
            this.studentBox.Location = new System.Drawing.Point(112, 151);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(100, 20);
            this.studentBox.TabIndex = 17;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(46, 236);
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
            this.errorLabel.Location = new System.Drawing.Point(43, 279);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(24, 13);
            this.errorLabel.TabIndex = 19;
            this.errorLabel.Text = "test";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Location = new System.Drawing.Point(43, 209);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(197, 13);
            this.deleteLabel.TabIndex = 20;
            this.deleteLabel.Text = "EnrollmentID (For Updating or Deletion): ";
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(246, 206);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(101, 20);
            this.deleteBox.TabIndex = 21;
            // 
            // readList
            // 
            this.readList.FormattingEnabled = true;
            this.readList.Location = new System.Drawing.Point(353, 95);
            this.readList.Name = "readList";
            this.readList.Size = new System.Drawing.Size(410, 251);
            this.readList.TabIndex = 22;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(350, 72);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(118, 13);
            this.searchLabel.TabIndex = 23;
            this.searchLabel.Text = "Please enter a Student:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(465, 69);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 20);
            this.searchBox.TabIndex = 24;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(650, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 23);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // optionsBox
            // 
            this.optionsBox.FormattingEnabled = true;
            this.optionsBox.Items.AddRange(new object[] {
            "CRUD Operations",
            "Search Operation"});
            this.optionsBox.Location = new System.Drawing.Point(46, 12);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(121, 21);
            this.optionsBox.TabIndex = 26;
            this.optionsBox.SelectedIndexChanged += new System.EventHandler(this.optionsBox_SelectedIndexChanged);
            // 
            // EnrollmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.readList);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.deleteLabel);
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
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.ListBox readList;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox optionsBox;
    }
}