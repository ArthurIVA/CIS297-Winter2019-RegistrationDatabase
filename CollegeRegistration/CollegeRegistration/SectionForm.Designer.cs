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
            courseNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseNumber
            // 
            courseNumber.AutoSize = true;
            courseNumber.Location = new System.Drawing.Point(36, 101);
            courseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            courseNumber.Name = "courseNumber";
            courseNumber.Size = new System.Drawing.Size(57, 13);
            courseNumber.TabIndex = 0;
            courseNumber.Text = "Course ID:";
            // 
            // facultyID
            // 
            this.facultyID.AutoSize = true;
            this.facultyID.Location = new System.Drawing.Point(36, 126);
            this.facultyID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyID.Name = "facultyID";
            this.facultyID.Size = new System.Drawing.Size(58, 13);
            this.facultyID.TabIndex = 1;
            this.facultyID.Text = "Faculty ID:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(36, 151);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(38, 13);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Times:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(36, 174);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(34, 13);
            this.dayLabel.TabIndex = 3;
            this.dayLabel.Text = "Days:";
            // 
            // semesterID
            // 
            this.semesterID.AutoSize = true;
            this.semesterID.Location = new System.Drawing.Point(36, 200);
            this.semesterID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semesterID.Name = "semesterID";
            this.semesterID.Size = new System.Drawing.Size(54, 13);
            this.semesterID.TabIndex = 4;
            this.semesterID.Text = "Semester:";
            // 
            // facultyBox
            // 
            this.facultyBox.Location = new System.Drawing.Point(98, 123);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(100, 20);
            this.facultyBox.TabIndex = 5;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(98, 145);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 20);
            this.timeBox.TabIndex = 6;
            // 
            // semesterBox
            // 
            this.semesterBox.Location = new System.Drawing.Point(98, 197);
            this.semesterBox.Name = "semesterBox";
            this.semesterBox.Size = new System.Drawing.Size(100, 20);
            this.semesterBox.TabIndex = 7;
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(98, 171);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(100, 20);
            this.dayBox.TabIndex = 8;
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(98, 101);
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
            this.crudList.Location = new System.Drawing.Point(39, 36);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(121, 21);
            this.crudList.TabIndex = 10;
            this.crudList.SelectedIndexChanged += new System.EventHandler(this.crudList_SelectedIndexChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(36, 268);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(39, 268);
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
            this.testLabel.Location = new System.Drawing.Point(39, 71);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 13;
            this.testLabel.Text = "label1";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(39, 228);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(147, 13);
            this.secLabel.TabIndex = 14;
            this.secLabel.Text = "Section ID(Only for Deletion): ";
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(192, 225);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(100, 20);
            this.deleteBox.TabIndex = 15;
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 389);
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
    }
}