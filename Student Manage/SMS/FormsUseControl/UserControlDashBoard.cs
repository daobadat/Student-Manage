using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Student_Manage.SMS.FormsUseControl
{
    public partial class UserControlDashBoard : UserControl
    {
        //DESKTOP-A98QJSC
        private string sql = @"Data Source = DESKTOP-4E2MKDI\MSSQLSERVER01;
                             Initial Catalog = Student_Management_System;
                             Integrated Security = True;";
        public UserControlDashBoard()
        {
            InitializeComponent();
        }


        public void Count()
        {
            labelTotalClasses.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Class_Table",sql).ToString();
        }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
