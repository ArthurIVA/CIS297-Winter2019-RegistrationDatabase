namespace CollegeRegistration
{
    partial class StudentForm
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
            this.studentName = new System.Windows.Forms.Label();
            this.majorName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.majorBox = new System.Windows.Forms.TextBox();
            this.crudList = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.readList = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.optionsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(32, 104);
            this.studentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(38, 13);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "Name:";
            // 
            // majorName
            // 
            this.majorName.AutoSize = true;
            this.majorName.Location = new System.Drawing.Point(32, 130);
            this.majorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(50, 13);
            this.majorName.TabIndex = 1;
            this.majorName.Text = "Major ID:";
            this.majorName.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(84, 101);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 2;
            // 
            // majorBox
            // 
            this.majorBox.Location = new System.Drawing.Point(84, 127);
            this.majorBox.Name = "majorBox";
            this.majorBox.Size = new System.Drawing.Size(100, 20);
            this.majorBox.TabIndex = 3;
            // 
            // crudList
            // 
            this.crudList.FormattingEnabled = true;
            this.crudList.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.crudList.Location = new System.Drawing.Point(35, 68);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(121, 21);
            this.crudList.TabIndex = 4;
            this.crudList.SelectedIndexChanged += new System.EventHandler(this.crudList_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(35, 183);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(32, 222);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(24, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "test";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(32, 157);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(185, 13);
            this.studentIDLabel.TabIndex = 7;
            this.studentIDLabel.Text = "Student ID (For Updating or Deletion):";
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(223, 154);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(100, 20);
            this.deleteBox.TabIndex = 8;
            // 
            // readList
            // 
            this.readList.FormattingEnabled = true;
            this.readList.Location = new System.Drawing.Point(380, 101);
            this.readList.Name = "readList";
            this.readList.Size = new System.Drawing.Size(410, 251);
            this.readList.TabIndex = 19;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(490, 73);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 20);
            this.searchBox.TabIndex = 20;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(377, 76);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(107, 13);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "Please enter a Major:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(677, 73);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 23);
            this.searchButton.TabIndex = 22;
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
            this.optionsBox.Location = new System.Drawing.Point(35, 22);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(121, 21);
            this.optionsBox.TabIndex = 23;
            this.optionsBox.SelectedIndexChanged += new System.EventHandler(this.optionsBox_SelectedIndexChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 410);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.readList);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.crudList);
            this.Controls.Add(this.majorBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.majorName);
            this.Controls.Add(this.studentName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label majorName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox majorBox;
        private System.Windows.Forms.ComboBox crudList;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.ListBox readList;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox optionsBox;
    }
}