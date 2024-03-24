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
        //DESKTOP-A98QJSC
        //DESKTOP-4E2MKDI\MSSQLSERVER01
        private string sql = @"Data Source = DESKTOP-A98QJSC;
                             Initial Catalog = Student_Management_System;
                             Integrated Security = True;";
        private string CID = "";
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
        private void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxNu1.Clear();
            textBoxHMStudent1.Clear();
            textBoxNam1.Clear();
            CID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == string.Empty || textBoxHMStudent.Text.Trim() == string.Empty || textBoxNam.Text.Trim() == string.Empty || textBoxNữ.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fisrt fill out all fields. " , "Required all fields" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.Attendance.AddClass(textBoxName.Text.Trim(), textBoxHMStudent.Text.Trim(), textBoxNam.Text.Trim(), textBoxNữ.Text.Trim(), sql);

                if (check)
                    ClearTextBox();
            }
        }

        private void tabPageUPClassAndDelete_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            textBoxSearchClass.Clear();
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table;", dataGridViewClass, sql);
            dataGridViewClass.Columns[0].Visible = false;
            labelCountClass.Text = dataGridViewClass.Rows.Count.ToString();

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

        private void textBoxSearchClass_TextChanged(object sender, EventArgs e)
        {
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE class_name LIKE '%" + textBoxSearchClass.Text + "%';" ,dataGridViewClass, sql); 

        }

        private void buttonUPClass_Click(object sender, EventArgs e)
        {
            if(CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHMStudent1.Text.Trim() == string.Empty || textBoxNam1.Text.Trim() == string.Empty || textBoxNu1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateClass(CID,textBoxName1.Text.Trim(), textBoxHMStudent1.Text.Trim(), textBoxNam1.Text.Trim(), textBoxNu1.Text.Trim(), sql);

                    if (check)
                        ClearTextBox1();
                }
            }
            else
            {
                MessageBox.Show("Fisrt select row form table. ", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHMStudent1.Text.Trim() == string.Empty || textBoxNam1.Text.Trim() == string.Empty || textBoxNu1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you want to delete class>?","Delete class", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteClass(CID, sql);

                        if (check)
                            ClearTextBox1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Fisrt select row form table. ", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxHMStudent1.Text = row.Cells[2].Value.ToString();
                textBoxNam1.Text = row.Cells[3].Value.ToString();
                textBoxNu1.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
