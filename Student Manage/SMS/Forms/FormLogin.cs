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

namespace Student_Manage.SMS.Forms
{
    public partial class FormLogin : Form
    {
        //private string sql=
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formFP = new FormForgotPassword();
            formFP.ShowDialog();
        }
        
        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            
            if(textBoxPassword.PasswordChar == '*')
            {
                pictureBoxShow.Hide();
                pictureBoxHide.Show();
                textBoxPassword.PasswordChar = '\0';
            }
             

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string check = "";
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

            if (textBoxPassword.PasswordChar == '\0')
            {
                pictureBoxShow.Hide();
                pictureBoxHide.Show();
                textBoxPassword.PasswordChar = '*';
            }


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

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
