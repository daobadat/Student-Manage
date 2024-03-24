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
        private string sql = @"Data Source = DESKTOP-A98QJSC;
                          Initial Catalog = Student_Management_System;
                           Integrated Security = True;";
        private string SID = "",gender = "";
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
            Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID , Student_Name , Student_Reg , Student_Gender,Class_Name FROM Student_Table INNER JOHN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID;", dataGridViewStudent, sql);
            dataGridViewStudent.Columns[0].Visible = false;
            labelCountStudent.Text = dataGridViewStudent.Rows.Count.ToString();
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

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT (Class_Name) FROM Class_Table;", comboBoxClass,sql);

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if(radioButtonMale.Checked)
            {
                gender = "Male";
            }
            if (radioButtonFemale.Checked) 
            {
                gender = "Female";
            }
            if(textBoxName.Text.Trim() == string.Empty || textBoxRegNo.Text.Trim() == string.Empty || comboBoxClass.SelectedIndex == -1 )
            {
                MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.Attendance.AddStudent(textBoxName.Text.Trim(), textBoxRegNo.Text.Trim(),comboBoxClass.ToString(),gender,sql);
                if (check)
                {
                    ClearTextBox();
                }
            }
        }

        private void textBoxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID , Student_Name , Student_Reg , Student_Gender,Class_Name FROM Student_Table INNER JOHN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Name LIKE '%"+ textBoxSearchStudent.Text.Trim()+"%'",dataGridViewStudent,sql );
            }
            if (comboBoxSearchBy.SelectedIndex == 1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID , Student_Name , Student_Reg , Student_Gender,Class_Name FROM Student_Table INNER JOHN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_RegNo LIKE '%" + textBoxSearchStudent.Text.Trim() + "%'", dataGridViewStudent, sql);
            }
            if (comboBoxSearchBy.SelectedIndex == 2)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID , Student_Name , Student_Reg , Student_Gender,Class_Name FROM Student_Table INNER JOHN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name LIKE '%" + textBoxSearchStudent.Text.Trim() + "%'", dataGridViewStudent, sql);
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != 1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                SID = row.Cells["Colum1"].Value.ToString();
                textBoxName1.Text = row.Cells["Colum2"].Value.ToString();
                textBoxRegNo1.Text = row.Cells["Colum3"].Value.ToString();
                comboBoxClass1.Items.Clear();
                Attendance.Attendance.FillComboBox("SELECT DISTINCT (Class_Name) FROM Class_Table;", comboBoxClass1, sql);
                comboBoxClass1.SelectedItem = row.Cells["Colum4"].Value.ToString();
                if (row.Cells["Colum5"].Value.ToString() == "Male")
                {
                    radioButtonMale1.Checked = true;
                }
                if (row.Cells["Colum6"].Value.ToString() == "Female")
                {
                    radioButtonFemale1.Checked = true;
                }
            }
        }

        private void buttonUPClass_Click(object sender, EventArgs e)
        {
            if(SID != " ")
            {
                
                if (radioButtonMale1.Checked)
                {
                    gender = "Male";
                }
                if (radioButtonFemale1.Checked)
                {
                    gender = "Female";
                }
                if (textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || comboBoxClass1.SelectedIndex == -1)
                {
                    MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMale1.Checked == false && radioButtonFemale1.Checked == false)
                {
                    MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateStudent(SID,textBoxName1.Text.Trim(), textBoxRegNo1.Text.Trim(), comboBoxClass1.ToString(), gender, sql);
                    if (check)
                    {
                        ClearTextBox1();
                    }
                    else
                        MessageBox.Show("Fisrt select row from table. ", "select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SID != " ")
            {
                
                if (radioButtonMale1.Checked)
                {
                    gender = "Male";
                }
                if (radioButtonFemale1.Checked)
                {
                    gender = "Female";
                }
                if (textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || comboBoxClass1.SelectedIndex == -1)
                {
                    MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMale1.Checked == false && radioButtonFemale1.Checked == false)
                {
                    MessageBox.Show("Fisrt fill out all fields. ", "Required all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you want to delete student?", "delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteStudent(SID, sql);

                        if (check)
                            ClearTextBox1();
                    }
                    else
                        MessageBox.Show("Fisrt select row from table. ", "select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
