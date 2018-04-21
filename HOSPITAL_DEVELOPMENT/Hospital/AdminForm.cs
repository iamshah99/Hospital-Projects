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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginPage formLoginPageObject = new FormLoginPage();
            formLoginPageObject.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void labelNewEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEmployeeForm obj1 = new NewEmployeeForm();
            obj1.Show();

        }
    }
}
