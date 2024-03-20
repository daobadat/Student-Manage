using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Student_Manage.SMS.Forms
{
    public partial class FormLogin : Form
    {
        private string sql= @"Data Source = DESKTOP-A98QJSC;
                             Initial Catalog = Student_Management_System;
                             Integrated Security = True;";
        public FormLogin()
        {
            InitializeComponent();
        }
    
        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formFP = new FormForgotPassword();
            formFP.ShowDialog();
        }
        
        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
            pictureBoxShow.Hide();
             

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string check = Attendance.Attendance.IsValidNamePass(textBoxUserName.Text.Trim(),textBoxPassword.Text.Trim(),sql);
            if(textBoxUserName.Text.Trim() != string.Empty && textBoxPassword.Text.Trim() != string.Empty)
            {
                if(check != "" ){
                    FormMain formMain = new FormMain();
                   formMain.Username = textBoxUserName.Text;
                    formMain.Role = check;   
                    textBoxUserName.Clear();
                    textBoxPassword.Clear();
                    pictureBoxHide_Click(sender, e);
                    textBoxUserName.Focus();
                    pictureBoxError.Hide();
                    labelError.Hide();
                    formMain.ShowDialog();
                }
                else
                {
                    pictureBoxError.Show();
                    labelError.Show();
                }
            }
                
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
            
        }
        private void pictureBoxHide_MouseHover(object sender, EventArgs e )
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");
            
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {

            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();


        }
        private void FormLogin_load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
            pictureBoxHide.Hide();
            labelError.Hide();

        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");
            
        }

        private void textBoxUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled= true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }


        private void pictureBoxMinisize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMinisize, "Minimsize");
        }
    }
}
