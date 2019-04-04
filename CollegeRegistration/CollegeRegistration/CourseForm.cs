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
        }
    }
}
