using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginPage formLoginPageObject = new FormLoginPage();
            formLoginPageObject.Show();

        }
    }
}
