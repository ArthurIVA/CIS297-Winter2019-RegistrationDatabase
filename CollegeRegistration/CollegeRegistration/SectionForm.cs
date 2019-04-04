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
    public partial class SectionForm : Form
    {
        RegistrationEntities sectionEntities;
        public SectionForm()
        {
            InitializeComponent();
            sectionEntities = new RegistrationEntities();
            crudList.Enabled = false;
            courseBox.Enabled = false;
            facultyBox.Enabled = false;
            timeBox.Enabled = false;
            dayBox.Enabled = false;
            semesterBox.Enabled = false;
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
                addSection(Convert.ToInt32(courseBox.Text), Convert.ToInt32(facultyBox.Text), timeBox.Text, dayBox.Text, semesterBox.Text);
                courseBox.Clear();
                facultyBox.Clear();
                timeBox.Clear();
                dayBox.Clear();
                semesterBox.Clear();
            }

            else if (selected == "Read")
            {
                readSections();
            }

            else if (selected == "Update")
            {

            }

            else if (selected == "Delete")
            {
                deleteSection(Convert.ToInt32(deleteBox.Text));
                deleteBox.Clear();
            }

            else
            {
                errorLabel.Text = "Please enter a valid operation option.";
            }
        }

        private void addSection(int courseID, int facID, string times, string days, string semester)
        {
            var courseCheck = sectionEntities.Courses.Where(c =>c.Id == courseID);
            var facultyCheck = sectionEntities.Faculties.Where(f => f.Id == facID);

            if(courseCheck.Any() && facultyCheck.Any())
            {
                Section newSection = new Section()
                {
                    CourseID = courseID,
                    FacultyID = facID,
                    Time = times,
                    Day = days,
                    Semester = semester
                };

                sectionEntities.Sections.Add(newSection);
                sectionEntities.SaveChanges();
                errorLabel.Text = "Section Added.";
            }

            else if (courseCheck.Any() && (facultyCheck.Any() == false))
            {
                errorLabel.Text = "No faculty with that ID exists, please put in a new faculty.";
            }

            else if ((courseCheck.Any() == false) && facultyCheck.Any())
            {
                errorLabel.Text = "No course with that ID exists, please put in a new course.";
            }

            else
            {
                errorLabel.Text = "Neither the course nor the faculty you submitted exist, please enter valid data.";
            }
        }

        private void crudList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.crudList.GetItemText(this.crudList.SelectedItem);

            if (selected == "Delete")
            {
                testLabel.Text = "TO DELETE A ROW, PLEASE ENTER THE SECTION ID OF THE SECTION YOU'D LIKE TO DELETE.";
            }
        }

        private void deleteSection(int secID)
        {
            var sectionCheck = sectionEntities.Sections.Where(s => s.Id == secID).ToList();

            if(sectionCheck.Any())
            {
                foreach (var section in sectionCheck)
                {
                    sectionEntities.Sections.Remove(section);
                    sectionEntities.SaveChanges();
                }

                errorLabel.Text = "Sections have been deleted.";
                testLabel.Text = string.Empty;
            }

            else
            {
                errorLabel.Text = "No section that you have entered does not exist, please enter a valid section.";
                testLabel.Text = "Please enter a valid Section ID.";
            }
        }

        private void readSections()
        {
            var sectionCheck = sectionEntities.Sections.Where(s => s.Id > 0);

            readList.Items.Clear();
            foreach(var section in sectionCheck)
            {
                readList.Items.Add($"{section.CourseID} - {section.FacultyID} - {section.Day} - {section.Time} - {section.Semester}{Environment.NewLine}");
            }
        }

        private void searchBySemesterOrFacultyName(string semOrFac)
        {
            readList.Items.Clear();
            var semesterCheck = sectionEntities.Sections.Where(s => s.Semester.Contains(semOrFac)).ToList();
            var facultyCheck = sectionEntities.Faculties.Where(f => f.Name.Contains(semOrFac)).ToList();

            if (semesterCheck.Any())
            {
                readList.Items.Add("Here are the Sections in the " + semOrFac + " Semester: " + $"{Environment.NewLine}");
                foreach (var semester in semesterCheck)
                {
                    readList.Items.Add($"{semester.Id} - {semester.CourseID} {Environment.NewLine}");
                }
            }
            else if(facultyCheck.Any())
            {
                readList.Items.Add("Here are the Sections taught by Professor " + semOrFac + ": " + $"{Environment.NewLine}");
                foreach(var fac in facultyCheck)
                {
                    var idCheck = sectionEntities.Sections.Where(s => s.FacultyID == fac.Id).ToList();
                    
                    if(idCheck.Any())
                    {
                        foreach (var id in idCheck)
                        {
                            var testCheck = sectionEntities.Courses.Where(c => c.Id == id.CourseID).ToList();

                            foreach(var test in testCheck)
                            {
                                readList.Items.Add($"{id.Id} - {test.Name} {Environment.NewLine}");
                            }
                            
                        }
                    }
                    else
                    {
                        readList.Items.Add("There are no sections taught by this faculty member.");
                    }
                    
                }
            }
            else
            {
                readList.Items.Add("There are no sections either in the semester added or the faculty member submitted. Please enter a new semester or faculty member.");
            }
        }

        private void optionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.optionsBox.GetItemText(this.optionsBox.SelectedItem);

            if(selected == "CRUD Operations")
            {
                crudList.Enabled = true;
                courseBox.Enabled = true;
                facultyBox.Enabled = true;
                timeBox.Enabled = true;
                dayBox.Enabled = true;
                semesterBox.Enabled = true;
                deleteBox.Enabled = true;
                submitButton.Enabled = true;
                searchBox.Enabled = false;
                searchButton.Enabled = false;
            }
            else if(selected == "Search Operation")
            {
                searchBox.Enabled = true;
                searchButton.Enabled = true;
                crudList.Enabled = false;
                courseBox.Enabled = false;
                facultyBox.Enabled = false;
                timeBox.Enabled = false;
                dayBox.Enabled = false;
                semesterBox.Enabled = false;
                deleteBox.Enabled = false;
                submitButton.Enabled = false;
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
                searchBySemesterOrFacultyName(searchBox.Text);
            }
        }
    }
}
