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
    public partial class FacultyForm : Form
    {
        RegistrationEntities facultyEntities;
        public FacultyForm()
        {
            InitializeComponent();
            facultyEntities = new RegistrationEntities();
            deleteBox.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string selected = this.crudList.GetItemText(this.crudList.SelectedItem);

            if (selected == "Create")
            {
                addFaculty(nameBox.Text, numberBox.Text);
                nameBox.Clear();
                numberBox.Clear();
            }

            else if (selected == "Read")
            {
                nameBox.Enabled = false;
                nameBox.Enabled = false;
                readFaculty();
            }

            else if (selected == "Update")
            {
                updateFaculty(nameBox.Text, numberBox.Text, Convert.ToInt32(deleteBox.Text));
            }

            else if (selected == "Delete")
            {

            }

            else
            {
                errorLabel.Text = "Please enter a valid operation option.";
            }
        }
        
        private void addFaculty(string name, string phoneNumber)
        {
            Faculty newFaculty = new Faculty()
            {
                Name = name,
                PhoneNumber = phoneNumber
            };

            facultyEntities.Faculties.Add(newFaculty);
            facultyEntities.SaveChanges();
            errorLabel.Text = "Faculty Added.";
        }

        private void readFaculty()
        {
            var facultyCheck = facultyEntities.Faculties.Where(f => f.Id > 0).ToList();

            foreach(var fac in facultyCheck)
            {
                var sectionCheck = facultyEntities.Sections.Where(s => s.FacultyID == fac.Id).ToList();
                string sections = "";

                foreach(var sec in sectionCheck)
                {
                    sections += " - " + sec.Id;
                }

                readList.Items.Add($"{fac.Name} - {fac.PhoneNumber} - " + sections + $"{Environment.NewLine}");
            }
        }

        private void updateFaculty(string fName, string fNumber, int facID)
        {
            var facCheck = facultyEntities.Faculties.Where(f => f.Id == facID).ToList();

            if(facCheck.Any())
            {
                foreach(var fac in facCheck)
                {
                    if(!string.IsNullOrEmpty(fName))
                    {
                        fac.Name = fName;
                        facultyEntities.SaveChanges();
                    }
                    if(!string.IsNullOrEmpty(fNumber))
                    {
                        fac.PhoneNumber = fNumber;
                        facultyEntities.SaveChanges();
                    }
                }

                errorLabel.Text = "Faculty has been updated.";
                nameBox.Clear();
                numberBox.Clear();
            }
            else
            {
                errorLabel.Text = "Invalid Faculty ID.";
            }
        }

        private void crudList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.crudList.GetItemText(this.crudList.SelectedItem);

            if(selected == "Update")
            {
                deleteBox.Enabled = true;
            }
        }
    }
}
