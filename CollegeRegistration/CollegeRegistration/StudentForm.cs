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
    public partial class StudentForm : Form
    {
        RegistrationEntities studentEntities;
        public StudentForm()
        {
            InitializeComponent();
            studentEntities = new RegistrationEntities();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string selected = this.crudList.GetItemText(this.crudList.SelectedItem);

            if (selected == "Create")
            {
                addStudent(nameBox.Text, Convert.ToInt32(majorBox.Text));
                nameBox.Clear();
                majorBox.Clear();
            }

            else if (selected == "Read")
            {
                readStudents();
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

        private void addStudent(string name, int majID)
        {
            var testForMajor = studentEntities.Majors.Where(m => m.Id == majID);

            if (testForMajor.Any())
            {
                Student newStudent = new Student()
                {
                    Name = name,
                    MajorID = majID
                };

                studentEntities.Students.Add(newStudent);
                studentEntities.SaveChanges();
            }
            else
            {
                errorLabel.Text = "Error, no Major of that type currently exists.";
            }
        }

        private void readStudents()
        {

        }
    }
}
