using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr.TeacherInfo
{
    public partial class frmViewTeacherInfo : Form
    {
        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;
        
        public frmViewTeacherInfo()
        {
            InitializeComponent();
        }

        // 重新填充数据集
        private void FillDataSet(string StaffRoomId)
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = String.Format("select TeacherId, TeacherName, TeacherPwd, Sex, OfficeName, Telephone " +
                    "from Teachers t, Offices o " +
                    "where t.OfficeId = o.OfficeId and StaffRoomId = '{0}' " +
                    "order by TeacherId asc", StaffRoomId);

                //清空数据集
                dataSet.Tables["Teachers"].Clear();

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Teachers");

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Teachers"];
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
                this.tvTeacherInfo.Nodes.Clear();

                //在TreeView控件中添加一个根节点
                TreeNode rootNode = this.tvTeacherInfo.Nodes.Add("西南石油大学");

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

                    //在“西南石油大学”根节点下，添加“院系”子节点
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

                    //查询教研室信息
                    string selectSql_StaffRooms = String.Format("select StaffRoomId, StaffRoomName from StaffRooms where DepId = '{0}' order by StaffRoomId asc",
                        subNodeDepartments.Tag.ToString());

                    command.CommandType = CommandType.Text;
                    command.CommandText = selectSql_StaffRooms;

                    SqlDataReader sdrStaffRooms = command.ExecuteReader();

                    while (sdrStaffRooms.Read())
                    {
                        string StaffRoomId = sdrStaffRooms["StaffRoomId"].ToString();
                        string StaffRoomName = sdrStaffRooms["StaffRoomName"].ToString();

                        //在“院系”节点下，添加“教研室”子节点
                        TreeNode subNodeStaffRooms = subNodeDepartments.Nodes.Add(StaffRoomName);
                        subNodeStaffRooms.Tag = StaffRoomId;
                    }

                    if (sdrStaffRooms.IsClosed == false)
                    {
                        sdrStaffRooms.Close();
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
        private void frmViewTeacherInfo_Load(object sender, EventArgs e)
        {
            // 初始化树形视图控件
            this.FillTreeView();

            try
            {
                //查询记录用的SQL语句
                string selectSql = "select TeacherId, TeacherName, TeacherPwd, Sex, OfficeName, Telephone " +
                    "from Teachers t, Offices o " +
                    "where t.OfficeId = o.OfficeId and 1 = 0 " +
                    "order by TeacherId asc";

                //创建数据集 DataSet 对象
                dataSet = new DataSet("Attendance");

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Teachers");

                //创建数据视图 DataView 对象
                dataView = new DataView();

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Teachers"];

                //创建 BindingSource 对象，将 BindingSource 组件绑定到数据视图。
                bindSource = new BindingSource(dataView, "");

                //建立复杂数据绑定，将 DataGridView 控件绑定到 BindingSource组件。
                this.dgvTeacher.DataSource = bindSource;

                //将 BindingNavigator 控件和 BindingSource 组件关联起来
                this.bindingNavigator1.BindingSource = bindSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 在树形视图控件中，选中某一个节点后，显示相应的教师信息。
        private void tvTeacherInfo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //如果选中了“教研室”节点，显示出当前教研室的所有教师信息。
                if (e.Node.Nodes.Count <= 0 && e.Node.Parent != null)
                {
                    string StaffRoomId = e.Node.Tag.ToString();

                    this.FillDataSet(StaffRoomId);
                }
                else
                {
                    //清空数据集
                    dataSet.Tables["Teachers"].Clear();
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
                    case "工号":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("TeacherId like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "姓名":
                        {
                            dataView.RowFilter = String.Format("TeacherName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "密码":
                        {
                            dataView.RowFilter = String.Format("TeacherPwd like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "性别":
                        {
                            dataView.RowFilter = String.Format("Sex like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "办公室名称":
                        {
                            dataView.RowFilter = String.Format("OfficeName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "联系电话":
                        {
                            dataView.RowFilter = String.Format("Telephone like '%{0}%'", this.txtCondition.Text);
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
            TreeNode currentNode = this.tvTeacherInfo.SelectedNode;

            try
            {
                //如果选中了“教研室”节点，显示出当前教研室的所有教师信息。
                if (currentNode.Nodes.Count <= 0 && currentNode.Parent != null)
                {
                    string StaffRoomId = currentNode.Tag.ToString();

                    // 重新填充数据集
                    this.FillDataSet(StaffRoomId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}