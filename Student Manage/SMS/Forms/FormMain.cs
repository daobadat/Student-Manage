using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manage.SMS.Forms
{
    public partial class FormMain : Form
    {
        public string Username, Role;
        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất?","Đăng xuất",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else panelExpand.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;
            if(Role == "User")
            {
                buttonDashboard.Hide();
                buttonAddClass.Hide();
                buttonAddStudent.Hide();
                buttonRegister.Hide();
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlDashBoard1.Count();
            userControlDashBoard1.Visible = true;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlDashBoard1.Visible = false;
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControlDashBoard1.Visible = false;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {

            MoveSidePanel(buttonAddStudent);
            userControlDashBoard1.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlDashBoard1.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlDashBoard1.Visible = false;
        }

        private void userControlDashBoard1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if(panelExpand.Visible) panelExpand.Visible = false;
            else panelExpand.Visible = true;
        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y-180);
        }
    }
}
