using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr.BasicInfo
{
    public partial class frmClassRoomInfo : Form
    {
        private int AddOrEdit = 0; //标记是添加或修改了记录，0表示添加，1表示修改

        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;

        public frmClassRoomInfo()
        {
            InitializeComponent();
        }

        // 重新填充数据集
        private void FillDataSet()
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = "select RoomId, RoomName from ClassRooms order by RoomId";

                //清空数据集
                dataSet.Tables["ClassRooms"].Clear();

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "ClassRooms");

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["ClassRooms"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空文本框
        private void ClearTextBox()
        {
            this.txtClassRoomId.Clear();
            this.txtClassRoomName.Clear();
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.txtClassRoomId.ReadOnly = true;
            this.txtClassRoomName.ReadOnly = true;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.txtClassRoomId.ReadOnly = false;
            this.txtClassRoomName.ReadOnly = false;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.txtClassRoomId.Text.Trim() == "")
            {
                MessageBox.Show("请输入教室编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtClassRoomId.Focus();
                return false;
            }
            else if (this.txtClassRoomName.Text.Trim() == "")
            {
                MessageBox.Show("请输入教室名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtClassRoomName.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmClassRoomInfo_Load(object sender, EventArgs e)
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = "select RoomId, RoomName from ClassRooms order by RoomId";

                //创建数据集 DataSet 对象
                dataSet = new DataSet("Attendance");

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "ClassRooms");

                //创建数据视图 DataView 对象
                dataView = new DataView();

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["ClassRooms"];

                //创建 BindingSource 对象，将 BindingSource 组件绑定到数据视图。
                bindSource = new BindingSource(dataView, "");

                //建立复杂数据绑定，将 DataGridView 控件绑定到 BindingSource组件。
                this.dgvClassRoom.DataSource = bindSource;

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
        private void dgvClassRoom_SelectionChanged(object sender, EventArgs e)
        {
            // 判断当前DataGridView控件中是否有记录，如果没有，则终止操作。
            if (this.dgvClassRoom.Rows.Count <= 0)
            {
                return;
            }

            //将 DataGridView 控件中当前行各列的值显示在各文本框控件中
            //显示该行的院系信息
            this.txtClassRoomId.Text = this.dgvClassRoom.CurrentRow.Cells["RoomId"].Value.ToString();
            this.txtClassRoomName.Text = this.dgvClassRoom.CurrentRow.Cells["RoomName"].Value.ToString();
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

            this.txtClassRoomId.Focus();
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 1;

            //解除锁定
            this.UnLockedTextBox();

            this.txtClassRoomId.ReadOnly = true;  //不允许修改“教室编号”

            this.btnSave.Enabled = true;    //启用“保存”按钮
            this.btnCancel.Enabled = true;  //启用“取消”按钮

            this.txtClassRoomName.Focus();
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvClassRoom.RowCount <= 0)
            {
                MessageBox.Show("没有记录可以删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录用的SQL语句
                string deleteSql = String.Format("delete from ClassRooms where RoomId = '{0}'", this.txtClassRoomId.Text);

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
                //判断教室编号是否已存在
                string selectSql = String.Format("select count(*) from ClassRooms where RoomId = '{0}'", this.txtClassRoomId.Text);

                //执行查询操作
                int result = (int)DBHelper.executeScalar(selectSql);

                //如果教室编号已存在，则提示用户重新输入，并终止操作。
                if (result >= 1)
                {
                    MessageBox.Show("该教室编号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtClassRoomId.Focus();
                    return;
                }

                //添加记录用的SQL语句
                string insertSql = String.Format("insert into ClassRooms (RoomId, RoomName) values ('{0}', '{1}')", 
                    this.txtClassRoomId.Text, this.txtClassRoomName.Text);

                //执行添加操作
                int insertResult = DBHelper.executeInsertSql(insertSql);

                if (insertResult >= 1)
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //添加一行后，重新填充当前数据集
                    this.FillDataSet();

                    //锁定文本框
                    this.LockedTextBox();

                    this.btnSave.Enabled = false;    //禁用“保存”按钮
                    this.btnCancel.Enabled = false;  //禁用“取消”按钮
                }
            }

            //执行修改操作
            if (this.AddOrEdit == 1)
            {
                //修改记录用的SQL语句
                string updateSql = String.Format("update ClassRooms set RoomName = '{0}' where RoomId = '{1}'", this.txtClassRoomName.Text, this.txtClassRoomId.Text);

                //执行修改操作
                int updateResult = DBHelper.executeUpdateSql(updateSql);

                if (updateResult >= 1)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //添加一行后，重新填充当前数据集
                    this.FillDataSet();

                    //锁定文本框
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
                    case "教室编号":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("RoomId like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "教室名称":
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
            this.FillDataSet();
        }
    }
}