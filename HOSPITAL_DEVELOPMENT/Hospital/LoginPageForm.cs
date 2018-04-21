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
    public partial class FormLoginPage : Form
    {
        public FormLoginPage()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = "Iamshah";
            string password = "password";

            textBoxUserName.Focus();
            if (textBoxUserName.Text == userName && textBoxPassword.Text==password)
            {
                if (radioButtonAdmin.Checked != true && radioButtonDeskEmployee.Checked != true && radioButtonDoctor.Checked != true)
                {
                    string msg = "Please, ";
                    msg += "Select Employee Type to preocced";
                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    buttonLogin.Focus();
                    if (radioButtonAdmin.Checked == true)
                    {
                        this.Hide();
                        AdminForm adminObject = new AdminForm();
                        adminObject.Show();
                    }
                    else if (radioButtonDeskEmployee.Checked == true)
                    {
                        this.Hide();
                        DeskEmployeeForm obj = new DeskEmployeeForm();
                        obj.Show();


                    }
                    else if (radioButtonDoctor.Checked == true)
                    {
                        this.Hide();
                        DoctorForm obj = new DoctorForm();
                        obj.Show();

                    }
                }
            }
            else
                MessageBox.Show("Invalid Username or Passord","Invalid User",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
        }

        private void FormLoginPage_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Today.ToString("MM/dd/yyyy");
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
