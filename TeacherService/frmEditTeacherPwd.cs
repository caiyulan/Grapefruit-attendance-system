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
    public partial class frmEditTeacherPwd : Form
    {
        // 旧密码
        private string TeacherOldPwd = "";  
        
        public frmEditTeacherPwd()
        {
            InitializeComponent();
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.txtOldPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入旧密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtOldPwd.Focus();
                return false;
            }
            else
            {
                // 验证输入的旧密码是否正确
                if (this.txtOldPwd.Text.Trim() != this.TeacherOldPwd)
                {
                    MessageBox.Show("用户旧密码输入错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtOldPwd.Focus();
                    return false;
                }
            }

            if (this.txtNewPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNewPwd.Focus();
                return false;
            }
            else if (this.txtConfirmNewPwd.Text.Trim() == "")
            {
                MessageBox.Show("请确认新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtConfirmNewPwd.Focus();
                return false;
            }
            else if (this.txtNewPwd.Text.Trim() != this.txtConfirmNewPwd.Text.Trim())
            {
                MessageBox.Show("新密码和确认密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtConfirmNewPwd.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmEditTeacherPwd_Load(object sender, EventArgs e)
        {
            // 获取当前登录用户的用户名称和旧密码
            try
            {
                // 查询记录用的SQL语句
                string selectSql = String.Format("select TeacherName, TeacherPwd from Teachers where TeacherId = '{0}'", CommonInfo.userId);

                SqlCommand command = new SqlCommand(selectSql, DBHelper.connection);

                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }

                SqlDataReader sdr = command.ExecuteReader();

                if (sdr.HasRows)
                {
                    sdr.Read();
                    this.txtTehacherName.Text = sdr["TeacherName"].ToString();
                    this.TeacherOldPwd = sdr["TeacherPwd"].ToString();
                }

                if (sdr.IsClosed == false)
                {
                    sdr.Close();
                }
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

        // 确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            // 验证用户输入
            if (this.ValidateInput() == false)
            {
                return;
            }

            //修改密码

            //修改记录用的SQL语句
            string updateSql = String.Format("update Teachers set TeacherPwd = '{0}' where TeacherId = {1}", this.txtNewPwd.Text.Trim(), CommonInfo.userId);

            //执行修改操作
            int updateResult = DBHelper.executeUpdateSql(updateSql);

            if (updateResult >= 1)
            {
                MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  //关闭窗体
        }
    }
}