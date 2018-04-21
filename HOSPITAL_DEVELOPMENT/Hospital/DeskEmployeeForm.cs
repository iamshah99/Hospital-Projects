using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Hospital
{
    public partial class DeskEmployeeForm : Form
    {

        public class Doctor
        {
            public string doctorName;
            public byte roomNumber;                
        }
        public static List<Doctor> listDoctor = new List<Doctor>();//To Store the Beverage data in list.
        public DeskEmployeeForm()
        {
            InitializeComponent();
            textBoxPhone.MaxLength = 10;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoginPage formLoginPageObject = new FormLoginPage();
            formLoginPageObject.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxPatientName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter The Patient Name");
                textBoxPatientName.Focus();
                return;                
            }
            if (comboBoxMonth.SelectedIndex == -1)
            {

                MessageBox.Show("Please Select Month from th List", "Error", MessageBoxButtons.OK);
                comboBoxMonth.Focus();
                return;
            }
            if (comboBoxDay.SelectedIndex == -1)
            {

                MessageBox.Show("Please Select Day from th List", "Error", MessageBoxButtons.OK);
                comboBoxDay.Focus();
                return;

            }
            if (comboBoxYear.SelectedIndex == -1)
            {

                MessageBox.Show("Please Select Year from th List", "Error", MessageBoxButtons.OK);
                comboBoxYear.Focus();
                return;
            }
            
            
            else
            {
                this.Close();                
            }
            //***********************************************Phone-Number Validation***************************************
            
            
                Regex validator = new Regex("(2|3|4|5|6|7|8|9){1}[0-9]{9}");
                string match = validator.Match(textBoxPhone.Text).Value.ToString();
                if (match.Length != 10)
                {
                    MessageBox.Show("Please Type Phone Number into Digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPhone.Focus();
                }
            
            //****************************************************************************************************************
            
            DialogResult dialouge = MessageBox.Show("New Patient??", "Done Sucessfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialouge == DialogResult.OK)
            {
                this.Hide();
                DeskEmployeeForm obj = new DeskEmployeeForm();
                obj.Show();
            }
            if(dialouge==DialogResult.No)
            {

            }
        }

        private void DeskEmployeeForm_Load(object sender, EventArgs e)
        {
            StreamReader streamDoctor = new StreamReader("../../Data/Doctors.dat");
            string line;
            string[] arrFields = new string[2];
            while(streamDoctor.Peek() > -1)
            {
                line = streamDoctor.ReadLine();
                arrFields = line.Split(',');
                Doctor objDoctor = new Doctor();
                objDoctor.doctorName = arrFields[0].Trim();
                objDoctor.roomNumber = Convert.ToByte(arrFields[1].Trim());
                listDoctor.Add(objDoctor);
                foreach (Doctor obj in listDoctor)
                {
                    comboBoxDoctor.Items.Add(obj.doctorName.ToString());
                }
            }
        }
        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string docotrItems = comboBoxDoctor.Text;
            int idx = 0;
            idx = listDoctor.FindIndex(x => x.doctorName.Contains(docotrItems));            
            textBoxRoomNumber.Text = listDoctor[idx].roomNumber.ToString();            
        }
    }
}