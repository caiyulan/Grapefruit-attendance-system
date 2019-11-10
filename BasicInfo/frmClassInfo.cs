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
    public partial class frmClassInfo : Form
    {
        private int AddOrEdit = 0; //标记是添加或修改了记录，0表示添加，1表示修改

        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;
        
        public frmClassInfo()
        {
            InitializeComponent();
        }

        // 填充院系名称组合框
        private void FillDepNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select DepId, DepName from Departments";

                //创建数据集
                DataSet dsDepartment = new DataSet("Attendance");

                //填充数据集
                dsDepartment = DBHelper.getDataSet(selectSql, "Departments");

                //指定“院系名称组合框”的数据源
                this.cboDepName.DataSource = dsDepartment.Tables["Departments"];
                this.cboDepName.DisplayMember = "DepName";
                this.cboDepName.ValueMember = "DepId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 根据院系名称组合框中的项，动态设置专业名称组合框中的项。
        private void cboDepName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // 先清空专业名称组合框
                this.cboSpecialName.Text = "";
                
                //查询记录用的SQL语句
                string selectSql = String.Format("select SpecialId, SpecialName from Specialities s, Departments d where s.DepId = d.DepId and DepName = '{0}' order by SpecialId",
                    this.cboDepName.Text);

                //创建数据集
                DataSet dsSpeciality = new DataSet("Attendance");

                //填充数据集
                dsSpeciality = DBHelper.getDataSet(selectSql, "Specialities");

                //指定“专业名称组合框”的数据源
                this.cboSpecialName.DataSource = dsSpeciality.Tables["Specialities"];
                this.cboSpecialName.DisplayMember = "SpecialName";
                this.cboSpecialName.ValueMember = "SpecialId";

                if (this.cboSpecialName.Items.Count > 0)
                {
                    this.cboSpecialName.SelectedIndex = 0;  //默认选中第一个专业
                }
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
                string selectSql = "select ClassId, ClassName, DepName, SpecialName from Classes c, Departments d, Specialities s where c.DepId = d.DepId and c.SpecialId = s.SpecialId";

                //清空数据集
                dataSet.Tables["Classes"].Clear();

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Classes");

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Classes"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空文本框
        private void ClearTextBox()
        {
            this.txtClassId.Clear();
            this.txtClassName.Clear();
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.txtClassId.ReadOnly = true;
            this.txtClassName.ReadOnly = true;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.txtClassId.ReadOnly = false;
            this.txtClassName.ReadOnly = false;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.txtClassId.Text.Trim() == "")
            {
                MessageBox.Show("请输入班级编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtClassId.Focus();
                return false;
            }
            else if (this.txtClassName.Text.Trim() == "")
            {
                MessageBox.Show("请输入班级名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtClassName.Focus();
                return false;
            }
            else if (this.cboDepName.Text.Trim() == "")
            {
                MessageBox.Show("请输入院系名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboDepName.Focus();
                return false;
            }
            else if (this.cboSpecialName.Text.Trim() == "")
            {
                MessageBox.Show("请输入专业名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSpecialName.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmClassInfo_Load(object sender, EventArgs e)
        {
            // 初始化院系名称组合框
            this.FillDepNameComboBox();

            try
            {
                //查询记录用的SQL语句
                string selectSql = "select ClassId, ClassName, DepName, SpecialName from Classes c, Departments d, Specialities s where c.DepId = d.DepId and c.SpecialId = s.SpecialId";

                //创建数据集 DataSet 对象
                dataSet = new DataSet("Attendance");

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Classes");

                //创建数据视图 DataView 对象
                dataView = new DataView();

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Classes"];

                //创建 BindingSource 对象，将 BindingSource 组件绑定到数据视图。
                bindSource = new BindingSource(dataView, "");

                //建立复杂数据绑定，将 DataGridView 控件绑定到 BindingSource组件。
                this.dgvClasses.DataSource = bindSource;

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
        private void dgvClasses_SelectionChanged(object sender, EventArgs e)
        {
            // 判断当前DataGridView控件中是否有记录，如果没有，则终止操作。
            if (this.dgvClasses.Rows.Count <= 0)
            {
                return;
            }

            //将 DataGridView 控件中当前行各列的值显示在各文本框控件中
            //显示该行的院系信息
            this.txtClassId.Text = this.dgvClasses.CurrentRow.Cells["ClassId"].Value.ToString();
            this.txtClassName.Text = this.dgvClasses.CurrentRow.Cells["ClassName"].Value.ToString();
            this.cboDepName.Text = this.dgvClasses.CurrentRow.Cells["DepName"].Value.ToString();
            this.cboSpecialName.Text = this.dgvClasses.CurrentRow.Cells["SpecialName"].Value.ToString();
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

            this.txtClassId.Focus();
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 1;

            //解除锁定
            this.UnLockedTextBox();

            this.txtClassId.ReadOnly = true;  //不允许修改“班级编号”

            this.btnSave.Enabled = true;    //启用“保存”按钮
            this.btnCancel.Enabled = true;  //启用“取消”按钮

            this.txtClassName.Focus();
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvClasses.RowCount <= 0)
            {
                MessageBox.Show("没有记录可以删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录用的SQL语句
                string deleteSql = String.Format("delete from Classes where ClassId = '{0}'", this.txtClassId.Text);

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
                //判断班级编号是否已存在
                string selectSql = String.Format("select count(*) from Classes where ClassId = '{0}'", this.txtClassId.Text);

                //执行查询操作
                int result = (int)DBHelper.executeScalar(selectSql);

                //如果班级编号已存在，则提示用户重新输入，并终止操作。
                if (result >= 1)
                {
                    MessageBox.Show("该班级编号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtClassId.Focus();
                    return;
                }

                //添加记录用的SQL语句
                string insertSql = String.Format("insert into Classes (ClassId, ClassName, DepId, SpecialId) values ('{0}', '{1}', '{2}', '{3}')",
                    this.txtClassId.Text, this.txtClassName.Text, (string)this.cboDepName.SelectedValue, (string)this.cboSpecialName.SelectedValue);

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
                string updateSql = String.Format("update Classes set ClassName = '{0}', DepId = '{1}', SpecialId = '{2}' where ClassId = '{3}'",
                    this.txtClassName.Text, this.cboDepName.SelectedValue, this.cboSpecialName.SelectedValue, this.txtClassId.Text);

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
                    case "班级编号":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("ClassId like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "班级名称":
                        {
                            dataView.RowFilter = String.Format("ClassName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "院系名称":
                        {
                            dataView.RowFilter = String.Format("DepName like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "专业名称":
                        {
                            dataView.RowFilter = String.Format("SpecialName like '%{0}%'", this.txtCondition.Text);
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