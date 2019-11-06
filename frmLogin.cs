using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // 窗体加载 
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //设置皮肤文件
            this.skinEngine.SkinFile = @"skin\MSN.ssk"; //该皮肤文件放在当前工程的bin\Debug\skin目录下
        }

        //验证用户输入
        private bool ValidateInput()
        {
            if (this.txtLoginId.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtLoginId.Focus();
                return false;
            }
            else if (this.txtLoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtLoginPwd.Focus();
                return false;
            }
            else if (this.cboUserType.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户类型", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboUserType.Focus();
                return false;
            }
            return true;
        }

        //登录
        private void btnOK_Click(object sender, EventArgs e)
        {

            //测试数据连接
            frmConnectServer frm = new frmConnectServer();

            if (frm.CheckConnection() == false)
            {
                //连接失败，打开“连接服务器”窗体，配置数据库连接。
                MessageBox.Show("请配置数据库连接后，重新登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.ShowDialog();
                return;
            }
            else
            {
                //连接成功，获取数据库连接信息，设置连接字符串。
                CommonInfo.connString = frm.getConnectionString();
            }

            int result = -1;  //查找结果

            //如果用户输入验证通过，则验证账号和密码是否正确
            if (ValidateInput())
            {
                //根据选择的用户类型，分别设置查询用的sql语句
                string selectSql = "";

                if (this.cboUserType.Text.Trim() == "学生")
                {
                    selectSql = string.Format("select count(*) from Students where StuId = '{0}' and StuPwd = '{1}'",
                        this.txtLoginId.Text.Trim(), this.txtLoginPwd.Text.Trim());
                }
                else if (this.cboUserType.Text.Trim() == "教师")
                {
                    selectSql = string.Format("select count(*) from Teachers where TeacherId = '{0}' and TeacherPwd = '{1}'",
                        this.txtLoginId.Text.Trim(), this.txtLoginPwd.Text.Trim());
                }
                else if (this.cboUserType.Text.Trim() == "系统管理员")
                {
                    selectSql = string.Format("select count(*) from Users where UserId = '{0}' and UserPwd = '{1}'",
                        this.txtLoginId.Text.Trim(), this.txtLoginPwd.Text.Trim());
                }

                result = Convert.ToInt32(DBHelper.executeScalar(selectSql));

                if (result == 1) //账号和密码验证通过  
                {
                    //设置当前登录用户的账号
                    CommonInfo.userId = this.txtLoginId.Text.Trim();

                    //设置当前登录用户的类型
                    CommonInfo.userType = this.cboUserType.Text.Trim();

                    //隐藏登录窗口
                    this.Hide();

                    //打开主窗口
                    frmMain main = new frmMain();
                    main.Show();
                }
                else //登录账号、登录密码和用户类型验证未通过 
                {
                    MessageBox.Show("您输入的登录账号、登录密码或用户类型有误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //退出
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtLoginPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //在“登录密码”文本框中按下回车键，相当于单击“登录”按钮。
            if (e.KeyChar == 13)
            {
                this.btnOK_Click(sender, e);
            }
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}