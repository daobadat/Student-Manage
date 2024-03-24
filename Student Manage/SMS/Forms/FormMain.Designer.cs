namespace Student_Manage.SMS.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelExpand = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.userControlAddClass2 = new Student_Manage.SMS.FormsUseControl.UserControlAddClass();
            this.userControlDashBoard2 = new Student_Manage.SMS.FormsUseControl.UserControlDashBoard();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.buttonAddStudent);
            this.panel1.Controls.Add(this.buttonAddClass);
            this.panel1.Controls.Add(this.buttonAttendance);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 900);
            this.panel1.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Image = global::Student_Manage.Properties.Resources.icons8_setting_30;
            this.buttonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.Location = new System.Drawing.Point(8, 415);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(250, 47);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "           Đăng kí";
            this.buttonRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Image = global::Student_Manage.Properties.Resources.icons8_ereader_30__1_;
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(8, 368);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(250, 47);
            this.buttonReport.TabIndex = 6;
            this.buttonReport.Text = "           Phản hồi";
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddStudent.Image = global::Student_Manage.Properties.Resources.icons8_add_user_group_woman_man_30__2_;
            this.buttonAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStudent.Location = new System.Drawing.Point(8, 321);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(250, 47);
            this.buttonAddStudent.TabIndex = 5;
            this.buttonAddStudent.Text = "           Thêm sinh viên";
            this.buttonAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddClass.FlatAppearance.BorderSize = 0;
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.ForeColor = System.Drawing.Color.White;
            this.buttonAddClass.Image = global::Student_Manage.Properties.Resources.icons8_classroom_30;
            this.buttonAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddClass.Location = new System.Drawing.Point(8, 274);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(250, 47);
            this.buttonAddClass.TabIndex = 4;
            this.buttonAddClass.Text = "           Thêm lớp";
            this.buttonAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddClass.UseVisualStyleBackColor = true;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.ForeColor = System.Drawing.Color.White;
            this.buttonAttendance.Image = global::Student_Manage.Properties.Resources.icons8_attendance_30;
            this.buttonAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.Location = new System.Drawing.Point(8, 227);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(250, 47);
            this.buttonAttendance.TabIndex = 3;
            this.buttonAttendance.Text = "           Điểm danh";
            this.buttonAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::Student_Manage.Properties.Resources.icons8_computer_30;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(8, 180);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(250, 47);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "           Trang chủ";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 720);
            this.panel4.TabIndex = 1;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(8, 47);
            this.panelSlide.TabIndex = 0;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 180);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ thống quản lý sinh viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Manage.Properties.Resources.icons8_student_male_64;
            this.pictureBox1.Location = new System.Drawing.Point(95, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.panelExpand);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Controls.Add(this.pictureBoxExpand);
            this.panelBack.Controls.Add(this.pictureBox2);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(258, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1316, 165);
            this.panelBack.TabIndex = 1;
            // 
            // panelExpand
            // 
            this.panelExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelExpand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpand.Controls.Add(this.buttonLogout);
            this.panelExpand.Controls.Add(this.buttonMinimize);
            this.panelExpand.Controls.Add(this.panel3);
            this.panelExpand.Location = new System.Drawing.Point(1041, 58);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(200, 107);
            this.panelExpand.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonLogout.Image = global::Student_Manage.Properties.Resources.icons8_log_out_30;
            this.buttonLogout.Location = new System.Drawing.Point(0, 53);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(198, 48);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "   Đăng xuất";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.White;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMinimize.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonMinimize.Image = global::Student_Manage.Properties.Resources.icons8_minimize_30__1_;
            this.buttonMinimize.Location = new System.Drawing.Point(0, 5);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(198, 48);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "   Thu nhỏ";
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 5);
            this.panel3.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(36, 40);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(29, 19);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "{?}";
            this.labelTime.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBoxExpand
            // 
            this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpand.Image = global::Student_Manage.Properties.Resources.icons8_drop_down_30;
            this.pictureBoxExpand.Location = new System.Drawing.Point(1107, 29);
            this.pictureBoxExpand.Name = "pictureBoxExpand";
            this.pictureBoxExpand.Size = new System.Drawing.Size(27, 24);
            this.pictureBoxExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExpand.TabIndex = 2;
            this.pictureBoxExpand.TabStop = false;
            this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBoxExpand_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Student_Manage.Properties.Resources.student_man_avatar_user_toga_school_university_icon_209294;
            this.pictureBox2.Location = new System.Drawing.Point(1041, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTop.Location = new System.Drawing.Point(0, 65);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1316, 100);
            this.panelTop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vai trò: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chào mừng: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(177, 51);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 19);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "{?}";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(177, 19);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(29, 19);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "{?}";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // userControlAddClass2
            // 
            this.userControlAddClass2.BackColor = System.Drawing.Color.White;
            this.userControlAddClass2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddClass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAddClass2.Location = new System.Drawing.Point(258, 165);
            this.userControlAddClass2.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAddClass2.Name = "userControlAddClass2";
            this.userControlAddClass2.Size = new System.Drawing.Size(1316, 735);
            this.userControlAddClass2.TabIndex = 3;
            this.userControlAddClass2.Visible = false;
            // 
            // userControlDashBoard2
            // 
            this.userControlDashBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashBoard2.Location = new System.Drawing.Point(258, 165);
            this.userControlDashBoard2.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashBoard2.Name = "userControlDashBoard2";
            this.userControlDashBoard2.Size = new System.Drawing.Size(1316, 735);
            this.userControlDashBoard2.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1574, 900);
            this.Controls.Add(this.userControlAddClass2);
            this.Controls.Add(this.userControlDashBoard2);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelExpand;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Timer timerDateAndTime;
        
        private FormsUseControl.UserControlDashBoard userControlDashBoard2;
        private FormsUseControl.UserControlAddClass userControlAddClass2;
    }
}