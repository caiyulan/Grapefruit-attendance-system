using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr.StudentInfo
{
    public partial class frmManageStudentInfo : Form
    {
        private int AddOrEdit = 0; //标记是添加或修改了记录，0表示添加，1表示修改

        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;
        
        public frmManageStudentInfo()
        {
            InitializeComponent();
        }

        // 填充班级名称组合框
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

                //指定“班级名称组合框”的数据源
                this.cboClassName.DataSource = dsClasses.Tables["Classes"];
                this.cboClassName.DisplayMember = "ClassName";
                this.cboClassName.ValueMember = "ClassId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 填充宿舍名称组合框
        private void FillDormNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select DormId, DormName from Dorms order by DormId asc";

                //创建数据集
                DataSet dsClasses = new DataSet("Attendance");

                //填充数据集
                dsClasses = DBHelper.getDataSet(selectSql, "Dorms");

                //指定“宿舍名称组合框”的数据源
                this.cboDormName.DataSource = dsClasses.Tables["Dorms"];
                this.cboDormName.DisplayMember = "DormName";
                this.cboDormName.ValueMember = "DormId";
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
                string selectSql = "select StuId, StuName, Sex, ClassName, DormName, Telephone, HomeAddress, HomePhone " +
                    "from Students s, Classes c, Dorms d " +
                    "where s.ClassId = c.ClassId and s.DormId = d.DormId " +
                    "order by StuId asc";

                //清空数据集
                dataSet.Tables["Students"].Clear();

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Students");

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Students"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空文本框
        private void ClearTextBox()
        {
            this.txtStuId.Clear();
            this.txtStuName.Clear();
            this.cboSex.Text = "";
            this.cboClassName.Text = "";
            this.cboDormName.Text = "";
            this.txtTelephone.Clear();
            this.txtHomeAddress.Clear();
            this.txtHomePhone.Clear();
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.txtStuId.Enabled = false;
            this.txtStuName.Enabled = false;
            this.cboSex.Enabled = false;
            this.cboClassName.Enabled = false;
            this.cboDormName.Enabled = false;
            this.txtTelephone.Enabled = false;
            this.txtHomeAddress.Enabled = false;
            this.txtHomePhone.Enabled = false;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.txtStuId.Enabled = true;
            this.txtStuName.Enabled = true;
            this.cboSex.Enabled = true;
            this.cboClassName.Enabled = true;
            this.cboDormName.Enabled = true;
            this.txtTelephone.Enabled = true;
            this.txtHomeAddress.Enabled = true;
            this.txtHomePhone.Enabled = true;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.txtStuId.Text.Trim() == "")
            {
                MessageBox.Show("请输入学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuId.Focus();
                return false;
            }
            else if (this.txtStuName.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuName.Focus();
                return false;
            }
            else if (this.cboSex.Text.Trim() == "")
            {
                MessageBox.Show("请输入性别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSex.Focus();
                return false;
            }
            else if (this.cboClassName.Text.Trim() == "")
            {
                MessageBox.Show("请输入班级名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboClassName.Focus();
                return false;
            }
            else if (this.cboDormName.Text.Trim() == "")
            {
                MessageBox.Show("请输入宿舍名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboDormName.Focus();
                return false;
            }
            else if (this.txtTelephone.Text.Trim() == "")
            {
                MessageBox.Show("请输入联系电话", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTelephone.Focus();
                return false;
            }
            else if (this.txtHomeAddress.Text.Trim() == "")
            {
                MessageBox.Show("请输入家庭住址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHomeAddress.Focus();
                return false;
            }
            else if (this.txtHomePhone.Text.Trim() == "")
            {
                MessageBox.Show("请输入家庭电话", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtHomePhone.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmManageStudentInfo_Load(object sender, EventArgs e)
        {
            //初始化班级名称组合框
            this.FillClassNameComboBox();

            //初始化宿舍名称组合框
            this.FillDormNameComboBox();
            
            try
            {
                //查询记录用的SQL语句
                string selectSql = "select StuId, StuName, Sex, ClassName, DormName, Telephone, HomeAddress, HomePhone " +
                    "from Students s, Classes c, Dorms d " +
                    "where s.ClassId = c.ClassId and s.DormId = d.DormId " +
                    "order by StuId asc";

                //创建数据集 DataSet 对象
                dataSet = new DataSet("Attendance");

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Students");

                //创建数据视图 DataView 对象
                dataView = new DataView();

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Students"];

                //创建 BindingSource 对象，将 BindingSource 组件绑定到数据视图。
                bindSource = new BindingSource(dataView, "");

                //建立复杂数据绑定，将 DataGridView 控件绑定到 BindingSource组件。
                this.dgvStudent.DataSource = bindSource;

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
        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            // 判断当前DataGridView控件中是否有记录，如果没有，则终止操作。
            if (this.dgvStudent.Rows.Count <= 0)
            {
                return;
            }

            //将 DataGridView 控件中当前行各列的值显示在各文本框控件中
            //显示该行的院系信息
            this.txtStuId.Text = this.dgvStudent.CurrentRow.Cells["StuId"].Value.ToString();
            this.txtStuName.Text = this.dgvStudent.CurrentRow.Cells["StuName"].Value.ToString();
            this.cboSex.Text = this.dgvStudent.CurrentRow.Cells["Sex"].Value.ToString();
            this.cboClassName.Text = this.dgvStudent.CurrentRow.Cells["ClassName"].Value.ToString();
            this.cboDormName.Text = this.dgvStudent.CurrentRow.Cells["DormName"].Value.ToString();
            this.txtTelephone.Text = this.dgvStudent.CurrentRow.Cells["Telephone"].Value.ToString();
            this.txtHomeAddress.Text = this.dgvStudent.CurrentRow.Cells["HomeAddress"].Value.ToString();
            this.txtHomePhone.Text = this.dgvStudent.CurrentRow.Cells["HomePhone"].Value.ToString();
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

            this.txtStuId.Focus();
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 1;

            //解除锁定
            this.UnLockedTextBox();

            this.txtStuId.Enabled = false;  //不允许修改“学号”

            this.btnSave.Enabled = true;    //启用“保存”按钮
            this.btnCancel.Enabled = true;  //启用“取消”按钮

            this.txtStuName.Focus();
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvStudent.RowCount <= 0)
            {
                MessageBox.Show("没有记录可以删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录用的SQL语句
                string deleteSql = String.Format("delete from Students where StuId = '{0}'", this.txtStuId.Text);

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
                //判断学号是否已存在
                string selectSql = String.Format("select count(*) from Students where StuId = '{0}'", this.txtStuId.Text);

                //执行查询操作
                int result = (int)DBHelper.executeScalar(selectSql);

                //如果学号已存在，则提示用户重新输入，并终止操作。
                if (result >= 1)
                {
                    MessageBox.Show("该学号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtStuId.Focus();
                    return;
                }

                //添加记录用的SQL语句
                string insertSql = String.Format("insert into Students (StuId, StuName, StuPwd, Sex, ClassId, DormId, Telephone, HomeAddress, HomePhone) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                    this.txtStuId.Text, this.txtStuName.Text, "888888", this.cboSex.Text, this.cboClassName.SelectedValue, this.cboDormName.SelectedValue,
                    this.txtTelephone.Text, this.txtHomeAddress.Text, this.txtHomePhone.Text);

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
                string updateSql = String.Format("update Students set StuName = '{0}', Sex = '{1}', ClassId = '{2}', DormId = '{3}', Telephone = '{4}', HomeAddress = '{5}', HomePhone = '{6}' where StuId = '{7}'",
                    this.txtStuName.Text, this.cboSex.Text, this.cboClassName.SelectedValue, this.cboDormName.SelectedValue, this.txtTelephone.Text, this.txtHomeAddress.Text, this.txtHomePhone.Text, this.txtStuId.Text);

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
                    case "学号":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("StuId like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "姓名":
                        {
                            dataView.RowFilter = String.Format("StuName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "性别":
                        {
                            dataView.RowFilter = String.Format("Sex like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "班级名称":
                        {
                            dataView.RowFilter = String.Format("ClassName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "宿舍名称":
                        {
                            dataView.RowFilter = String.Format("DormName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "联系电话":
                        {
                            dataView.RowFilter = String.Format("Telephone like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "家庭住址":
                        {
                            dataView.RowFilter = String.Format("HomeAddress like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "家庭电话":
                        {
                            dataView.RowFilter = String.Format("HomePhone like '%{0}%'", this.txtCondition.Text);
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