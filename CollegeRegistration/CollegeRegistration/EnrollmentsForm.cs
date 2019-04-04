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
            crudList.Enabled = false;
            studentBox.Enabled = false;
            gradeBox.Enabled = false;
            deleteBox.Enabled = false;
            submitButton.Enabled = false;
            searchBox.Enabled = false;
            searchButton.Enabled = false;
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
                sectionBox.Enabled = false;
                studentBox.Enabled = false;
                gradeBox.Enabled = false;
                readEnrollments();
            }

            else if (selected == "Update")
            {
                updateEnrollments(sectionBox.Text, studentBox.Text, gradeBox.Text, Convert.ToInt32(deleteBox.Text));
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

        private void readEnrollments()
        {
            var enrollmentsCheck = enrollmentEntities.Enrollments.Where(e => e.Id > 0).ToList();

            foreach(var enroll in enrollmentsCheck)
            {
                var sectionCheck = enrollmentEntities.Sections.Where(s => s.Id == enroll.SectionID).ToList();
                var studentCheck = enrollmentEntities.Students.Where(s => s.Id == enroll.StudentID).ToList();
                string students = "";

                foreach(var student in studentCheck)
                {
                    students = student.Name;
                }

                readList.Items.Add(students + " - " + $"{enroll.SectionID} - {enroll.Grade}{Environment.NewLine}");
            }
        }

        private void searchByStudentOrSemester(string search)
        {
            var studentCheck = enrollmentEntities.Students.Where(s => s.Name.Contains(search)).ToList();
            var semesterCheck = enrollmentEntities.Sections.Where(s => s.Semester.Contains(search)).ToList();
            readList.Items.Clear();

            if(studentCheck.Any())
            {
                foreach(var students in studentCheck)
                {
                    var nameCheck = enrollmentEntities.Enrollments.Where(e => e.StudentID == students.Id).ToList();

                    if(nameCheck.Any())
                    {
                        readList.Items.Add("These are the enrollments for " + students.Name + $"{Environment.NewLine}");
                        foreach(var names in nameCheck)
                        {
                            readList.Items.Add("Section Number: " + $"{names.SectionID} - {names.Grade} {Environment.NewLine}");
                        }
                    }
                    else
                    {
                        readList.Items.Add("This student has no enrollments.");
                    }
                }
            }
            else if(semesterCheck.Any())
            {
                foreach(var sem in semesterCheck)
                {
                    var semCheck = enrollmentEntities.Enrollments.Where(e => e.SectionID == sem.Id).ToList();

                    if(semCheck.Any())
                    {
                        readList.Items.Add("These are all the enrollments for this Semester: ");
                        foreach(var sec in semCheck)
                        {
                            readList.Items.Add("Section Number: " + $"{sec.SectionID}" + " Student ID: " + $"{sec.StudentID} - {sec.Grade} {Environment.NewLine}");
                        }
                    }
                    else
                    {
                        readList.Items.Add("There are no enrollments this semester.");
                    }
                }
                
            }
            else
            {
                readList.Items.Add("There are no enrollments in this semester or no enrollments for this student, please enter new data.");
            }
        }

        private void updateEnrollments(string secID, string stuID, string grade, int enrollID)
        {
            var enrollCheck = enrollmentEntities.Enrollments.Where(e => e.Id == enrollID).ToList();

            if (enrollCheck.Any())
            {
                foreach(var enroll in enrollCheck)
                {
                    if(!string.IsNullOrEmpty(secID))
                    {
                        enroll.SectionID = Convert.ToInt32(secID);
                        enrollmentEntities.SaveChanges();
                    }
                    if(!string.IsNullOrEmpty(stuID))
                    {
                        enroll.StudentID = Convert.ToInt32(stuID);
                        enrollmentEntities.SaveChanges();
                    }
                    if (!string.IsNullOrEmpty(grade))
                    {
                        enroll.Grade = grade;
                        enrollmentEntities.SaveChanges();
                    }
                }

                errorLabel.Text = "The Enrollment has been updated.";
                sectionBox.Clear();
                studentBox.Clear();
                gradeBox.Clear();
            }
            else
            {
                errorLabel.Text = "Incorrect Enrollment ID.";
            }
        }

        private void optionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.optionsBox.GetItemText(this.optionsBox.SelectedItem);

            if (selected == "CRUD Operations")
            {
                crudList.Enabled = true;
                studentBox.Enabled = true;
                gradeBox.Enabled = true;
                deleteBox.Enabled = true;
                submitButton.Enabled = true;
                searchBox.Enabled = false;
                searchButton.Enabled = false;
            }
            else if (selected == "Search Operation")
            {
                crudList.Enabled = false;
                studentBox.Enabled = false;
                gradeBox.Enabled = false;
                deleteBox.Enabled = false;
                submitButton.Enabled = false;
                searchBox.Enabled = true;
                searchButton.Enabled = true;
            }
            else
            {
                errorLabel.Text = "Please select a valid option.";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                readList.Items.Add("Please enter some data.");
                searchBox.Clear();
            }
            else
            {
                searchByStudentOrSemester(searchBox.Text);
            }
        }

        private void crudList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.crudList.GetItemText(this.crudList.SelectedItem);

            if(selected == "Update" || selected == "Delete")
            {
                deleteBox.Enabled = true;
            }
            else
            {
                deleteBox.Enabled = false;
            }
        }
    }
}
