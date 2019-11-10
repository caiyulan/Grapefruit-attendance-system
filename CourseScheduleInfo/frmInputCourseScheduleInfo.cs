using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr.CourseScheduleInfo
{
    public partial class frmInputCourseScheduleInfo : Form
    {
        // 定义存储数据的临时表
        private DataTable dt;
        
        public frmInputCourseScheduleInfo()
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

        // 填充上课教师组合框
        private void FillTeacherNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select TeacherId, TeacherName from Teachers order by TeacherId asc";

                //创建数据集
                DataSet dsTeachers = new DataSet("Attendance");

                //填充数据集
                dsTeachers = DBHelper.getDataSet(selectSql, "Teachers");

                //指定“上课教师组合框”的数据源
                this.cboTeacherName.DataSource = dsTeachers.Tables["Teachers"];
                this.cboTeacherName.DisplayMember = "TeacherName";
                this.cboTeacherName.ValueMember = "TeacherId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 填充上课班级组合框
        private void FillClassNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select ClassId, ClassName from Classes order by ClassId asc";

                //创建数据集
                DataSet dsClasses = new DataSet("Attendance");

                //填充数据集
                dsClasses = DBHelper.getDataSet(selectSql, "Classes");

                //指定“上课班级组合框”的数据源
                this.cboClassName.DataSource = dsClasses.Tables["Classes"];
                this.cboClassName.DisplayMember = "ClassName";
                this.cboClassName.ValueMember = "ClassId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 填充上课地点组合框
        private void FillRoomNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select RoomId, RoomName from ClassRooms order by RoomId asc";

                //创建数据集
                DataSet dsClassRooms = new DataSet("Attendance");

                //填充数据集
                dsClassRooms = DBHelper.getDataSet(selectSql, "ClassRooms");

                //指定“上课班级组合框”的数据源
                this.cboRoomName.DataSource = dsClassRooms.Tables["ClassRooms"];
                this.cboRoomName.DisplayMember = "RoomName";
                this.cboRoomName.ValueMember = "RoomId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空文本框
        private void ClearTextBox()
        {
            this.cboCourseName.Text = "";
            this.cboTeacherName.Text = "";
            this.cboClassName.Text = "";
            this.cboRoomName.Text = "";
            this.cboSchoolYear.Text = "";
            this.cboSemester.Text = "";
            this.cboWeekday.Text = "";
            this.cboSchoolTime.Text = "";
            this.cboStartWeek.Text = "";
            this.cboEndWeek.Text = "";
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.cboCourseName.Enabled = false;
            this.cboTeacherName.Enabled = false;
            this.cboClassName.Enabled = false;
            this.cboRoomName.Enabled = false;
            this.cboSchoolYear.Enabled = false;
            this.cboSemester.Enabled = false;
            this.cboWeekday.Enabled = false;
            this.cboSchoolTime.Enabled = false;
            this.cboStartWeek.Enabled = false;
            this.cboEndWeek.Enabled = false;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.cboCourseName.Enabled = true;
            this.cboTeacherName.Enabled = true;
            this.cboClassName.Enabled = true;
            this.cboRoomName.Enabled = true;
            this.cboSchoolYear.Enabled = true;
            this.cboSemester.Enabled = true;
            this.cboWeekday.Enabled = true;
            this.cboSchoolTime.Enabled = true;
            this.cboStartWeek.Enabled = true;
            this.cboEndWeek.Enabled = true;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.cboCourseName.Text.Trim() == "")
            {
                MessageBox.Show("请输入课程名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboCourseName.Focus();
                return false;
            }
            else if (this.cboTeacherName.Text.Trim() == "")
            {
                MessageBox.Show("请输入上课教师", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboTeacherName.Focus();
                return false;
            }
            else if (this.cboClassName.Text.Trim() == "")
            {
                MessageBox.Show("请输入上课班级", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboClassName.Focus();
                return false;
            }
            else if (this.cboRoomName.Text.Trim() == "")
            {
                MessageBox.Show("请输入上课地点", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboRoomName.Focus();
                return false;
            }
            else if (this.cboSchoolYear.Text.Trim() == "")
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
            else if (this.cboStartWeek.Text.Trim() == "")
            {
                MessageBox.Show("请输入起始周", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStartWeek.Focus();
                return false;
            }
            else if (this.cboEndWeek.Text.Trim() == "")
            {
                MessageBox.Show("请输入结束周", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboEndWeek.Focus();
                return false;
            }

            //检查后台数据库的 CourseSchedules 表中是否存在重复的记录
            string selectSql = String.Format("select count(*) from CourseSchedules " +
                "where TeacherId = '{0}' and SchoolYear = '{1}' and Semester = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' and dbo.getNumWeek(EndWeek) >= dbo.getNumWeek('{5}')",
                this.cboTeacherName.SelectedValue, this.cboSchoolYear.Text, this.cboSemester.Text, this.cboWeekday.Text, this.cboSchoolTime.Text, this.cboStartWeek.Text);

            //执行查询操作
            int result = (int)DBHelper.executeScalar(selectSql);

            //如果记录已存在，则提示用户重新输入，并终止操作。
            if (result >= 1)
            {
                MessageBox.Show("该记录已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboCourseName.Focus();
                return false;
            }

            //检查临时表中是否存在重复的记录
            DataRow[] dataRowArray = null;

            dataRowArray = dt.Select(String.Format("TeacherId = '{0}' and SchoolYear = '{1}' and Semester = '{2}' and Weekday = '{3}' and SchoolTime = '{4}'",
                this.cboTeacherName.SelectedValue, this.cboSchoolYear.Text, this.cboSemester.Text, this.cboWeekday.Text, this.cboSchoolTime.Text));

            if (dataRowArray.Length >= 1)
            {
                MessageBox.Show("该记录已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboCourseName.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmInputCourseScheduleInfo_Load(object sender, EventArgs e)
        {
            // 初始化课程名称组合框
            this.FillCourseNameComboBox();

            // 初始化上课教师组合框
            this.FillTeacherNameComboBox();

            // 初始化上课班级组合框
            this.FillClassNameComboBox();

            // 初始化上课地点组合框
            this.FillRoomNameComboBox();

            try
            {
                // 创建存储数据的临时表
                dt = new DataTable("CourseSchedules");

                // 添加列
                dt.Columns.Add("CourseId", typeof(string));
                dt.Columns.Add("TeacherId", typeof(string));
                dt.Columns.Add("ClassId", typeof(string));
                dt.Columns.Add("RoomId", typeof(string));
                dt.Columns.Add("SchoolYear", typeof(string));
                dt.Columns.Add("Semester", typeof(string));
                dt.Columns.Add("Weekday", typeof(string));
                dt.Columns.Add("SchoolTime", typeof(string));
                dt.Columns.Add("StartWeek", typeof(string));
                dt.Columns.Add("EndWeek", typeof(string));

                this.btnNext.Enabled = false;   //禁用“下一条”按钮
                this.btnSave.Enabled = false;   //禁用“保存”按钮
                this.btnCancel.Enabled = false; //禁用“取消”按钮

                // 清空文本框
                this.ClearTextBox();

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

            //解除锁定
            this.UnLockedTextBox();

            this.btnInput.Enabled = false; //禁用“录入”按钮
            this.btnNext.Enabled = true;   //启用“下一条”按钮
            this.btnSave.Enabled = true;   //启用“保存”按钮
            this.btnCancel.Enabled = true; //启用“取消”按钮

            this.cboCourseName.Focus();
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
                dr["CourseId"] = this.cboCourseName.SelectedValue;
                dr["TeacherId"] = this.cboTeacherName.SelectedValue;
                dr["ClassId"] = this.cboClassName.SelectedValue;
                dr["RoomId"] = this.cboRoomName.SelectedValue;
                dr["SchoolYear"] = this.cboSchoolYear.Text;
                dr["Semester"] = this.cboSemester.Text;
                dr["Weekday"] = this.cboWeekday.Text;
                dr["SchoolTime"] = this.cboSchoolTime.Text;
                dr["StartWeek"] = this.cboStartWeek.Text;
                dr["EndWeek"] = this.cboEndWeek.Text;

                // 加入新行
                dt.Rows.Add(dr);

                //清空文本框
                this.ClearTextBox();

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
                dr["CourseId"] = this.cboCourseName.SelectedValue;
                dr["TeacherId"] = this.cboTeacherName.SelectedValue;
                dr["ClassId"] = this.cboClassName.SelectedValue;
                dr["RoomId"] = this.cboRoomName.SelectedValue;
                dr["SchoolYear"] = this.cboSchoolYear.Text;
                dr["Semester"] = this.cboSemester.Text;
                dr["Weekday"] = this.cboWeekday.Text;
                dr["SchoolTime"] = this.cboSchoolTime.Text;
                dr["StartWeek"] = this.cboStartWeek.Text;
                dr["EndWeek"] = this.cboEndWeek.Text;

                // 加入新行
                dt.Rows.Add(dr);

                int insertResult = 0;
                
                // 遍历临时表，取出临时表中的每一行，并保存到后台数据库中。
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //添加记录用的SQL语句
                    string insertSql = String.Format("insert into CourseSchedules (CourseId, TeacherId, ClassId, RoomId, SchoolYear, Semester, Weekday, SchoolTime, StartWeek, EndWeek) " +
                        "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}') ",
                        dt.Rows[i]["CourseId"].ToString(),
                        dt.Rows[i]["TeacherId"].ToString(),
                        dt.Rows[i]["ClassId"].ToString(),
                        dt.Rows[i]["RoomId"].ToString(),
                        dt.Rows[i]["SchoolYear"].ToString(),
                        dt.Rows[i]["Semester"].ToString(),
                        dt.Rows[i]["Weekday"].ToString(),
                        dt.Rows[i]["SchoolTime"].ToString(),
                        dt.Rows[i]["StartWeek"].ToString(),
                        dt.Rows[i]["EndWeek"].ToString());

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