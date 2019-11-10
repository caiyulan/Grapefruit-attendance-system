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
    public partial class frmManageCourseScheduleInfo : Form
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
        
        public frmManageCourseScheduleInfo()
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

        // 重新填充数据集
        private void FillDataSet()
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = "select ScheduleId, cs.CourseId, CourseName, TeacherName, ClassName, RoomName, SchoolYear, Semester, Weekday, SchoolTime, StartWeek, EndWeek " +
                    "from CourseSchedules cs, Courses co, Teachers t, Classes cls, ClassRooms cr " +
                    "where cs.CourseId = co.CourseId and cs.TeacherId = t.TeacherId and cs.ClassId = cls.ClassId and cs.RoomId = cr.RoomId " +
                    "order by cs.CourseId asc, TeacherName asc, ClassName asc, SchoolYear asc, Semester asc";

                //清空数据集
                dataSet.Tables["CourseSchedules"].Clear();

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "CourseSchedules");

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["CourseSchedules"];
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

            return true;
        }

        // 窗体加载
        private void frmManageCourseScheduleInfo_Load(object sender, EventArgs e)
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
                //查询记录用的SQL语句
                string selectSql = "select ScheduleId, cs.CourseId, CourseName, TeacherName, ClassName, RoomName, SchoolYear, Semester, Weekday, SchoolTime, StartWeek, EndWeek " +
                    "from CourseSchedules cs, Courses co, Teachers t, Classes cls, ClassRooms cr " +
                    "where cs.CourseId = co.CourseId and cs.TeacherId = t.TeacherId and cs.ClassId = cls.ClassId and cs.RoomId = cr.RoomId " +
                    "order by cs.CourseId asc, TeacherName asc, ClassName asc, SchoolYear asc, Semester asc";

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
                this.dgvCourseSchedule.DataSource = bindSource;

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
        private void dgvCourseSchedule_SelectionChanged(object sender, EventArgs e)
        {
            // 判断当前DataGridView控件中是否有记录，如果没有，则终止操作。
            if (this.dgvCourseSchedule.Rows.Count <= 0)
            {
                return;
            }

            //将 DataGridView 控件中当前行各列的值显示在各文本框控件中
            //显示该行的课表信息
            this.RecordId = (int)this.dgvCourseSchedule.CurrentRow.Cells["ScheduleId"].Value;   //获取记录编号，用于修改和删除操作。
            this.cboCourseName.Text = this.dgvCourseSchedule.CurrentRow.Cells["CourseName"].Value.ToString();
            this.cboTeacherName.Text = this.dgvCourseSchedule.CurrentRow.Cells["TeacherName"].Value.ToString();
            this.cboClassName.Text = this.dgvCourseSchedule.CurrentRow.Cells["ClassName"].Value.ToString();
            this.cboRoomName.Text = this.dgvCourseSchedule.CurrentRow.Cells["RoomName"].Value.ToString();
            this.cboSchoolYear.Text = this.dgvCourseSchedule.CurrentRow.Cells["SchoolYear"].Value.ToString();
            this.cboSemester.Text = this.dgvCourseSchedule.CurrentRow.Cells["Semester"].Value.ToString();
            this.cboWeekday.Text = this.dgvCourseSchedule.CurrentRow.Cells["Weekday"].Value.ToString();
            this.cboSchoolTime.Text = this.dgvCourseSchedule.CurrentRow.Cells["SchoolTime"].Value.ToString();
            this.cboStartWeek.Text = this.dgvCourseSchedule.CurrentRow.Cells["StartWeek"].Value.ToString();
            this.cboEndWeek.Text = this.dgvCourseSchedule.CurrentRow.Cells["EndWeek"].Value.ToString();
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

            this.cboCourseName.Focus();
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 1;

            //解除锁定
            this.UnLockedTextBox();

            this.btnSave.Enabled = true;    //启用“保存”按钮
            this.btnCancel.Enabled = true;  //启用“取消”按钮

            this.cboCourseName.Focus();
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvCourseSchedule.RowCount <= 0)
            {
                MessageBox.Show("没有记录可以删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录用的SQL语句
                string deleteSql = String.Format("delete from CourseSchedules where ScheduleId = {0}", this.RecordId);

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
                    return;
                }
                
                
                //添加记录用的SQL语句
                string insertSql = String.Format("insert into CourseSchedules (CourseId, TeacherId, ClassId, RoomId, SchoolYear, Semester, Weekday, SchoolTime, StartWeek, EndWeek) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}') ",
                    this.cboCourseName.SelectedValue,
                    this.cboTeacherName.SelectedValue,
                    this.cboClassName.SelectedValue,
                    this.cboRoomName.SelectedValue,
                    this.cboSchoolYear.Text,
                    this.cboSemester.Text,
                    this.cboWeekday.Text,
                    this.cboSchoolTime.Text,
                    this.cboStartWeek.Text,
                    this.cboEndWeek.Text);

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
                string updateSql = String.Format("update CourseSchedules set CourseId = '{0}', TeacherId = '{1}', ClassId = '{2}', RoomId = '{3}', " +
                    "SchoolYear = '{4}', Semester = '{5}', Weekday = '{6}', SchoolTime = '{7}', StartWeek = '{8}', EndWeek = '{9}' where ScheduleId = {10}",
                    this.cboCourseName.SelectedValue,
                    this.cboTeacherName.SelectedValue,
                    this.cboClassName.SelectedValue,
                    this.cboRoomName.SelectedValue,
                    this.cboSchoolYear.Text,
                    this.cboSemester.Text,
                    this.cboWeekday.Text,
                    this.cboSchoolTime.Text,
                    this.cboStartWeek.Text,
                    this.cboEndWeek.Text,
                    this.RecordId);

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
                    case "课程名称":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("CourseName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "上课教师":
                        {
                            dataView.RowFilter = String.Format("TeacherName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "上课班级":
                        {
                            dataView.RowFilter = String.Format("ClassName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "上课地点":
                        {
                            dataView.RowFilter = String.Format("RoomName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "学年":
                        {
                            dataView.RowFilter = String.Format("SchoolYear like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "学期":
                        {
                            dataView.RowFilter = String.Format("Semester like '%{0}%'", this.txtCondition.Text);
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