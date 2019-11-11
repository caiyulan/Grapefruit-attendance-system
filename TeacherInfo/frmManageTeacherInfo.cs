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
    public partial class frmManageTeacherInfo : Form
    {
        private int AddOrEdit = 0; //标记是添加或修改了记录，0表示添加，1表示修改

        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;
        
        public frmManageTeacherInfo()
        {
            InitializeComponent();
        }

        // 填充教研室名称组合框
        private void FillStaffRoomNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select StaffRoomId, StaffRoomName, DepId from StaffRooms order by DepId asc, StaffRoomId asc";

                //创建数据集
                DataSet dsStaffRooms = new DataSet("Attendance");

                //填充数据集
                dsStaffRooms = DBHelper.getDataSet(selectSql, "StaffRooms");

                //指定“教研室名称组合框”的数据源
                this.cboStaffRoomName.DataSource = dsStaffRooms.Tables["StaffRooms"];
                this.cboStaffRoomName.DisplayMember = "StaffRoomName";
                this.cboStaffRoomName.ValueMember = "StaffRoomId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 填充办公室名称组合框
        private void FillOfficeNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select OfficeId, OfficeName from Offices order by OfficeId asc";

                //创建数据集
                DataSet dsOffices = new DataSet("Attendance");

                //填充数据集
                dsOffices = DBHelper.getDataSet(selectSql, "Offices");

                //指定“办公室名称组合框”的数据源
                this.cboOfficeName.DataSource = dsOffices.Tables["Offices"];
                this.cboOfficeName.DisplayMember = "OfficeName";
                this.cboOfficeName.ValueMember = "OfficeId";
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
                string selectSql = "select TeacherId, TeacherName, Sex, StaffRoomName, OfficeName, Telephone " +
                    "from Teachers t, StaffRooms s, Offices o " +
                    "where t.StaffRoomId = s.StaffRoomId and t.OfficeId = o.OfficeId " +
                    "order by TeacherId asc";

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

        // 清空文本框
        private void ClearTextBox()
        {
            this.txtTeacherId.Clear();
            this.txtTeacherName.Clear();
            this.cboSex.Text = "";
            this.cboStaffRoomName.Text = "";
            this.cboOfficeName.Text = "";
            this.txtTelephone.Clear();
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.txtTeacherId.Enabled = false;
            this.txtTeacherName.Enabled = false;
            this.cboSex.Enabled = false;
            this.cboStaffRoomName.Enabled = false;
            this.cboOfficeName.Enabled = false;
            this.txtTelephone.Enabled = false;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.txtTeacherId.Enabled = true;
            this.txtTeacherName.Enabled = true;
            this.cboSex.Enabled = true;
            this.cboStaffRoomName.Enabled = true;
            this.cboOfficeName.Enabled = true;
            this.txtTelephone.Enabled = true;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.txtTeacherId.Text.Trim() == "")
            {
                MessageBox.Show("请输入工号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTeacherId.Focus();
                return false;
            }
            else if (this.txtTeacherName.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTeacherName.Focus();
                return false;
            }
            else if (this.cboSex.Text.Trim() == "")
            {
                MessageBox.Show("请输入性别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSex.Focus();
                return false;
            }
            else if (this.cboStaffRoomName.Text.Trim() == "")
            {
                MessageBox.Show("请输入教研室名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStaffRoomName.Focus();
                return false;
            }
            else if (this.cboOfficeName.Text.Trim() == "")
            {
                MessageBox.Show("请输入办公室名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboOfficeName.Focus();
                return false;
            }
            else if (this.txtTelephone.Text.Trim() == "")
            {
                MessageBox.Show("请输入联系电话", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTelephone.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmManageTeacherInfo_Load(object sender, EventArgs e)
        {
            // 初始化教研室名称组合框
            this.FillStaffRoomNameComboBox();

            // 初始化办公室名称组合框
            this.FillOfficeNameComboBox();

            try
            {
                //查询记录用的SQL语句
                string selectSql = "select TeacherId, TeacherName, Sex, StaffRoomName, OfficeName, Telephone " +
                    "from Teachers t, StaffRooms s, Offices o " +
                    "where t.StaffRoomId = s.StaffRoomId and t.OfficeId = o.OfficeId " +
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
        private void dgvTeacher_SelectionChanged(object sender, EventArgs e)
        {

            // 判断当前DataGridView控件中是否有记录，如果没有，则终止操作。
            if (this.dgvTeacher.Rows.Count <= 0)
            {
                return;
            }

            //将 DataGridView 控件中当前行各列的值显示在各文本框控件中
            //显示该行的院系信息
            this.txtTeacherId.Text = this.dgvTeacher.CurrentRow.Cells["TeacherId"].Value.ToString();
            this.txtTeacherName.Text = this.dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
            this.cboSex.Text = this.dgvTeacher.CurrentRow.Cells["Sex"].Value.ToString();
            this.cboStaffRoomName.Text = this.dgvTeacher.CurrentRow.Cells["StaffRoomName"].Value.ToString();
            this.cboOfficeName.Text = this.dgvTeacher.CurrentRow.Cells["OfficeName"].Value.ToString();
            this.txtTelephone.Text = this.dgvTeacher.CurrentRow.Cells["Telephone"].Value.ToString();
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

            this.txtTeacherId.Focus();
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 1;

            //解除锁定
            this.UnLockedTextBox();

            this.txtTeacherId.Enabled = false;  //不允许修改“工号”

            this.btnSave.Enabled = true;    //启用“保存”按钮
            this.btnCancel.Enabled = true;  //启用“取消”按钮

            this.txtTeacherName.Focus();
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvTeacher.RowCount <= 0)
            {
                MessageBox.Show("没有记录可以删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录用的SQL语句
                string deleteSql = String.Format("delete from Teachers where TeacherId = '{0}'", this.txtTeacherId.Text);

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
                //判断工号是否已存在
                string selectSql = String.Format("select count(*) from Teachers where TeacherId = '{0}'", this.txtTeacherId.Text);

                //执行查询操作
                int result = (int)DBHelper.executeScalar(selectSql);

                //如果工号已存在，则提示用户重新输入，并终止操作。
                if (result >= 1)
                {
                    MessageBox.Show("该工号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtTeacherId.Focus();
                    return;
                }

                //添加记录用的SQL语句
                string insertSql = String.Format("insert into Teachers (TeacherId, TeacherName, TeacherPwd, Sex, StaffRoomId, OfficeId, Telephone) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    this.txtTeacherId.Text, this.txtTeacherName.Text, "888888", this.cboSex.Text, this.cboStaffRoomName.SelectedValue, this.cboOfficeName.SelectedValue, this.txtTelephone.Text);

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
                string updateSql = String.Format("update Teachers set TeacherName = '{0}', Sex = '{1}', StaffRoomId = '{2}', OfficeId = '{3}', Telephone = '{4}' where TeacherId = '{5}'",
                    this.txtTeacherName.Text, this.cboSex.Text, this.cboStaffRoomName.SelectedValue, this.cboOfficeName.SelectedValue, this.txtTelephone.Text, this.txtTeacherId.Text);

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
                    case "性别":
                        {
                            dataView.RowFilter = String.Format("Sex like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "教研室名称":
                        {
                            dataView.RowFilter = String.Format("StaffRoomName like '%{0}%'", this.txtCondition.Text);
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
            this.FillDataSet();
        }
    }
}