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
    public partial class MajorForm : Form
    {
        RegistrationEntities MajorEntities;
        public MajorForm()
        {
            InitializeComponent();
            MajorEntities = new RegistrationEntities();
            deleteBox.Enabled = false;
        }

        private void MajorForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string selected = this.majorOptions.GetItemText(this.majorOptions.SelectedItem);

            if (selected == "Create")
            {
                addMajor(nameBox.Text, collegeBox.Text);
                nameBox.Clear();
                collegeBox.Clear();
            }

            else if (selected == "Read")
            {
                nameBox.Enabled = false;
                collegeBox.Enabled = false;
                readMajor();
            }

            else if (selected == "Update")
            {
                updateMajor(nameBox.Text, collegeBox.Text, Convert.ToInt32(deleteBox.Text));
            }

            else if (selected == "Delete")
            {
                deleteMajor(Convert.ToInt32(deleteBox.Text));
            }

            else
            {
                errorLabel.Text = "Please enter a valid operation option.";
            }
        }

        private void addMajor(string name, string college)
        {
            Major newMajor = new Major()
            {
                Name = name,
                College = college
            };

            MajorEntities.Majors.Add(newMajor);
            MajorEntities.SaveChanges();
            errorLabel.Text = "Major Added.";
        }

        private void updateMajor(string mName, string mCollege, int mID)
        {
            var majorCheck = MajorEntities.Majors.Where(m => m.Id == mID).ToList();

            if(majorCheck.Any())
            {
                foreach(var major in majorCheck)
                {
                    if (!string.IsNullOrEmpty(mName))
                    {
                        major.Name = mName;
                        MajorEntities.SaveChanges();
                    }
                    if (!string.IsNullOrEmpty(mCollege))
                    {
                        major.College = mCollege;
                        MajorEntities.SaveChanges();
                    }
                }

                errorLabel.Text = "Major has been updated.";
                nameBox.Clear();
                collegeBox.Clear();
            }
            else
            {
                errorLabel.Text = "Invalid Major ID.";
            }

        }

        private void readMajor()
        {
            
            var majorCheck = MajorEntities.Majors.Where(m => m.Id != 0).ToList();

            readList.Items.Clear();
            foreach(var major in majorCheck)
            { 
                readList.Items.Add($"{major.Name} - {major.College}{Environment.NewLine}");
            }
        }

        private void deleteMajor(int id)
        {
            var majorCheck = MajorEntities.Majors.Where(m => m.Id == id).ToList();

            if (majorCheck.Any())
            {
                foreach (var major in majorCheck)
                {
                    var studentCheck = MajorEntities.Students.Where(s => s.Id == major.Id).ToList();

                    if (studentCheck.Count() > 0)
                    {
                        errorLabel.Text = "You cannot delete this Major, there are students who have this major.";
                    }
                    else
                    {
                        MajorEntities.Majors.Remove(major);
                        MajorEntities.SaveChanges();
                        errorLabel.Text = "Major has been deleted.";
                        deleteLabel.Text = string.Empty;
                    }
                    
                }

                deleteLabel.Text = "Should work.";
            }

            else
            {
                errorLabel.Text = "The major you have entered does not exist, please enter a valid Major.";
                deleteLabel.Text = "Please enter a valid Major ID.";
            }

        }

        private void majorOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.majorOptions.GetItemText(this.majorOptions.SelectedItem);

            if (selected == "Delete")
            {
                deleteLabel.Text = "PLEASE ENTER A VALID MAJOR ID TO BE DELETED FROM THE TABLE.";
            }

            if(selected == "Update")
            {
                deleteBox.Enabled = true;
            }
        }
    }
}
