namespace CollegeRegistration
{
    partial class Form1
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
            this.objectBox = new System.Windows.Forms.ComboBox();
            this.selectObjectButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // objectBox
            // 
            this.objectBox.FormattingEnabled = true;
            this.objectBox.Items.AddRange(new object[] {
            "Student",
            "Major",
            "Faculty",
            "Course",
            "Enrollment",
            "Section"});
            this.objectBox.Location = new System.Drawing.Point(45, 69);
            this.objectBox.Margin = new System.Windows.Forms.Padding(2);
            this.objectBox.Name = "objectBox";
            this.objectBox.Size = new System.Drawing.Size(112, 21);
            this.objectBox.TabIndex = 0;
            this.objectBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selectObjectButton
            // 
            this.selectObjectButton.Location = new System.Drawing.Point(45, 112);
            this.selectObjectButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectObjectButton.Name = "selectObjectButton";
            this.selectObjectButton.Size = new System.Drawing.Size(60, 31);
            this.selectObjectButton.TabIndex = 1;
            this.selectObjectButton.Text = "Enter";
            this.selectObjectButton.UseVisualStyleBackColor = true;
            this.selectObjectButton.Click += new System.EventHandler(this.selectObjectButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(189, 143);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 370);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.selectObjectButton);
            this.Controls.Add(this.objectBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox objectBox;
        private System.Windows.Forms.Button selectObjectButton;
        private System.Windows.Forms.Label errorLabel;
    }
}