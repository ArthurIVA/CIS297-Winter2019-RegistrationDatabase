﻿using System;
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

        private void searchBySemester(string semester)
        {

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
    }
}
