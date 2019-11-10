using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;
using StudentAttendanceMgr.StudentAttendance;

namespace StudentAttendanceMgr.TeacherService
{
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();

        }

        // 定义存储数据的临时表
        private DataTable dta;

        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;

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
                this.comboBox1.DataSource = dsCourses.Tables["Courses"];
                this.comboBox1.DisplayMember = "CourseName";
                this.comboBox1.ValueMember = "CourseId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillClassComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = string.Format("select ClassId from Classes order by ClassId asc");

                //创建数据集
                DataSet ds = new DataSet("Attendance");

                //填充数据集
                ds = DBHelper.getDataSet(selectSql, "Classes");

                //指定“课程名称组合框”的数据源
                this.comboBox2.DataSource = ds.Tables["Classes"];
                this.comboBox2.DisplayMember = "ClassId";
                this.comboBox2.ValueMember = "ClassId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string selectSql = string.Format("select StuId,StuName from Students where ClassId={0} order by StuId asc", comboBox2.Text.Trim());
            this.FillDgvStudent(selectSql);
            string data1 = dgvStudent.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = data1;

        }
        public void FillDgvStudent(string selectSql)
        {
            try
            {

                //创建数据集 DataSet 对象
                dataSet = new DataSet("Attendance");

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "CourseSchedules");

                //创建数据视图 DataView 对象
                dataView = new DataView();

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["CourseSchedules"];

                //创建 BindingSource 对象，将 BindingSource 组件绑定到数据视图。
                bindSource = new BindingSource(dataView, "");

                //建立复杂数据绑定，将 DataGridView 控件绑定到 BindingSource组件。
                this.dgvStudent.DataSource = bindSource;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmAttendance_Load(object sender, EventArgs e)
        {
            // 初始化班级名称组合框
            this.FillCourseNameComboBox();

            // 初始化宿舍名称组合框
            this.FillClassComboBox();
           

            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AllowUserToAddRows = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.dgvStudent.CurrentCell.RowIndex < this.dgvStudent.Rows.Count - 1)
            {
                this.dgvStudent.CurrentCell = this.dgvStudent[0, dgvStudent.CurrentCell.RowIndex + 1];
            }
            else
            {
                MessageBox.Show("已是最后一条记录", "提示");
            }
            string data1 = dgvStudent.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = data1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (this.dgvStudent.CurrentCell.RowIndex != 0)
            {
                this.dgvStudent.CurrentCell = this.dgvStudent[0, dgvStudent.CurrentCell.RowIndex - 1];
            }
            else
            {
                MessageBox.Show("已是第一条记录", "提示");
            }
            string data1 = dgvStudent.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = data1;
        }

        private void btnArrived_Click(object sender, EventArgs e)
        {
            

            try
            { // 获取当前登录学生所在的班级编号
                string ClassId = comboBox2.Text.Trim();
                string StuId = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
                string  StatusId = "1";


                //添加记录用的SQL语句
                string insertSql = String.Format("insert into StudentAttendances (StuId, CourseId, SchoolYear, Semester, Week, Weekday, SchoolTime, StatusId) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                    StuId,
                    AttendanceHelper. getCurrentCourseId(ClassId).ToString(),
                    AttendanceHelper.getCurrentSchoolYear().ToString(),
                     AttendanceHelper.getCurrentSemester().ToString(),
                     AttendanceHelper.getCurrentWeek().ToString(),
                     AttendanceHelper.getCurrentWeekday().ToString(),
                     AttendanceHelper.getCurrentSchoolTime().ToString(),
                     StatusId);

                //执行添加操作
                int insertResult = DBHelper.executeInsertSql(insertSql);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private void btnNon_Click(object sender, EventArgs e)
        {
            try
            { // 获取当前登录学生所在的班级编号
                string ClassId = comboBox2.Text.Trim();
                string StuId = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
                string StatusId = "2";


                //添加记录用的SQL语句
                string insertSql = String.Format("insert into StudentAttendances (StuId, CourseId, SchoolYear, Semester, Week, Weekday, SchoolTime, StatusId) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                    StuId,
                    AttendanceHelper.getCurrentCourseId(ClassId).ToString(),
                    AttendanceHelper.getCurrentSchoolYear().ToString(),
                     AttendanceHelper.getCurrentSemester().ToString(),
                     AttendanceHelper.getCurrentWeek().ToString(),
                     AttendanceHelper.getCurrentWeekday().ToString(),
                     AttendanceHelper.getCurrentSchoolTime().ToString(),
                     StatusId);

                //执行添加操作
                int insertResult = DBHelper.executeInsertSql(insertSql);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            try
            { // 获取当前登录学生所在的班级编号
                string ClassId = comboBox2.Text.Trim();
                string StuId = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
                string StatusId = "3";


                //添加记录用的SQL语句
                string insertSql = String.Format("insert into StudentAttendances (StuId, CourseId, SchoolYear, Semester, Week, Weekday, SchoolTime, StatusId) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                    StuId,
                    AttendanceHelper.getCurrentCourseId(ClassId).ToString(),
                    AttendanceHelper.getCurrentSchoolYear().ToString(),
                     AttendanceHelper.getCurrentSemester().ToString(),
                     AttendanceHelper.getCurrentWeek().ToString(),
                     AttendanceHelper.getCurrentWeekday().ToString(),
                     AttendanceHelper.getCurrentSchoolTime().ToString(),
                     StatusId);

                //执行添加操作
                int insertResult = DBHelper.executeInsertSql(insertSql);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLate_Click(object sender, EventArgs e)
        {
            try
            { // 获取当前登录学生所在的班级编号
                string ClassId = comboBox2.Text.Trim();
                string StuId = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
                string StatusId = "4";


                //添加记录用的SQL语句
                string insertSql = String.Format("insert into StudentAttendances (StuId, CourseId, SchoolYear, Semester, Week, Weekday, SchoolTime, StatusId) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                    StuId,
                    AttendanceHelper.getCurrentCourseId(ClassId).ToString(),
                    AttendanceHelper.getCurrentSchoolYear().ToString(),
                     AttendanceHelper.getCurrentSemester().ToString(),
                     AttendanceHelper.getCurrentWeek().ToString(),
                     AttendanceHelper.getCurrentWeekday().ToString(),
                     AttendanceHelper.getCurrentSchoolTime().ToString(),
                     StatusId);

                //执行添加操作
                int insertResult = DBHelper.executeInsertSql(insertSql);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                radioButton1.Checked = false;
                btnLast.Visible = false;
                btnNext.Visible = false;
                btnStart.Visible = true;
                btnEnd.Visible = true;
            }
        }
       

      

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            timerCallName.Start();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timerCallName.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                btnStart.Visible = false;
                btnEnd.Visible = false;
                btnLast.Visible =true;
                btnNext.Visible = true;
            }
        }

        private void timerCallName_Tick_1(object sender, EventArgs e)
        {
            Random ra = new Random();
            int i = ra.Next(dgvStudent.Rows.Count);
            txtName.Text = dgvStudent.Rows[i].Cells[1].Value.ToString();
        }
    }
}
