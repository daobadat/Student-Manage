using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Manage.SMS.FormsUseControl
{
    public partial class UserControlAddStudent : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                              Initial Catalog = Attendance_Management_System;
                                Integrate Security = True ; ";
        private string SID = "";
        public UserControlAddStudent()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            textBoxName.Clear();
            comboBoxClass.SelectedIndex = -1;
            textBoxRegNo.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            TabControlAddStudent.SelectedTab = tabPageAddStudent;
        }
        public void ClearTextBox1()
        {
            textBoxName1.Clear();
            comboBoxClass1.SelectedIndex = -1;
            textBoxRegNo1.Clear();
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            SID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHMStudent_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNữ_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNam_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
           textBoxSearchStudent.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            //thieu database 15:15
        }

        private void tabPageAddStudent_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void tabPageUPStudentAndDelete_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }
    }
}
