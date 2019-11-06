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
    public partial class frmViewAttendanceInfo : Form
    {
        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;
        
        public frmViewAttendanceInfo()
        {
            InitializeComponent();
        }

        // 重新填充数据集
        private void FillDataSet(string ClassId)
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = String.Format("select SchoolYear, Semester, Week, Weekday, SchoolTime, CourseName, StuName, StatusName, Memo " +
                    "from StudentAttendances sa, Courses c, Students s, AttendanceStatus status, Classes cls " +
                    "where sa.CourseId = c.CourseId and sa.StuId = s.StuId and sa.StatusId = status.StatusId and s.ClassId = cls.ClassId and cls.ClassId = '{0}' " +
                    "order by SchoolYear desc, Semester desc, CourseName asc, StatusName asc", ClassId);

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

        // 填充树形视图控件
        private void FillTreeView()
        {
            try
            {
                //清空TreeView控件的所有节点
                this.tvAttendanceInfo.Nodes.Clear();

                //在TreeView控件中添加一个根节点
                TreeNode rootNode = this.tvAttendanceInfo.Nodes.Add("长沙民政职业技术学院");

                //查询院系信息
                string selectSql_Departments = "select DepId, DepName from Departments order by DepId asc";

                SqlCommand command = new SqlCommand(selectSql_Departments, DBHelper.connection);

                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }

                SqlDataReader sdrDepartments = command.ExecuteReader();

                //循环读取结果集中每一行
                while (sdrDepartments.Read())
                {
                    string DepId = sdrDepartments["DepId"].ToString();
                    string DepName = sdrDepartments["DepName"].ToString();

                    //在“长沙民政职业技术学院”根节点下，添加“院系”子节点
                    TreeNode subNode = rootNode.Nodes.Add(DepName);
                    subNode.Tag = DepId;
                }

                if (sdrDepartments.IsClosed == false)
                {
                    sdrDepartments.Close();
                }

                //遍历TreeView控件中根节点下的“院系”子节点
                for (int i = 0; i <= rootNode.Nodes.Count - 1; i++)
                {
                    TreeNode subNodeDepartments = rootNode.Nodes[i];  //“院系”子节点

                    //查询专业信息
                    string selectSql_Specialities = String.Format("select SpecialId, SpecialName from Specialities where DepId = '{0}' order by SpecialId asc",
                        subNodeDepartments.Tag.ToString());

                    command.CommandType = CommandType.Text;
                    command.CommandText = selectSql_Specialities;

                    SqlDataReader sdrSpecialities = command.ExecuteReader();

                    while (sdrSpecialities.Read())
                    {
                        string SpecialId = sdrSpecialities["SpecialId"].ToString();
                        string SpecialName = sdrSpecialities["SpecialName"].ToString();

                        //在“院系”节点下，添加“专业”子节点
                        TreeNode subNodeSpecialities = subNodeDepartments.Nodes.Add(SpecialName);
                        subNodeSpecialities.Tag = SpecialId;

                    }

                    if (sdrSpecialities.IsClosed == false)
                    {
                        sdrSpecialities.Close();
                    }
                }

                //遍历TreeView控件中“专业”子节点
                for (int i = 0; i <= rootNode.Nodes.Count - 1; i++)
                {
                    TreeNode subNodeDepartments = rootNode.Nodes[i];  //“院系”子节点

                    for (int j = 0; j <= subNodeDepartments.Nodes.Count - 1; j++)
                    {
                        TreeNode subNodeSpecialities = subNodeDepartments.Nodes[j];  //“专业”子节点

                        //查询班级信息
                        string selectSql_Classes = String.Format("select ClassId, ClassName from Classes where DepId = '{0}' and SpecialId = '{1}' order by ClassId asc",
                            subNodeDepartments.Tag.ToString(), subNodeSpecialities.Tag.ToString());

                        command.CommandType = CommandType.Text;
                        command.CommandText = selectSql_Classes;

                        SqlDataReader sdrClasses = command.ExecuteReader();

                        while (sdrClasses.Read())
                        {
                            string ClassId = sdrClasses["ClassId"].ToString();
                            string ClassName = sdrClasses["ClassName"].ToString();

                            //在“专业”节点下，添加“班级”子节点
                            TreeNode subNodeClasses = subNodeSpecialities.Nodes.Add(ClassName);
                            subNodeClasses.Tag = ClassId;
                        }

                        if (sdrClasses.IsClosed == false)
                        {
                            sdrClasses.Close();
                        }
                    }
                }

                // 展开根节点
                rootNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DBHelper.connection.State != ConnectionState.Closed)
                {
                    DBHelper.connection.Close();
                }
            }
        }

        // 窗体加载
        private void frmViewAttendanceInfo_Load(object sender, EventArgs e)
        {
            // 初始化树形视图控件
            this.FillTreeView();

            try
            {
                //查询记录用的SQL语句
                string selectSql = "select SchoolYear, Semester, Week, Weekday, SchoolTime, CourseName, StuName, StatusName, Memo " +
                    "from StudentAttendances sa, Courses c, Students s, AttendanceStatus status, Classes cls " +
                    "where sa.CourseId = c.CourseId and sa.StuId = s.StuId and sa.StatusId = status.StatusId and s.ClassId = cls.ClassId and 1 = 0 " +
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 在树形视图控件中，选中某一个节点后，显示相应的学生出勤信息。
        private void tvAttendanceInfo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //如果选中了“班级”节点，显示出当前班级的所有学生的出勤信息。
                if (e.Node.Nodes.Count <= 0 && e.Node.Parent != null)
                {
                    string ClassId = e.Node.Tag.ToString();

                    this.FillDataSet(ClassId);
                }
                else
                {
                    //清空数据集
                    dataSet.Tables["StudentAttendances"].Clear();
                }
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
                    case "学生姓名":
                        {
                            dataView.RowFilter = String.Format("StuName like '%{0}%'", this.txtCondition.Text);
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
            // 获取树形视图控件中的当前节点
            TreeNode currentNode = this.tvAttendanceInfo.SelectedNode;

            try
            {
                //如果选中了“班级”节点，显示出当前班级的所有学生的出勤信息。
                if (currentNode.Nodes.Count <= 0 && currentNode.Parent != null)
                {
                    string ClassId = currentNode.Tag.ToString();

                    // 重新填充数据集
                    this.FillDataSet(ClassId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}