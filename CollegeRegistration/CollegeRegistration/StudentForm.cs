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
            crudList.Enabled = false;
            nameBox.Enabled = false;
            majorBox.Enabled = false;
            deleteBox.Enabled = false;
            submitButton.Enabled = false;
            searchBox.Enabled = false;
            searchButton.Enabled = false;
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
                nameBox.Enabled = false;
                majorBox.Enabled = false;
                readStudents();
            }

            else if (selected == "Update")
            {
                updateStudent(nameBox.Text, majorBox.Text, Convert.ToInt32(deleteBox.Text));
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
                errorLabel.Text = "Student Added";
            }
            else
            {
                errorLabel.Text = "Error, no Major of that type currently exists.";
            }
        }

        private void readStudents()
        {
            var studentCheck = studentEntities.Students.Where(s => s.Id > 0).ToList();

            foreach(var student in studentCheck)
            {
                var majorCheck = studentEntities.Majors.Where(m => m.Id == student.MajorID).ToList();
                string majors = "";

                foreach(var major in majorCheck)
                {
                    majors = major.Name;
                }

                readList.Items.Add($"{student.Name} - " + majors + $"{Environment.NewLine}");
            }
        }

        private void updateStudent(string sName, string sMajor, int sID)
        {
            var studentCheck = studentEntities.Students.Where(s => s.Id == sID).ToList();

            if(studentCheck.Any())
            {
                foreach(var student in studentCheck)
                {
                    if(!string.IsNullOrEmpty(sName))
                    {
                        student.Name = sName;
                        studentEntities.SaveChanges();
                    }
                    if (!string.IsNullOrEmpty(sMajor))
                    {
                        student.MajorID = Convert.ToInt32(sMajor);
                        studentEntities.SaveChanges();
                    }
                }

                errorLabel.Text = "Student has been updated.";
                nameBox.Clear();
                majorBox.Clear();
            }
        }

        private void searchByMajor(string major)
        {
            var majorCheck = studentEntities.Majors.Where(m => m.Name.Contains(major)).ToList();
            readList.Items.Clear();

            if(majorCheck.Any())
            {
                readList.Items.Add("These are the Students that are currently taking this Major: " + $"{Environment.NewLine}");
                foreach (var majors in majorCheck)
                {
                    var studentCheck = studentEntities.Students.Where(s => s.MajorID == majors.Id);

                    if(studentCheck.Any())
                    {
                        foreach(var student in studentCheck)
                        {
                            readList.Items.Add(student.Name);
                        }
                    }
                    else
                    {
                        readList.Items.Add("There are no students studying this major.");
                    }
                }
            }
            else
            {
                readList.Items.Add("There major you entered is not listed.");
            }
        }

        private void optionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.optionsBox.GetItemText(this.optionsBox.SelectedItem);

            if (selected == "CRUD Operations")
            {
                crudList.Enabled = true;
                nameBox.Enabled = true;
                majorBox.Enabled = true;
                deleteBox.Enabled = false;
                submitButton.Enabled = true;
                searchBox.Enabled = false;
                searchButton.Enabled = false;
            }
            else if (selected == "Search Operation")
            {
                crudList.Enabled = false;
                nameBox.Enabled = false;
                majorBox.Enabled = false;
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
                searchByMajor(searchBox.Text);
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
