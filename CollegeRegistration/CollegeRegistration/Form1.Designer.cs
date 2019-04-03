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
            this.objectBox.Location = new System.Drawing.Point(384, 147);
            this.objectBox.Name = "objectBox";
            this.objectBox.Size = new System.Drawing.Size(219, 33);
            this.objectBox.TabIndex = 0;
            this.objectBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selectObjectButton
            // 
            this.selectObjectButton.Location = new System.Drawing.Point(678, 147);
            this.selectObjectButton.Name = "selectObjectButton";
            this.selectObjectButton.Size = new System.Drawing.Size(120, 60);
            this.selectObjectButton.TabIndex = 1;
            this.selectObjectButton.Text = "Enter";
            this.selectObjectButton.UseVisualStyleBackColor = true;
            this.selectObjectButton.Click += new System.EventHandler(this.selectObjectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 712);
            this.Controls.Add(this.selectObjectButton);
            this.Controls.Add(this.objectBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox objectBox;
        private System.Windows.Forms.Button selectObjectButton;
    }
}