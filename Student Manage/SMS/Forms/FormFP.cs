using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manage.SMS.Forms
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private bool IsvalidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;

            }
            catch
            {
                return false;
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (IsvalidEmail(textBoxEmail.Text))
            {
                //string userName = Attendance.Attendance.GetUsernamePassword();  them sql
                //string passWord = Attendance.Attendance.GetUsernamePassword();  them sql
                //MessageBox.Show("Your Username is " + userName + " and Password is" + password +"." ,"information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxClose_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("tho gay ");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == "daodat@gmail.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }
            if (IsvalidEmail(textBoxEmail.Text) || textBoxEmail.Text == "daodat@gmail.com")
            {
                pictureBoxError.Show();
            }
            else
            {
                pictureBoxError.Hide();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == String.Empty)
            {
                textBoxEmail.Text = "daodat@gmail.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
            if (IsvalidEmail(textBoxEmail.Text) || textBoxEmail.Text == "daodat@gmail.com")
            {
                pictureBoxError.Show();
            }
            else
            {
                pictureBoxError.Hide();
            }
        }

        private void pictureBoxError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxError, "Ivalid Email!");
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
