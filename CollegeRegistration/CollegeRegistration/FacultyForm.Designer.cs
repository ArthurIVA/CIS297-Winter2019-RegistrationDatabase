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
            this.facultySection = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // facultySection
            // 
            this.facultySection.AutoSize = true;
            this.facultySection.Location = new System.Drawing.Point(41, 97);
            this.facultySection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultySection.Name = "facultySection";
            this.facultySection.Size = new System.Drawing.Size(46, 13);
            this.facultySection.TabIndex = 2;
            this.facultySection.Text = "Section:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.facultySection);
            this.Controls.Add(this.facultyPhoneNumber);
            this.Controls.Add(this.facultyName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facultyName;
        private System.Windows.Forms.Label facultyPhoneNumber;
        private System.Windows.Forms.Label facultySection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}