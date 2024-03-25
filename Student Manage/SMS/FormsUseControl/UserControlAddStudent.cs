using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            maskedTextBoxPhone.Text = "+00 000 0000000";
            maskedTextBoxPhone.ForeColor = Color.DarkGray;
            maskedTextBoxDate.Text = "00/00/0000";
            maskedTextBoxDate.ForeColor = Color.DarkGray;
            textBoxEmail.Text = "admin@email.com";
            textBoxEmail.ForeColor = Color.DarkGray;
            
        }
        private void Mask(MaskedTextBox txtBox)
        {
            BeginInvoke((MethodInvoker)delegate 
            {
                txtBox.Select(0, 0);
            });
        }
        private bool IsValideEmail(string email) 
        { 
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception)
            {
                return false;
            }

        }
        private bool IsValidDate(string date)
        {
            DateTime d;
            bool chValidity;
            try
            {
                return chValidity = DateTime.TryParseExact(date, "MM/dd/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None,out d);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void ClearTextBox1()
        {
            textBoxName1.Clear();
            comboBoxClass1.SelectedIndex = -1;
            textBoxRegNo1.Clear();
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            maskedTextBoxPhone1.Text = "+00 000 0000000";
            maskedTextBoxPhone1.ForeColor = Color.DarkGray;
            maskedTextBoxDate1.Text = "00/00/0000";
            maskedTextBoxDate1.ForeColor = Color.DarkGray;
            textBoxEmail1.Text = "admin@email.com";
            textBoxEmail1.ForeColor = Color.DarkGray;
            SID = "";
        }
        
        private void HideErrorPic()
        {
            pictureBoxErrorDate.Visible = false;
            pictureBoxErrorEmail.Visible = false;
            pictureBoxErrorPhone.Visible = false;
        }
        private void HideErrorPic1()
        {
            pictureBoxErrorDate1.Visible = false;
            pictureBoxErrorEmail1.Visible = false;
            pictureBoxErrorPhone1.Visible = false;
        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
           textBoxSearchStudent.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT *FROM Student_Table", dataGridViewStudent, sql);
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
            HideErrorPic();
            HideErrorPic1();
        }

        private void tabPageUPStudentAndDelete_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
            HideErrorPic1();
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
            if(textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || !maskedTextBoxPhone.MaskCompleted || maskedTextBoxPhone.Text == "+00 000 0000000"
                    || !IsValidDate(maskedTextBoxDate.Text) || maskedTextBoxDate.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDate.Text) > DateTime.Now || gender == string.Empty || !IsValideEmail(textBoxEmail.Text) || textBoxEmail.Text == "admin@gmail.com" || comboBoxClass.SelectedIndex == -1)
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
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID , Student_Name , Student_Reg , Student_Gender,Class_Name , Student_Phone,Student_BD,Student_Email FROM Student_Table INNER JOHN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Name LIKE '%" + textBoxSearchStudent.Text.Trim()+"%'",dataGridViewStudent,sql );
            }
            if (comboBoxSearchBy.SelectedIndex == 1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID , Student_Name , Student_Reg , Student_Gender,Class_Name, Student_Phone,Student_BD,Student_Email FROM Student_Table INNER JOHN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_RegNo LIKE '%" + textBoxSearchStudent.Text.Trim() + "%'", dataGridViewStudent, sql);
            }
            if (comboBoxSearchBy.SelectedIndex == 2)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID , Student_Name , Student_Reg , Student_Gender,Class_Name, Student_Phone,Student_BD,Student_Email FROM Student_Table INNER JOHN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name LIKE '%" + textBoxSearchStudent.Text.Trim() + "%'", dataGridViewStudent, sql);
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
                maskedTextBoxPhone1.Text = row.Cells["colum4"].Value.ToString();
                maskedTextBoxPhone1.ForeColor = Color.Black;
                maskedTextBoxDate1.Text = row.Cells["colum5"].Value.ToString();
                maskedTextBoxDate1.ForeColor = Color.Black;
                textBoxEmail1.Text = row.Cells["colum6"].Value.ToString();
                comboBoxClass1.Items.Clear();
                Attendance.Attendance.FillComboBox("SELECT DISTINCT (Class_Name) FROM Class_Table;", comboBoxClass1, sql);
                comboBoxClass1.SelectedItem = row.Cells["Colum7"].Value.ToString();
                if (row.Cells["Colum8"].Value.ToString() == "Male")
                {
                    radioButtonMale1.Checked = true;
                }
                if (row.Cells["Colum9"].Value.ToString() == "Female")
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
                if (textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || !maskedTextBoxPhone1.MaskCompleted || maskedTextBoxPhone1.Text == "+00 000 0000000"
                    || !IsValidDate(maskedTextBoxDate1.Text) || maskedTextBoxDate1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDate1.Text) > DateTime.Now || gender == string.Empty || !IsValideEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "admin@gmail.com" || comboBoxClass1.SelectedIndex == -1)
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

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "admin@email.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "admin@email.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
            if (!IsValideEmail(textBoxEmail.Text) || textBoxEmail.Text == "admin@email.com")
            {
                pictureBoxErrorEmail.Visible = true;
            }
            else
                pictureBoxErrorEmail.Visible = false;
        }

        private void maskedTextBoxPhone_Enter(object sender, EventArgs e)
        {
            if(maskedTextBoxPhone.Text == "+00 000 0000000")
            {
                maskedTextBoxPhone.Text = "";
            }
            if (!maskedTextBoxPhone.MaskCompleted)
            {
                maskedTextBoxPhone.ForeColor = Color.DarkGray;
                Mask(maskedTextBoxPhone);
            }
        }

        private void maskedTextBoxPhone_Leave(object sender, EventArgs e)
        {
            if(maskedTextBoxPhone.Text == "+")
            {
                maskedTextBoxPhone.Text = "+00 000 0000000";
                maskedTextBoxPhone.ForeColor= Color.DarkGray;
            }
            if(!maskedTextBoxPhone.MaskCompleted)
            {
                maskedTextBoxPhone.ForeColor = Color.DarkGray;
            }    
            if(!maskedTextBoxPhone.MaskCompleted || maskedTextBoxPhone.Text == "+00 000 0000000")
            {
                pictureBoxErrorPhone.Visible = true;
            }
            else
                pictureBoxErrorPhone.Visible = false;
        }

        private void maskedTextBoxDate_Enter(object sender, EventArgs e)
        {
            if(maskedTextBoxDate.Text == "00/00/0000")
            {
                maskedTextBoxDate.Text = "";
            }
            if (!maskedTextBoxDate.MaskCompleted)
            {
                maskedTextBoxDate.ForeColor = Color.DarkGray;
                Mask(maskedTextBoxDate);
            }
        }

        private void maskedTextBoxDate_Leave(object sender, EventArgs e)
        {
            if(maskedTextBoxDate.Text.Trim() == "/  /")
            {
                maskedTextBoxDate.Text = "00/00/0000";
                maskedTextBoxDate.ForeColor= Color.DarkGray;
            }
            if (!maskedTextBoxDate.MaskCompleted)
            {
                maskedTextBoxDate.ForeColor = Color.DarkGray;
            }if(!IsValidDate(maskedTextBoxDate.Text)|| maskedTextBoxDate.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDate.Text) > DateTime.Now)
            {
                pictureBoxErrorDate.Visible = true;
            }
            else 
                pictureBoxErrorDate.Visible = false;
        }

        private void maskedTextBoxPhone1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPhone1.Text == "+00 000 0000000")
            {
                maskedTextBoxPhone1.Text = "";
            }
            if (!maskedTextBoxPhone1.MaskCompleted)
            {
                maskedTextBoxPhone1.ForeColor = Color.DarkGray;
                Mask(maskedTextBoxPhone1);
            }
        }

        private void maskedTextBoxPhone1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPhone1.Text == "+")
            {
                maskedTextBoxPhone1.Text = "+00 000 0000000";
                maskedTextBoxPhone1.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxPhone1.MaskCompleted)
            {
                maskedTextBoxPhone1.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxPhone1.MaskCompleted || maskedTextBoxPhone1.Text == "+00 000 0000000")
            {
                pictureBoxErrorPhone1.Visible = true;
            }
            else
                pictureBoxErrorPhone1.Visible = false;
        }

        private void maskedTextBoxDate1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDate1.Text == "00/00/0000")
            {
                maskedTextBoxDate1.Text = "";
            }
            if (!maskedTextBoxDate1.MaskCompleted)
            {
                maskedTextBoxDate1.ForeColor = Color.DarkGray;
                Mask(maskedTextBoxDate);
            }
        }

        private void maskedTextBoxDate1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDate1.Text.Trim() == "/ /")
            {
                maskedTextBoxDate1.Text = "00/00/0000";
                maskedTextBoxDate1.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxDate1.MaskCompleted)
            {
                maskedTextBoxDate1.ForeColor = Color.DarkGray;
            }
            if (!IsValidDate(maskedTextBoxDate1.Text) || maskedTextBoxDate1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDate1.Text) > DateTime.Now)
            {
                pictureBoxErrorDate1.Visible = true;
            }
            else
                pictureBoxErrorDate1.Visible = false;
        }

        private void textBoxEmail1_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "admin@email.com")
            {
                textBoxEmail1.Text = "";
                textBoxEmail1.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxEmail1_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "")
            {
                textBoxEmail1.Text = "admin@email.com";
                textBoxEmail1.ForeColor = Color.DarkGray;
            }
            if (!IsValideEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "admin@email.com")
            {
                pictureBoxErrorEmail1.Visible = true;
            }
            else
                pictureBoxErrorEmail1.Visible = false;
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
                if (textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || !maskedTextBoxPhone1.MaskCompleted || maskedTextBoxPhone1.Text == "+00 000 0000000"
                    || !IsValidDate(maskedTextBoxDate1.Text) || maskedTextBoxDate1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDate1.Text) > DateTime.Now || gender == string.Empty || !IsValideEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "admin@gmail.com" || comboBoxClass1.SelectedIndex == -1)
                
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
