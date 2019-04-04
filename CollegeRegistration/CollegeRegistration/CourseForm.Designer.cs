namespace CollegeRegistration
{
    partial class CourseForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.crudList = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.deptBox = new System.Windows.Forms.TextBox();
            this.creditsBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.facultyIDLabel = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.readList = new System.Windows.Forms.ListBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.optionsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(44, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(44, 147);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(47, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Number:";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(44, 173);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(42, 13);
            this.creditsLabel.TabIndex = 2;
            this.creditsLabel.Text = "Credits:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(44, 199);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(65, 13);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Department:";
            // 
            // crudList
            // 
            this.crudList.FormattingEnabled = true;
            this.crudList.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.crudList.Location = new System.Drawing.Point(47, 76);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(121, 21);
            this.crudList.TabIndex = 5;
            this.crudList.SelectedIndexChanged += new System.EventHandler(this.crudList_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(115, 118);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 6;
            // 
            // deptBox
            // 
            this.deptBox.Location = new System.Drawing.Point(115, 196);
            this.deptBox.Name = "deptBox";
            this.deptBox.Size = new System.Drawing.Size(100, 20);
            this.deptBox.TabIndex = 7;
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(115, 170);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(100, 20);
            this.creditsBox.TabIndex = 8;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(115, 144);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(100, 20);
            this.numberBox.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(47, 245);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(121, 33);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(44, 290);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(24, 13);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "test";
            // 
            // facultyIDLabel
            // 
            this.facultyIDLabel.AutoSize = true;
            this.facultyIDLabel.Location = new System.Drawing.Point(44, 219);
            this.facultyIDLabel.Name = "facultyIDLabel";
            this.facultyIDLabel.Size = new System.Drawing.Size(182, 13);
            this.facultyIDLabel.TabIndex = 22;
            this.facultyIDLabel.Text = "Faculty ID (For Updating or Deletion):";
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(232, 216);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(120, 20);
            this.deleteBox.TabIndex = 23;
            // 
            // readList
            // 
            this.readList.FormattingEnabled = true;
            this.readList.Location = new System.Drawing.Point(358, 107);
            this.readList.Name = "readList";
            this.readList.Size = new System.Drawing.Size(410, 251);
            this.readList.TabIndex = 24;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(355, 84);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(136, 13);
            this.searchLabel.TabIndex = 25;
            this.searchLabel.Text = "Please enter a Department:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(497, 81);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(180, 20);
            this.searchBox.TabIndex = 26;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(683, 78);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 23);
            this.searchButton.TabIndex = 27;
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
            this.optionsBox.Location = new System.Drawing.Point(47, 21);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(121, 21);
            this.optionsBox.TabIndex = 28;
            this.optionsBox.SelectedIndexChanged += new System.EventHandler(this.optionsBox_SelectedIndexChanged);
            // 
            // CourseForm
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
            this.Controls.Add(this.facultyIDLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.creditsBox);
            this.Controls.Add(this.deptBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.crudList);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox crudList;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox deptBox;
        private System.Windows.Forms.TextBox creditsBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label facultyIDLabel;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.ListBox readList;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox optionsBox;
    }
}