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
    public partial class UserControlDashBoard : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS;
                              Initial Catalog = Attendance_Management_System;
                                Integrate Security = True ; ";
        public UserControlDashBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
