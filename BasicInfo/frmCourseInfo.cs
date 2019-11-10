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
    public partial class frmCourseInfo : Form
    {
        private int AddOrEdit = 0; //标记是添加或修改了记录，0表示添加，1表示修改

        //数据集
        private DataSet dataSet;

        //数据视图
        private DataView dataView;

        //定义 BindingSource 对象
        private BindingSource bindSource;
        
        public frmCourseInfo()
        {
            InitializeComponent();
        }

        // 重新填充数据集
        private void FillDataSet()
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = "select CourseId, CourseName from Courses order by CourseId";

                //清空数据集
                dataSet.Tables["Courses"].Clear();

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Courses");

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Courses"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空文本框
        private void ClearTextBox()
        {
            this.txtCourseId.Clear();
            this.txtCourseName.Clear();
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.txtCourseId.ReadOnly = true;
            this.txtCourseName.ReadOnly = true;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.txtCourseId.ReadOnly = false;
            this.txtCourseName.ReadOnly = false;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.txtCourseId.Text.Trim() == "")
            {
                MessageBox.Show("请输入课程编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCourseId.Focus();
                return false;
            }
            else if (this.txtCourseName.Text.Trim() == "")
            {
                MessageBox.Show("请输入课程名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCourseName.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmCourseInfo_Load(object sender, EventArgs e)
        {
            try
            {
                //查询记录用的SQL语句
                string selectSql = "select CourseId, CourseName from Courses order by CourseId";

                //创建数据集 DataSet 对象
                dataSet = new DataSet("Attendance");

                //填充数据集
                dataSet = DBHelper.getDataSet(selectSql, "Courses");

                //创建数据视图 DataView 对象
                dataView = new DataView();

                //指定 DataView 的基础表
                dataView.Table = dataSet.Tables["Courses"];

                //创建 BindingSource 对象，将 BindingSource 组件绑定到数据视图。
                bindSource = new BindingSource(dataView, "");

                //建立复杂数据绑定，将 DataGridView 控件绑定到 BindingSource组件。
                this.dgvCourse.DataSource = bindSource;

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
        private void dgvCourse_SelectionChanged(object sender, EventArgs e)
        {
            // 判断当前DataGridView控件中是否有记录，如果没有，则终止操作。
            if (this.dgvCourse.Rows.Count <= 0)
            {
                return;
            }

            //将 DataGridView 控件中当前行各列的值显示在各文本框控件中
            //显示该行的院系信息
            this.txtCourseId.Text = this.dgvCourse.CurrentRow.Cells["CourseId"].Value.ToString();
            this.txtCourseName.Text = this.dgvCourse.CurrentRow.Cells["CourseName"].Value.ToString();
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

            this.txtCourseId.Focus();
        }

        // 修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.AddOrEdit = 1;

            //解除锁定
            this.UnLockedTextBox();

            this.txtCourseId.ReadOnly = true;  //不允许修改“课程编号”

            this.btnSave.Enabled = true;    //启用“保存”按钮
            this.btnCancel.Enabled = true;  //启用“取消”按钮

            this.txtCourseName.Focus();
        }

        // 删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvCourse.RowCount <= 0)
            {
                MessageBox.Show("没有记录可以删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("您确定要删除这条记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录用的SQL语句
                string deleteSql = String.Format("delete from Courses where CourseId = '{0}'", this.txtCourseId.Text);

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
                //判断课程编号是否已存在
                string selectSql = String.Format("select count(*) from Courses where CourseId = '{0}'", this.txtCourseId.Text);

                //执行查询操作
                int result = (int)DBHelper.executeScalar(selectSql);

                //如果课程编号已存在，则提示用户重新输入，并终止操作。
                if (result >= 1)
                {
                    MessageBox.Show("该课程编号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCourseId.Focus();
                    return;
                }

                //添加记录用的SQL语句
                string insertSql = String.Format("insert into Courses (CourseId, CourseName) values ('{0}', '{1}')", this.txtCourseId.Text, this.txtCourseName.Text);

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
                string updateSql = String.Format("update Courses set CourseName = '{0}' where CourseId = '{1}'", this.txtCourseName.Text, this.txtCourseId.Text);

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
                    case "课程编号":
                        {
                            //根据“查询值文本框”的值进行模糊查询
                            dataView.RowFilter = String.Format("CourseId like '%{0}%'", this.txtCondition.Text);
                            break;
                        }
                    case "课程名称":
                        {
                            dataView.RowFilter = String.Format("CourseName like '%{0}%'", this.txtCondition.Text);
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