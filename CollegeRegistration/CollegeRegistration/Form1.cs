using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            }

        }
    }
}
