namespace CollegeRegistration
{
    partial class SectionForm
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
            System.Windows.Forms.Label courseNumber;
            this.facultyID = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.semesterID = new System.Windows.Forms.Label();
            this.facultyBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.semesterBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.crudList = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.optionsBox = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.readList = new System.Windows.Forms.ListBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            courseNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseNumber
            // 
            courseNumber.AutoSize = true;
            courseNumber.Location = new System.Drawing.Point(36, 131);
            courseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            courseNumber.Name = "courseNumber";
            courseNumber.Size = new System.Drawing.Size(57, 13);
            courseNumber.TabIndex = 0;
            courseNumber.Text = "Course ID:";
            // 
            // facultyID
            // 
            this.facultyID.AutoSize = true;
            this.facultyID.Location = new System.Drawing.Point(36, 157);
            this.facultyID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyID.Name = "facultyID";
            this.facultyID.Size = new System.Drawing.Size(58, 13);
            this.facultyID.TabIndex = 1;
            this.facultyID.Text = "Faculty ID:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(36, 183);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(38, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Times:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(36, 209);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(34, 13);
            this.dayLabel.TabIndex = 3;
            this.dayLabel.Text = "Days:";
            // 
            // semesterID
            // 
            this.semesterID.AutoSize = true;
            this.semesterID.Location = new System.Drawing.Point(36, 235);
            this.semesterID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semesterID.Name = "semesterID";
            this.semesterID.Size = new System.Drawing.Size(54, 13);
            this.semesterID.TabIndex = 4;
            this.semesterID.Text = "Semester:";
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(98, 154);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(100, 20);
            this.facultyBox.TabIndex = 5;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(98, 180);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 20);
            this.timeBox.TabIndex = 6;
            // 
            // semesterBox
            // 
            this.semesterBox.Location = new System.Drawing.Point(98, 232);
            this.semesterBox.Name = "semesterBox";
            this.semesterBox.Size = new System.Drawing.Size(100, 20);
            this.semesterBox.TabIndex = 7;
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(98, 206);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(100, 20);
            this.dayBox.TabIndex = 8;
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(98, 128);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(100, 20);
            this.courseBox.TabIndex = 9;
            // 
            // crudList
            // 
            this.crudList.FormattingEnabled = true;
            this.crudList.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.crudList.Location = new System.Drawing.Point(39, 69);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(121, 21);
            this.crudList.TabIndex = 10;
            this.crudList.SelectedIndexChanged += new System.EventHandler(this.crudList_SelectedIndexChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(36, 335);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(24, 13);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "test";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(39, 291);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 31);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(36, 104);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 13;
            this.testLabel.Text = "label1";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(39, 261);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(193, 13);
            this.secLabel.TabIndex = 14;
            this.secLabel.Text = "Section ID(For Updating and Deleting): ";
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(238, 258);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(100, 20);
            this.deleteBox.TabIndex = 15;
            // 
            // optionsBox
            // 
            this.optionsBox.FormattingEnabled = true;
            this.optionsBox.Items.AddRange(new object[] {
            "CRUD Operations",
            "Search Operation"});
            this.optionsBox.Location = new System.Drawing.Point(39, 12);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(121, 21);
            this.optionsBox.TabIndex = 16;
            this.optionsBox.SelectedIndexChanged += new System.EventHandler(this.optionsBox_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(489, 70);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(169, 20);
            this.searchBox.TabIndex = 17;
            // 
            // readList
            // 
            this.readList.FormattingEnabled = true;
            this.readList.Location = new System.Drawing.Point(489, 104);
            this.readList.Name = "readList";
            this.readList.Size = new System.Drawing.Size(410, 251);
            this.readList.TabIndex = 18;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(486, 54);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(322, 13);
            this.searchLabel.TabIndex = 19;
            this.searchLabel.Text = "Please enter a Semester or a Faculty Name (Only one or the other):";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(664, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 23);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 485);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.readList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.crudList);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.semesterBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.facultyBox);
            this.Controls.Add(this.semesterID);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.facultyID);
            this.Controls.Add(courseNumber);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facultyID;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label semesterID;
        private System.Windows.Forms.TextBox facultyBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox semesterBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.ComboBox crudList;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.ComboBox optionsBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox readList;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
    }
}