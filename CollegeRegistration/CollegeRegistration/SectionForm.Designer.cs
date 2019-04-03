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
            courseNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseNumber
            // 
            courseNumber.AutoSize = true;
            courseNumber.Location = new System.Drawing.Point(71, 74);
            courseNumber.Name = "courseNumber";
            courseNumber.Size = new System.Drawing.Size(97, 25);
            courseNumber.TabIndex = 0;
            courseNumber.Text = "courseID";
            // 
            // facultyID
            // 
            this.facultyID.AutoSize = true;
            this.facultyID.Location = new System.Drawing.Point(71, 118);
            this.facultyID.Name = "facultyID";
            this.facultyID.Size = new System.Drawing.Size(70, 25);
            this.facultyID.TabIndex = 1;
            this.facultyID.Text = "label2";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(71, 156);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(70, 25);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "label3";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(71, 193);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(70, 25);
            this.dayLabel.TabIndex = 3;
            this.dayLabel.Text = "label4";
            // 
            // semesterID
            // 
            this.semesterID.AutoSize = true;
            this.semesterID.Location = new System.Drawing.Point(71, 233);
            this.semesterID.Name = "semesterID";
            this.semesterID.Size = new System.Drawing.Size(70, 25);
            this.semesterID.TabIndex = 4;
            this.semesterID.Text = "label5";
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semesterID);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.facultyID);
            this.Controls.Add(courseNumber);
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
    }
}