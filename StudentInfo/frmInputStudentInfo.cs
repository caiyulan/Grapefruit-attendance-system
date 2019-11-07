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
    public partial class frmInputStudentInfo : Form
    {
        // 定义存储数据的临时表
        private DataTable dt;

        public frmInputStudentInfo()
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

            //检查后台数据库的 Students 表中是否存在重复的学号
            string selectSql = String.Format("select count(*) from Students where StuId = '{0}'", this.txtStuId.Text);

            //执行查询操作
            int result = (int)DBHelper.executeScalar(selectSql);

            //如果学号已存在，则提示用户重新输入，并终止操作。
            if (result >= 1)
            {
                MessageBox.Show("该学号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuId.Focus();
                return false;
            }

            //检查临时表中是否存在重复的学号
            DataRow[] dataRowArray = null;

            dataRowArray = dt.Select(String.Format("StuId = '{0}'", this.txtStuId.Text));

            if (dataRowArray.Length >= 1)
            {
                MessageBox.Show("该学号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtStuId.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmInputStudentInf_Load(object sender, EventArgs e)
        {
            // 初始化班级名称组合框
            this.FillClassNameComboBox();

            // 初始化宿舍名称组合框
            this.FillDormNameComboBox();

            try
            {
                // 创建存储数据的临时表
                dt = new DataTable("Students");

                // 添加列
                dt.Columns.Add("StuId", typeof(string));
                dt.Columns.Add("StuName", typeof(string));
                dt.Columns.Add("Sex", typeof(string));
                dt.Columns.Add("ClassId", typeof(string));
                dt.Columns.Add("DormId", typeof(string));
                dt.Columns.Add("Telephone", typeof(string));
                dt.Columns.Add("HomeAddress", typeof(string));
                dt.Columns.Add("HomePhone", typeof(string));

                this.btnNext.Enabled = false;   //禁用“下一条”按钮
                this.btnSave.Enabled = false;   //禁用“保存”按钮
                this.btnCancel.Enabled = false; //禁用“取消”按钮

                // 清空文本框
                this.ClearTextBox();

                // 锁定文本框
                this.LockedTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 录入
        private void btnInput_Click(object sender, EventArgs e)
        {
            // 清空临时表
            dt.Rows.Clear();

            //清空文本框
            this.ClearTextBox();

            //解除锁定
            this.UnLockedTextBox();

            this.btnInput.Enabled = false; //禁用“录入”按钮
            this.btnNext.Enabled = true;   //启用“下一条”按钮
            this.btnSave.Enabled = true;   //启用“保存”按钮
            this.btnCancel.Enabled = true; //启用“取消”按钮

            this.txtStuId.Focus();
        }

        // 下一条
        private void btnNext_Click(object sender, EventArgs e)
        {
            // 验证用户输入
            if (this.ValidateInput() == false)
            {
                return;
            }

            try
            {
                // 添加新行
                DataRow dr = dt.NewRow();
                dr["StuId"] = this.txtStuId.Text;
                dr["StuName"] = this.txtStuName.Text;
                dr["Sex"] = this.cboSex.Text;
                dr["ClassId"] = this.cboClassName.SelectedValue;
                dr["DormId"] = this.cboDormName.SelectedValue;
                dr["Telephone"] = this.txtTelephone.Text;
                dr["HomeAddress"] = this.txtHomeAddress.Text;
                dr["HomePhone"] = this.txtHomePhone.Text;

                // 加入新行
                dt.Rows.Add(dr);

                //清空文本框
                this.ClearTextBox();

                this.txtStuId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 验证用户输入
            if (this.ValidateInput() == false)
            {
                return;
            }

            try
            {
                // 在临时表中添加新行，以保存最后输入的一条记录。
                DataRow dr = dt.NewRow();
                dr["StuId"] = this.txtStuId.Text;
                dr["StuName"] = this.txtStuName.Text;
                dr["Sex"] = this.cboSex.Text;
                dr["ClassId"] = this.cboClassName.SelectedValue;
                dr["DormId"] = this.cboDormName.SelectedValue;
                dr["Telephone"] = this.txtTelephone.Text;
                dr["HomeAddress"] = this.txtHomeAddress.Text;
                dr["HomePhone"] = this.txtHomePhone.Text;

                // 加入新行
                dt.Rows.Add(dr);

                int insertResult = 0;

                // 遍历临时表，取出临时表中的每一行，并保存到后台数据库中。
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //添加记录用的SQL语句

                    string insertSql = String.Format("insert into Students (StuId, StuName, StuPwd, Sex, ClassId, DormId, Telephone, HomeAddress, HomePhone) " + 
                        "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}') ",
                        dt.Rows[i]["StuId"].ToString(),
                        dt.Rows[i]["StuName"].ToString(),
                        "888888",
                        dt.Rows[i]["Sex"].ToString(),
                        dt.Rows[i]["ClassId"].ToString(),
                        dt.Rows[i]["DormId"].ToString(),
                        dt.Rows[i]["Telephone"].ToString(),
                        dt.Rows[i]["HomeAddress"].ToString(),
                        dt.Rows[i]["HomePhone"].ToString());

                    //执行添加操作
                    insertResult = DBHelper.executeInsertSql(insertSql);
                }

                if (insertResult >= 1)
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 清空临时表
                    dt.Rows.Clear();

                    //锁定文本框
                    this.LockedTextBox();

                    this.btnInput.Enabled = true;    //启用“录入”按钮
                    this.btnNext.Enabled = false;    //禁用“下一条”按钮
                    this.btnSave.Enabled = false;    //禁用“保存”按钮
                    this.btnCancel.Enabled = false;  //禁用“取消”按钮
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 清空临时表
            dt.Rows.Clear();

            //清空文本框
            this.ClearTextBox();

            //锁定文本框
            this.LockedTextBox();

            this.btnInput.Enabled = true;    //启用“录入”按钮
            this.btnNext.Enabled = false;    //禁用“下一条”按钮
            this.btnSave.Enabled = false;    //禁用“保存”按钮
            this.btnCancel.Enabled = false;  //禁用“取消”按钮
        }
    }
}