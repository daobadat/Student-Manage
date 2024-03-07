using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manage.SMS.FormsUseControl
{
    public partial class UserControlAddClass : UserControl
    {
        public UserControlAddClass()
        {
            InitializeComponent();
        }
        private void IntegerType(KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||(e.KeyChar == (char)Keys.Back))) 
            {
                e.Handled = true;
            }
        }
        private string CID = "";
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }
        
        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxNữ.Clear();
            textBoxHMStudent.Clear();
            textBoxNam.Clear();
            TabControlAddClass.SelectedTab = tabPageAddClass;
        }
        public void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxNu1.Clear();
            textBoxHMStudent1.Clear();
            textBoxNam1.Clear();
            CID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUPClassAndDelete_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            textBoxSearchClass.Clear();
            //thieu database phut28:22

        }

        private void TabControlAddClass_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void TabControlAddClass_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void textBoxHMStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxNữ_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxHMStudent1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxNu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxNam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }
    }
}
