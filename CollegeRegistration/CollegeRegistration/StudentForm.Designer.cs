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
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(65, 79);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(70, 25);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "label1";
            // 
            // majorName
            // 
            this.majorName.AutoSize = true;
            this.majorName.Location = new System.Drawing.Point(65, 121);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(70, 25);
            this.majorName.TabIndex = 1;
            this.majorName.Text = "label2";
            this.majorName.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.majorName);
            this.Controls.Add(this.studentName);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label majorName;
    }
}