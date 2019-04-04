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
    public partial class CourseForm : Form
    {
        RegistrationEntities courseEntities;
        public CourseForm()
        {
            InitializeComponent();
            courseEntities = new RegistrationEntities();
            crudList.Enabled = false;
            nameBox.Enabled = false;
            numberBox.Enabled = false;
            creditsBox.Enabled = false;
            deptBox.Enabled = false;
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
                addCourse(nameBox.Text, numberBox.Text, Convert.ToInt32(creditsBox.Text), deptBox.Text);
                nameBox.Clear();
                numberBox.Clear();
                creditsBox.Clear();
                deptBox.Clear();
            }

            else if (selected == "Read")
            {
                nameBox.Enabled = false;
                numberBox.Enabled = false;
                creditsBox.Enabled = false;
                deptBox.Enabled = false;
                readCourse();
            }

            else if (selected == "Update")
            {
                updateCourse(nameBox.Text, numberBox.Text, creditsBox.Text, deptBox.Text, Convert.ToInt32(deleteBox.Text));
            }

            else if (selected == "Delete")
            {

            }

            else
            {
                errorLabel.Text = "Please enter a valid operation option.";
            }
        }

        private void addCourse(string name, string num, int credits, string dept)
        {
            Course newCourse = new Course()
            {
                Name = name,
                Number = num,
                Credits = credits,
                Department = dept
            };

            courseEntities.Courses.Add(newCourse);
            courseEntities.SaveChanges();
            errorLabel.Text = "Course Added.";
        }

        private void readCourse()
        {
            readList.Items.Clear();
            var courseCheck = courseEntities.Courses.Where(c => c.Id > 0).ToList();

            foreach(var course in courseCheck)
            {
                var sectionCheck = courseEntities.Sections.Where(s => s.CourseID == course.Id).ToList();

                readList.Items.Add($"{course.Name} - {course.Number} - {course.Credits} {course.Department} - Number of Sections: " + Convert.ToString(sectionCheck.Count()));
            }
        }

        private void searchByDepartment(string dept)
        {
            var courseCheck = courseEntities.Courses.Where(c => c.Department.Contains(dept)).ToList();

            readList.Items.Clear();
            if(courseCheck.Any())
            {
                readList.Items.Add("Here are the courses in the " + dept + " department: " + $"{Environment.NewLine}");
                foreach (var course in courseCheck)
                {
                    readList.Items.Add(course.Name + $"{Environment.NewLine}");
                }
            }
            else
            {
                readList.Items.Add("The Department submitted does not exist in the Database. Please enter a valid department or proper syntax.");
            }
        }

        private void updateCourse(string cName, string cNumber, string cCredits, string cDept, int courseID)
        {
            var courseCheck = courseEntities.Courses.Where(c => c.Id == courseID).ToList();

            if (courseCheck.Any())
            {
                foreach(var course in courseCheck)
                {
                    if(!string.IsNullOrEmpty(cName))
                    {
                        course.Name = cName;
                        courseEntities.SaveChanges();
                    }
                    if (!string.IsNullOrEmpty(cNumber))
                    {
                        course.Number = cNumber;
                        courseEntities.SaveChanges();
                    }
                    if (!string.IsNullOrEmpty(cCredits))
                    {
                        course.Credits = Convert.ToInt32(cCredits);
                        courseEntities.SaveChanges();
                    }
                    if (!string.IsNullOrEmpty(cDept))
                    {
                        course.Department = cDept;
                        courseEntities.SaveChanges();
                    }
                }

                errorLabel.Text = "The Course has been updated.";
                nameBox.Clear();
                numberBox.Clear();
                creditsBox.Clear();
                deptBox.Clear();
            }
            else
            {
                errorLabel.Text = "Incorrect Course ID.";
            }
        }

        private void optionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.optionsBox.GetItemText(this.optionsBox.SelectedItem);

            if (selected == "CRUD Operations")
            {
                crudList.Enabled = true;
                nameBox.Enabled = true;
                numberBox.Enabled = true;
                creditsBox.Enabled = true;
                deptBox.Enabled = true;
                deleteBox.Enabled = false;
                submitButton.Enabled = true;
                searchBox.Enabled = false;
                searchButton.Enabled = false;
            }
            else if (selected == "Search Operation")
            {
                crudList.Enabled = false;
                nameBox.Enabled = false;
                numberBox.Enabled = false;
                creditsBox.Enabled = false;
                deptBox.Enabled = false;
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
            if(string.IsNullOrEmpty(searchBox.Text))
            {
                readList.Items.Add("Please enter some data.");
                searchBox.Clear();
            }
            else
            {
                searchByDepartment(searchBox.Text);
            }
        }

        private void crudList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.crudList.GetItemText(this.crudList.SelectedItem);

            if (selected == "Update")
            {
                deleteBox.Enabled = true;
            }
        }
    }
}
