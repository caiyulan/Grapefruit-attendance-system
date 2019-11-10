using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr.TeacherService
{
    public partial class frmViewTeacherCourseInfo : Form
    {
        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;
        
        public frmViewTeacherCourseInfo()
        {
            InitializeComponent();
        }

        // 重新填充数据集
        private void FillDataSet()
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = String.Format("select SchoolYear, Semester, CourseName, Weekday, SchoolTime, TeacherName, RoomName, StartWeek, EndWeek " +
                    "from CourseSchedules cs, Courses c, Teachers t, ClassRooms cr " +
                    "where cs.CourseId = c.CourseId and cs.TeacherId = t.TeacherId and cs.RoomId = cr.RoomId and cs.TeacherId = '{0}' " +
                    "order by SchoolYear desc, Semester asc, CourseName asc", CommonInfo.userId);

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

        // 窗体加载
        private void frmViewTeacherCourseInfo_Load(object sender, EventArgs e)
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = String.Format("select SchoolYear, Semester, CourseName, Weekday, SchoolTime, TeacherName, RoomName, StartWeek, EndWeek " +
                    "from CourseSchedules cs, Courses c, Teachers t, ClassRooms cr " +
                    "where cs.CourseId = c.CourseId and cs.TeacherId = t.TeacherId and cs.RoomId = cr.RoomId and cs.TeacherId = '{0}' " +
                    "order by SchoolYear desc, Semester asc, CourseName asc", CommonInfo.userId);

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
                this.dgvTeacherCourseInfo.DataSource = bindSource;

                //将 BindingNavigator 控件和 BindingSource 组件关联起来
                this.bindingNavigator1.BindingSource = bindSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            dataView.RowFilter = String.Format("SchoolYear like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "学期":
                        {
                            dataView.RowFilter = String.Format("Semester like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "课程名称":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("CourseName like '%{0}%'", this.txtCondition.Text);
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
                    case "上课教师":
                        {
                            dataView.RowFilter = String.Format("TeacherName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "上课地点":
                        {
                            dataView.RowFilter = String.Format("RoomName like '%{0}%'", this.txtCondition.Text);
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