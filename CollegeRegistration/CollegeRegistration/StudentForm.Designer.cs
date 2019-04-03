﻿namespace CollegeRegistration
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.crudList = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(32, 61);
            this.studentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(38, 13);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "Name:";
            // 
            // majorName
            // 
            this.majorName.AutoSize = true;
            this.majorName.Location = new System.Drawing.Point(32, 87);
            this.majorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.majorName.Name = "majorName";
            this.majorName.Size = new System.Drawing.Size(36, 13);
            this.majorName.TabIndex = 1;
            this.majorName.Text = "Major:";
            this.majorName.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // crudList
            // 
            this.crudList.FormattingEnabled = true;
            this.crudList.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.crudList.Location = new System.Drawing.Point(35, 12);
            this.crudList.Name = "crudList";
            this.crudList.Size = new System.Drawing.Size(121, 21);
            this.crudList.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(35, 136);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.crudList);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.majorName);
            this.Controls.Add(this.studentName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label majorName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox crudList;
        private System.Windows.Forms.Button submitButton;
    }
}