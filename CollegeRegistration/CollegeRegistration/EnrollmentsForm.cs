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
    public partial class EnrollmentsForm : Form
    {
        RegistrationEntities enrollmentEntities;
        public EnrollmentsForm()
        {
            enrollmentEntities = new RegistrationEntities();
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string selected = this.crudList.GetItemText(this.crudList.SelectedItem);

            if (selected == "Create")
            {
                addEnrollments(Convert.ToInt32(sectionBox.Text), Convert.ToInt32(studentBox.Text), gradeBox.Text);
                sectionBox.Clear();
                studentBox.Clear();
                gradeBox.Clear();
            }

            else if (selected == "Read")
            {

            }

            else if (selected == "Update")
            {

            }

            else if (selected == "Delete")
            {

            }

            else
            {
                errorLabel.Text = "Please enter a valid operation option.";
            }
        }

        private void addEnrollments(int secID, int studentID, string grade)
        {
            var sectionCheck = enrollmentEntities.Sections.Where(s => s.Id == secID);
            var studentCheck = enrollmentEntities.Students.Where(s => s.Id == studentID);

            if(sectionCheck.Any() && studentCheck.Any())
            {
                Enrollment newEnroll = new Enrollment()
                {
                    SectionID = secID,
                    StudentID = studentID,
                    Grade = grade
                };

                enrollmentEntities.Enrollments.Add(newEnroll);
                enrollmentEntities.SaveChanges();
            }

            else if(sectionCheck.Any() && (studentCheck.Any() == false))
            {
                errorLabel.Text = "The student you entered does not exist, please enter a valid Student ID.";
            }

            else if((sectionCheck.Any() == false) && studentCheck.Any())
            {
                errorLabel.Text = "The section you entered does not exist, please enter a valid Section ID.";
            }

            else
            {
                errorLabel.Text = "Neither the student you entered, nor the section exist, please enter valid data.";
            }
        }
    }
}
