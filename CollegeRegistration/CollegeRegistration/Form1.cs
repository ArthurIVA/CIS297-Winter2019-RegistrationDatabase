using System;
using System.Windows.Forms;

namespace CollegeRegistration
{
    public partial class Form1 : Form
    {
        RegistrationEntities registrationEntities;
        public Form1()
        {
            InitializeComponent();
            registrationEntities = new RegistrationEntities();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            objectBox.Items.Add("Student");
            objectBox.Items.Add("Major");
            objectBox.Items.Add("Enrollment");
            objectBox.Items.Add("Section");
            objectBox.Items.Add("Faculty");
            objectBox.Items.Add("Course");
        }

        private void selectObjectButton_Click(object sender, EventArgs e)
        {
            string selected = this.objectBox.GetItemText(this.objectBox.SelectedItem);

            if(selected == "Student")
            {
                StudentForm std = new StudentForm();
                std.Show();
            }

            else if (selected == "Faculty")
            {
                FacultyForm fac = new FacultyForm();
                fac.Show();
            }

            else if (selected == "Major")
            {
                MajorForm maj = new MajorForm();
                maj.Show();
            }

            else if (selected == "Enrollment")
            {
                EnrollmentsForm enr = new EnrollmentsForm();
                enr.Show();
            }

            else if (selected == "Section")
            {
                SectionForm sec = new SectionForm();
                sec.Show();
            }

            else if (selected == "Course")
            {
                CourseForm cor = new CourseForm();
                cor.Show();
            }

            else
            {
                errorLabel.Text = "Please select a form to fill out from the selected criteria.";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
