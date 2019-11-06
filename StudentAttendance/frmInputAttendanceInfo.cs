using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr.StudentAttendance
{
    public partial class frmInputAttendanceInfo : Form
    {
        // 定义存储数据的临时表
        private DataTable dt;

        private string currentSchoolYear = "";    // 当前学年
        private string currenSemester = "";       // 当前学期
        private string currentWeek = "";          // 当前周次
        private string currentWeekday = "";       // 当前星期
        private string currentSchoolTime = "";    // 当前节次
        private string currentCourseName = "";    // 当前课程名称
        
        public frmInputAttendanceInfo()
        {
            InitializeComponent();
        }

        // 填充课程名称组合框
        private void FillCourseNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select CourseId, CourseName from Courses order by CourseId asc";

                //创建数据集
                DataSet dsCourses = new DataSet("Attendance");

                //填充数据集
                dsCourses = DBHelper.getDataSet(selectSql, "Courses");

                //指定“课程名称组合框”的数据源
                this.cboCourseName.DataSource = dsCourses.Tables["Courses"];
                this.cboCourseName.DisplayMember = "CourseName";
                this.cboCourseName.ValueMember = "CourseId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 填充学生姓名组合框
        private void FillStuNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = String.Format("select s.StuId, s.StuName " +
                    "from CourseSchedules cs, Classes cls, Students s " +
                    "where cs.ClassId = cls.ClassId and cls.ClassId = s.ClassId and cs.TeacherId = '{0}' " + 
                    "and SchoolYear = '{1}' and Semester = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' " +
                    "and dbo.getNumWeek('{5}') >= dbo.getNumWeek(StartWeek) and dbo.getNumWeek('{6}') <= dbo.getNumWeek(EndWeek) " +
                    "order by s.StuId asc",
                    CommonInfo.userId, currentSchoolYear, currenSemester, currentWeekday, currentSchoolTime, currentWeek, currentWeek);

                //创建数据集
                DataSet dsStudents = new DataSet("Attendance");

                //填充数据集
                dsStudents = DBHelper.getDataSet(selectSql, "Students");

                //指定“学生名称组合框”的数据源
                this.cboStuName.DataSource = dsStudents.Tables["Students"];
                this.cboStuName.DisplayMember = "StuName";
                this.cboStuName.ValueMember = "StuId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 填充出勤状态组合框
        private void FillAttendanceStatusComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select StatusId, StatusName from AttendanceStatus order by StatusId asc";

                //创建数据集
                DataSet dsAttendanceStatus = new DataSet("Attendance");

                //填充数据集
                dsAttendanceStatus = DBHelper.getDataSet(selectSql, "AttendanceStatus");

                //指定“出勤状态组合框”的数据源
                this.cboAttendanceStatus.DataSource = dsAttendanceStatus.Tables["AttendanceStatus"];
                this.cboAttendanceStatus.DisplayMember = "StatusName";
                this.cboAttendanceStatus.ValueMember = "StatusId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空文本框
        private void ClearTextBox()
        {
            this.cboSchoolYear.Text = "";
            this.cboSemester.Text = "";
            this.cboWeek.Text = "";
            this.cboWeekday.Text = "";
            this.cboSchoolTime.Text = "";
            this.cboCourseName.Text = "";
            this.cboStuName.Text = "";
            this.cboAttendanceStatus.Text = "";
            this.txtMemo.Text = "";
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.cboSchoolYear.Enabled = false;
            this.cboSemester.Enabled = false;
            this.cboWeek.Enabled = false;
            this.cboWeekday.Enabled = false;
            this.cboSchoolTime.Enabled = false;
            this.cboCourseName.Enabled = false;
            this.cboStuName.Enabled = false;
            this.cboAttendanceStatus.Enabled = false;
            this.txtMemo.Enabled = false;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.cboSchoolYear.Enabled = true;
            this.cboSemester.Enabled = true;
            this.cboWeek.Enabled = true;
            this.cboWeekday.Enabled = true;
            this.cboSchoolTime.Enabled = true;
            this.cboCourseName.Enabled = true;
            this.cboStuName.Enabled = true;
            this.cboAttendanceStatus.Enabled = true;
            this.txtMemo.Enabled = true;
        }

        // 设置文本框的默认值
        private void InitTextBox()
        {
            this.cboSchoolYear.Text = this.currentSchoolYear;
            this.cboSemester.Text = this.currenSemester;
            this.cboWeek.Text = this.currentWeek;
            this.cboWeekday.Text = this.currentWeekday;
            this.cboSchoolTime.Text = this.currentSchoolTime;
            this.cboCourseName.Text = this.currentCourseName;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.cboSchoolYear.Text.Trim() == "")
            {
                MessageBox.Show("请输入学年", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSchoolYear.Focus();
                return false;
            }
            else if (this.cboSemester.Text.Trim() == "")
            {
                MessageBox.Show("请输入学期", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSemester.Focus();
                return false;
            }
            else if (this.cboWeek.Text.Trim() == "")
            {
                MessageBox.Show("请输入上课周次", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboWeek.Focus();
                return false;
            }
            else if (this.cboWeekday.Text.Trim() == "")
            {
                MessageBox.Show("请输入星期", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboWeekday.Focus();
                return false;
            }
            else if (this.cboSchoolTime.Text.Trim() == "")
            {
                MessageBox.Show("请输入节次", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSchoolTime.Focus();
                return false;
            }
            else if (this.cboCourseName.Text.Trim() == "")
            {
                MessageBox.Show("请输入课程名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboCourseName.Focus();
                return false;
            }
            else if (this.cboStuName.Text.Trim() == "")
            {
                MessageBox.Show("请输入学生姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStuName.Focus();
                return false;
            }
            else if (this.cboAttendanceStatus.Text.Trim() == "")
            {
                MessageBox.Show("请输入出勤状态", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboAttendanceStatus.Focus();
                return false;
            }

            //检查后台数据库的 StudentAttendances 表中是否存在重复的记录
            string selectSql = String.Format("select count(*) from StudentAttendances " +
                "where SchoolYear = '{0}' and Semester = '{1}' and Week = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' and StuId = '{5}'",
                this.cboSchoolYear.Text, this.cboSemester.Text, this.cboWeek.Text, this.cboWeekday.Text, this.cboSchoolTime.Text, this.cboStuName.SelectedValue);

            //执行查询操作
            int result = (int)DBHelper.executeScalar(selectSql);

            //如果记录已存在，则提示用户重新输入，并终止操作。
            if (result >= 1)
            {
                MessageBox.Show("该记录已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStuName.Focus();
                return false;
            }

            //检查临时表中是否存在重复的记录
            DataRow[] dataRowArray = null;

            dataRowArray = dt.Select(String.Format("SchoolYear = '{0}' and Semester = '{1}' and Week = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' and StuId = '{5}'", 
                this.cboSchoolYear.Text, this.cboSemester.Text, this.cboWeek.Text, this.cboWeekday.Text, this.cboSchoolTime.Text, this.cboStuName.SelectedValue));

            if (dataRowArray.Length >= 1)
            {
                MessageBox.Show("该记录已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStuName.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmInputAttendanceInfo_Load(object sender, EventArgs e)
        {
            // 获取当前学年
            currentSchoolYear = AttendanceHelper.getCurrentSchoolYear();

            // 获取当前学期
            currenSemester = AttendanceHelper.getCurrentSemester();

            // 获取当前周次
            currentWeek = AttendanceHelper.getCurrentWeek();

            // 获取当前星期
            currentWeekday = AttendanceHelper.getCurrentWeekday();

            // 获取当前节次
            currentSchoolTime = AttendanceHelper.getCurrentSchoolTime();

            // 获取当前课程名称
            currentCourseName = AttendanceHelper.getCurrentCourseName();
            
            // 初始化课程名称组合框
            this.FillCourseNameComboBox();

            // 初始化学生姓名组合框
            this.FillStuNameComboBox();

            // 初始化出勤状态组合框
            this.FillAttendanceStatusComboBox();

            try
            {
                // 创建存储数据的临时表
                dt = new DataTable("StudentAttendances");

                // 添加列
                dt.Columns.Add("SchoolYear", typeof(string));
                dt.Columns.Add("Semester", typeof(string));
                dt.Columns.Add("Week", typeof(string));
                dt.Columns.Add("Weekday", typeof(string));
                dt.Columns.Add("SchoolTime", typeof(string));
                dt.Columns.Add("CourseId", typeof(string));
                dt.Columns.Add("StuId", typeof(string));
                dt.Columns.Add("StatusId", typeof(string));
                dt.Columns.Add("Memo", typeof(string));

                this.btnNext.Enabled = false;   //禁用“下一条”按钮
                this.btnSave.Enabled = false;   //禁用“保存”按钮
                this.btnCancel.Enabled = false; //禁用“取消”按钮

                // 清空文本框
                this.ClearTextBox();

                // 设置文本框的默认值
                this.InitTextBox();

                // 锁定文本框
                this.LockedTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 录入
        private void btnInput_Click(object sender, EventArgs e)
        {
            // 清空临时表
            dt.Rows.Clear();

            //清空文本框
            this.ClearTextBox();

            // 设置文本框的默认值
            this.InitTextBox();

            //解除锁定
            this.UnLockedTextBox();

            this.btnInput.Enabled = false; //禁用“录入”按钮
            this.btnNext.Enabled = true;   //启用“下一条”按钮
            this.btnSave.Enabled = true;   //启用“保存”按钮
            this.btnCancel.Enabled = true; //启用“取消”按钮

            this.cboStuName.Focus();
        }

        // 下一条
        private void btnNext_Click(object sender, EventArgs e)
        {
            // 验证用户输入
            if (this.ValidateInput() == false)
            {
                return;
            }

            try
            {
                // 添加新行
                DataRow dr = dt.NewRow();
                dr["SchoolYear"] = this.cboSchoolYear.Text;
                dr["Semester"] = this.cboSemester.Text;
                dr["Week"] = this.cboWeek.Text;
                dr["Weekday"] = this.cboWeekday.Text;
                dr["SchoolTime"] = this.cboSchoolTime.Text;
                dr["CourseId"] = this.cboCourseName.SelectedValue;
                dr["StuId"] = this.cboStuName.SelectedValue;
                dr["StatusId"] = this.cboAttendanceStatus.SelectedValue;
                dr["Memo"] = this.txtMemo.Text;

                // 加入新行
                dt.Rows.Add(dr);

                //清空文本框
                this.ClearTextBox();

                // 设置文本框的默认值
                this.InitTextBox();

                this.cboCourseName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 验证用户输入
            if (this.ValidateInput() == false)
            {
                return;
            }

            try
            {
                // 在临时表中添加新行，以保存最后输入的一条记录。
                DataRow dr = dt.NewRow();
                dr["SchoolYear"] = this.cboSchoolYear.Text;
                dr["Semester"] = this.cboSemester.Text;
                dr["Week"] = this.cboWeek.Text;
                dr["Weekday"] = this.cboWeekday.Text;
                dr["SchoolTime"] = this.cboSchoolTime.Text;
                dr["CourseId"] = this.cboCourseName.SelectedValue;
                dr["StuId"] = this.cboStuName.SelectedValue;
                dr["StatusId"] = this.cboAttendanceStatus.SelectedValue;
                dr["Memo"] = this.txtMemo.Text;

                // 加入新行
                dt.Rows.Add(dr);

                int insertResult = 0;

                // 遍历临时表，取出临时表中的每一行，并保存到后台数据库中。
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //添加记录用的SQL语句
                    string insertSql = String.Format("insert into StudentAttendances (SchoolYear, Semester, Week, Weekday, SchoolTime, CourseId, StuId, StatusId, Memo) " +
                        "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}') ",
                        dt.Rows[i]["SchoolYear"].ToString(),
                        dt.Rows[i]["Semester"].ToString(),
                        dt.Rows[i]["Week"].ToString(),
                        dt.Rows[i]["Weekday"].ToString(),
                        dt.Rows[i]["SchoolTime"].ToString(),
                        dt.Rows[i]["CourseId"].ToString(),
                        dt.Rows[i]["StuId"].ToString(),
                        dt.Rows[i]["StatusId"].ToString(),
                        dt.Rows[i]["Memo"].ToString());

                    //执行添加操作
                    insertResult = DBHelper.executeInsertSql(insertSql);
                }

                if (insertResult >= 1)
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 清空临时表
                    dt.Rows.Clear();

                    //锁定文本框
                    this.LockedTextBox();

                    this.btnInput.Enabled = true;    //启用“录入”按钮
                    this.btnNext.Enabled = false;    //禁用“下一条”按钮
                    this.btnSave.Enabled = false;    //禁用“保存”按钮
                    this.btnCancel.Enabled = false;  //禁用“取消”按钮
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 清空临时表
            dt.Rows.Clear();

            //清空文本框
            this.ClearTextBox();

            //锁定文本框
            this.LockedTextBox();

            this.btnInput.Enabled = true;    //启用“录入”按钮
            this.btnNext.Enabled = false;    //禁用“下一条”按钮
            this.btnSave.Enabled = false;    //禁用“保存”按钮
            this.btnCancel.Enabled = false;  //禁用“取消”按钮
        }
    }
}