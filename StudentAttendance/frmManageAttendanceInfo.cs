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
    public partial class frmManageAttendanceInfo : Form
    {
        private int AddOrEdit = 0; //标记是添加或修改了记录，0表示添加，1表示修改

        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;

        //记录编号
        private int RecordId = 0; 
        
        public frmManageAttendanceInfo()
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

        // 重新填充数据集
        private void FillDataSet()
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = "select AttendanceId, SchoolYear, Semester, Week, Weekday, SchoolTime, CourseName, StuId, StatusName, Memo " +
                    "from StudentAttendances sa, Courses c, AttendanceStatus status " +
                    "where sa.CourseId = c.CourseId and sa.StatusId = status.StatusId " +
                    "order by SchoolYear desc, Semester desc, CourseName asc, StatusName asc";

                //清空数据集
                dataSet.Tables["StudentAttendances"].Clear();

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "StudentAttendances");

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["StudentAttendances"];
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
            this.txtStuId.Text = "";
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
            this.txtStuId.Enabled = false;
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
            this.txtStuId.Enabled = true;
            this.cboAttendanceStatus.Enabled = true;
            this.txtMemo.Enabled = true;
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
            else if (this.txtStuId.Text.Trim() == "")
            {
                MessageBox.Show("请输入学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuId.Focus();
                return false;
            }
            else if (this.cboAttendanceStatus.Text.Trim() == "")
            {
                MessageBox.Show("请输入出勤状态", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboAttendanceStatus.Focus();
                return false;
            }

            //检查后台数据库的 Students 表中是否存在输入的学号
            string selectSql = String.Format("select count(*) from Students where StuId = '{0}' ", this.txtStuId.Text);

            //执行查询操作
            int result = (int)DBHelper.executeScalar(selectSql);

            //如果学号不存在，则提示用户重新输入，并终止操作。
            if (result <= 0)
            {
                MessageBox.Show("该学号不存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuId.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmManageAttendanceInfo_Load(object sender, EventArgs e)
        {
            // 初始化课程名称组合框
            this.FillCourseNameComboBox();

            // 初始化出勤状态组合框
            this.FillAttendanceStatusComboBox();

            try
            {
                //查询记录用的SQL语句
                string selectSql = "select AttendanceId, SchoolYear, Semester, Week, Weekday, SchoolTime, CourseName, StuId, StatusName, Memo " +
                    "from StudentAttendances sa, Courses c, AttendanceStatus status " +
                    "where sa.CourseId = c.CourseId and sa.StatusId = status.StatusId " +
                    "order by SchoolYear desc, Semester desc, CourseName asc, StatusName asc";

                //创建数据集 DataSet 对象
                dataSet = new DataSet("Attendance");

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "StudentAttendances");

                //创建数据视图 DataView 对象
                dataView = new DataView();

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["StudentAttendances"];

                //创建 BindingSource 对象，将 BindingSource 组件绑定到数据视图。
                bindSource = new BindingSource(dataView, "");

                //建立复杂数据绑定，将 DataGridView 控件绑定到 BindingSource组件。
                this.dgvAttendanceInfo.DataSource = bindSource;

                //将 BindingNavigator 控件和 BindingSource 组件关联起来
                this.bindingNavigator1.BindingSource = bindSource;

                this.btnSave.Enabled = false;   //禁用“保存”按钮
                this.btnCancel.Enabled = false; //禁用“取消”按钮

                // 锁定文本框
                this.LockedTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 在DataGridView控件选中某一行时，将该行各列的值显示在各文本框控件中。
        private void dgvAttendanceInfo_SelectionChanged(object sender, EventArgs e)
        {
            // 判断当前DataGridView控件中是否有记录，如果没有，则终止操作。
            if (this.dgvAttendanceInfo.Rows.Count <= 0)
            {
                return;
            }

            //将 DataGridView 控件中当前行各列的值显示在各文本框控件中
            //显示该行的出勤信息
            this.RecordId = (int)this.dgvAttendanceInfo.CurrentRow.Cells["AttendanceId"].Value;   //获取记录编号，用于修改和删除操作。
            this.cboSchoolYear.Text = this.dgvAttendanceInfo.CurrentRow.Cells["SchoolYear"].Value.ToString();
            this.cboSemester.Text = this.dgvAttendanceInfo.CurrentRow.Cells["Semester"].Value.ToString();
            this.cboWeek.Text = this.dgvAttendanceInfo.CurrentRow.Cells["Week"].Value.ToString();
            this.cboWeekday.Text = this.dgvAttendanceInfo.CurrentRow.Cells["Weekday"].Value.ToString();
            this.cboSchoolTime.Text = this.dgvAttendanceInfo.CurrentRow.Cells["SchoolTime"].Value.ToString();
            this.cboCourseName.Text = this.dgvAttendanceInfo.CurrentRow.Cells["CourseName"].Value.ToString();
            this.txtStuId.Text = this.dgvAttendanceInfo.CurrentRow.Cells["StuId"].Value.ToString();
            this.cboAttendanceStatus.Text = this.dgvAttendanceInfo.CurrentRow.Cells["StatusName"].Value.ToString();
            this.txtMemo.Text = this.dgvAttendanceInfo.CurrentRow.Cells["Memo"].Value.ToString();
        }

        // 添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 0;

            //清空文本框
            this.ClearTextBox();

            //解除锁定
            this.UnLockedTextBox();

            this.btnSave.Enabled = true;   //启用“保存”按钮
            this.btnCancel.Enabled = true; //启用“取消”按钮

            this.cboSchoolYear.Focus();
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 1;

            //解除锁定
            this.UnLockedTextBox();

            this.btnSave.Enabled = true;    //启用“保存”按钮
            this.btnCancel.Enabled = true;  //启用“取消”按钮

            this.cboSchoolYear.Focus();
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvAttendanceInfo.RowCount <= 0)
            {
                MessageBox.Show("没有记录可以删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录用的SQL语句
                string deleteSql = String.Format("delete from StudentAttendances where AttendanceId = {0}", this.RecordId);

                //执行删除操作
                int deleteResult = DBHelper.executeDeleteSql(deleteSql);

                if (deleteResult >= 1)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //删除一行后，重新填充当前数据集
                    this.FillDataSet();
                }
            }
        }

        // 保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            //验证用户输入，如果输入有误，则终止操作。
            if (this.ValidateInput() == false)
            {
                return;
            }

            //执行添加操作
            if (this.AddOrEdit == 0)
            {
                //检查后台数据库的 StudentAttendances 表中是否存在重复的记录
                string selectSql = String.Format("select count(*) from StudentAttendances " +
                    "where SchoolYear = '{0}' and Semester = '{1}' and Week = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' and StuId = '{5}'",
                    this.cboSchoolYear.Text, this.cboSemester.Text, this.cboWeek.Text, this.cboWeekday.Text, this.cboSchoolTime.Text, this.txtStuId.Text);

                //执行查询操作
                int result = (int)DBHelper.executeScalar(selectSql);

                //如果记录已存在，则提示用户重新输入，并终止操作。
                if (result >= 1)
                {
                    MessageBox.Show("该记录已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cboSchoolYear.Focus();
                    return;
                }


                //添加记录用的SQL语句
                string insertSql = String.Format("insert into StudentAttendances (SchoolYear, Semester, Week, Weekday, SchoolTime, CourseId, StuId, StatusId, Memo) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}') ", 
                    this.cboSchoolYear.Text, this.cboSemester.Text, this.cboWeek.Text, this.cboWeekday.Text, this.cboSchoolTime.Text,
                    this.cboCourseName.SelectedValue, this.txtStuId.Text, this.cboAttendanceStatus.SelectedValue, this.txtMemo.Text);

                //执行添加操作
                int insertResult = DBHelper.executeInsertSql(insertSql);

                if (insertResult >= 1)
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //添加一行后，重新填充当前数据集
                    this.FillDataSet();

                    //锁定组合框
                    this.LockedTextBox();

                    this.btnSave.Enabled = false;    //禁用“保存”按钮
                    this.btnCancel.Enabled = false;  //禁用“取消”按钮
                }
            }

            //执行修改操作
            if (this.AddOrEdit == 1)
            {
                //修改记录用的SQL语句
                string updateSql = String.Format("update StudentAttendances set SchoolYear = '{0}', Semester = '{1}', Week = '{2}', Weekday = '{3}', " +
                    "SchoolTime = '{4}', CourseId = '{5}', StuId = '{6}', StatusId = '{7}', Memo = '{8}' where AttendanceId = {9}",
                    this.cboSchoolYear.Text, this.cboSemester.Text, this.cboWeek.Text, this.cboWeekday.Text, this.cboSchoolTime.Text,
                    this.cboCourseName.SelectedValue, this.txtStuId.Text, this.cboAttendanceStatus.SelectedValue, this.txtMemo.Text, this.RecordId);

                //执行修改操作
                int updateResult = DBHelper.executeUpdateSql(updateSql);

                if (updateResult >= 1)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //添加一行后，重新填充当前数据集
                    this.FillDataSet();

                    //锁定组合框
                    this.LockedTextBox();

                    this.btnSave.Enabled = false;    //禁用“保存”按钮
                    this.btnCancel.Enabled = false;  //禁用“取消”按钮
                }
            }
        }

        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //清空文本框
            this.ClearTextBox();

            //锁定文本框
            this.LockedTextBox();

            this.btnSave.Enabled = false;    //禁用“保存”按钮
            this.btnCancel.Enabled = false;  //禁用“取消”按钮
        }

        // 查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboCondition.Text == "")
            {
                MessageBox.Show("请输入查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboCondition.Focus();
                return;
            }

            //设置过滤条件，也即指定 DataView 对象的 RowFilter 属性。
            try
            {
                //根据“查询条件组合框”中选择的项来决定按哪一列进行过滤
                switch (this.cboCondition.Text)
                {
                    case "学年":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("SchoolYear like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "学期":
                        {
                            dataView.RowFilter = String.Format("Semester like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "周次":
                        {
                            dataView.RowFilter = String.Format("Week like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "星期":
                        {
                            dataView.RowFilter = String.Format("Weekday like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "节次":
                        {
                            dataView.RowFilter = String.Format("SchoolTime like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "课程名称":
                        {
                            dataView.RowFilter = String.Format("CourseName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "学号":
                        {
                            dataView.RowFilter = String.Format("StuId like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "出勤状态":
                        {
                            dataView.RowFilter = String.Format("StatusName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "备注":
                        {
                            dataView.RowFilter = String.Format("Memo like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    default:
                        {
                            //如果没有输入任何过滤条件，返回 0 条记录。
                            dataView.RowFilter = String.Format("1 = 0");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 刷新
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // 重新填充数据集
            this.FillDataSet();
        }
    }
}