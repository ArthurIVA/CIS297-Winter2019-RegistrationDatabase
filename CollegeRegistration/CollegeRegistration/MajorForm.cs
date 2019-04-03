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
        }

        private void MajorForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
