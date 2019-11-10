using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace StudentAttendanceMgr
{
    public partial class frmConnectServer : Form
    {
        public frmConnectServer()
        {
            InitializeComponent();
        }

        //按Windows身份验证，检查能否成功建立数据库连接。
        private bool CheckConnection(string serverAddress, string dataBaseName)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection();

            try
            {
                string connString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=true", serverAddress, dataBaseName);

                connection.ConnectionString = connString;

                connection.Open();

                result = true;   //建立数据库连接成功，返回true。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;  //建立数据库连接失败，返回false。
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        //按SQL Server身份验证，检查能否成功建立数据库连接。
        private bool CheckConnection(string serverAddress, string dataBaseName, string userId, string userPwd)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection();

            try
            {
                string connString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Pwd={3}", serverAddress, dataBaseName, userId, userPwd);

                connection.ConnectionString = connString;

                connection.Open();

                result = true;   //建立数据库连接成功，返回true。
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;  //建立数据库连接失败，返回false。
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        //测试数据库连接
        public bool CheckConnection()
        {
            bool result = false;

            string xmlFilePath = "ConnectServer.xml";  //连接服务器的XML配置文件放在当前工程的bin\Debug目录下

            if (File.Exists(xmlFilePath) == false)
            {
                MessageBox.Show("连接服务器的XML配置文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            //创建XML文档对象
            XmlDocument doc = new XmlDocument();

            //加载XML文档
            doc.Load(xmlFilePath);

            //读取所有节点
            XmlNamespaceManager xnm = new XmlNamespaceManager(doc.NameTable);

            //读取“ValidateType”节点的值，获取身份验证类型。
            XmlNode node_ValidateType = doc.SelectSingleNode("/ConnectServer/ValidateType", xnm);
            string validateType = node_ValidateType.InnerText;

            //读取“ServerAddress”节点的值，获取服务器地址。
            XmlNode node_ServerAddress = doc.SelectSingleNode("/ConnectServer/ServerAddress", xnm);
            string serverAddress = node_ServerAddress.InnerText;

            //读取“DataBaseName”节点的值，获取数据库名称。
            XmlNode node_DataBaseName = doc.SelectSingleNode("/ConnectServer/DataBaseName", xnm);
            string dataBaseName = node_DataBaseName.InnerText;

            //读取“UserId”节点的值，获取用户名。
            XmlNode node_UserId = doc.SelectSingleNode("/ConnectServer/UserId", xnm);
            string userId = node_UserId.InnerText;

            //读取“UserPwd”节点的值，获取密码。
            XmlNode node_UserPwd = doc.SelectSingleNode("/ConnectServer/UserPwd", xnm);
            string UserPwd = node_UserPwd.InnerText;

            //测试能否成功连接服务器
            if (validateType == "Windows")
            {
                if (CheckConnection(serverAddress, dataBaseName) == true)
                    result = true;
                else
                    result = false;
            }
            else if (validateType == "SQL Server")
            {
                if (CheckConnection(serverAddress, dataBaseName, userId, UserPwd) == true)
                    result = true;
                else
                    result = false;
            }

            return result;
        }

        //从XML配置文件中获取数据库连接信息
        public string getConnectionString()
        {
            string connString = "";
            
            string xmlFilePath = "ConnectServer.xml";

            XmlDocument doc = new XmlDocument();

            doc.Load(xmlFilePath);

            XmlNamespaceManager xnm = new XmlNamespaceManager(doc.NameTable);

            //获取身份验证类型
            XmlNode node_ValidateType = doc.SelectSingleNode("/ConnectServer/ValidateType", xnm);
            string validateType = node_ValidateType.InnerText;

            //获取服务器地址
            XmlNode node_ServerAddress = doc.SelectSingleNode("/ConnectServer/ServerAddress", xnm);
            string serverAddress = node_ServerAddress.InnerText;

            //获取数据库名称
            XmlNode node_DataBaseName = doc.SelectSingleNode("/ConnectServer/DataBaseName", xnm);
            string dataBaseName = node_DataBaseName.InnerText;

            //获取用户名
            XmlNode node_UserId = doc.SelectSingleNode("/ConnectServer/UserId", xnm);
            string userId = node_UserId.InnerText;

            //获取密码
            XmlNode node_UserPwd = doc.SelectSingleNode("/ConnectServer/UserPwd", xnm);
            string userPwd = node_UserPwd.InnerText;

            if (validateType == "Windows")
            {
                connString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=true", serverAddress, dataBaseName);
            }
            else if (validateType == "SQL Server")
            {
                connString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Pwd={3}", serverAddress, dataBaseName, userId, userPwd);
            }

            return connString;
        }

        //选择Windows身份验证，不需要输入用户名和密码。
        private void rbtnWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWindows.Checked == true)
            {
                this.txtUserID.Enabled = false;
                this.txtUserPwd.Enabled = false;
            }
            else
            {
                this.txtUserID.Enabled = true;
                this.txtUserPwd.Enabled = true;
            }
        }

        //选择SQL Server身份验证，需要输入用户名和密码
        private void rbtnSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSqlServer.Checked == true)
            {
                this.txtUserID.Enabled = true;
                this.txtUserPwd.Enabled = true;
            }
            else
            {
                this.txtUserID.Enabled = false;
                this.txtUserPwd.Enabled = false;
            }
        }

        //测试连接
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string serverAddress = this.cboServerAddress.Text.Trim();
            string dataBaseName = this.cboDataBaseName.Text.Trim();
            string userId = this.txtUserID.Text.Trim();
            string userPwd = this.txtUserPwd.Text.Trim();
            
            if (rbtnWindows.Checked == true)
            {
                if (CheckConnection(serverAddress, dataBaseName) == true)
                {
                    MessageBox.Show("按Windows身份验证，连接数据库成功！", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("按Windows身份验证，连接数据库失败！", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnSqlServer.Checked == true)
            {
                if (CheckConnection(serverAddress, dataBaseName, userId, userPwd) == true)
                {
                    MessageBox.Show("按SQL Server身份验证，连接数据库成功！", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("按SQL Server身份验证，连接数据库失败！", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            //将连接服务器的配置信息写入XML配置文件中
            //(1) 连接服务器的配置信息，包括：身份验证方式和身份验证信息
            //(2) XML配置文件位于当前工程的bin\Debug目录下

            string xmlFilePath = "ConnectServer.xml";

            if (File.Exists(xmlFilePath) == false)
            {
                MessageBox.Show("连接服务器的XML配置文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //创建XML文档对象
            XmlDocument doc = new XmlDocument();

            //加载XML文档
            doc.Load(xmlFilePath);

            //读取所有节点
            XmlNamespaceManager xnm = new XmlNamespaceManager(doc.NameTable);

            //读取“ValidateType”节点的值，设置身份验证类型。
            XmlNode node_ValidateType = doc.SelectSingleNode("/ConnectServer/ValidateType", xnm);
            if (rbtnWindows.Checked == true)
            {
                node_ValidateType.InnerText = "Windows";
            }
            else if (rbtnSqlServer.Checked == true)
            {
                node_ValidateType.InnerText = "SQL Server";
            }

            //读取“ServerAddress”节点的值，设置服务器地址。
            XmlNode node_ServerAddress = doc.SelectSingleNode("/ConnectServer/ServerAddress", xnm);
            node_ServerAddress.InnerText = this.cboServerAddress.Text.Trim();

            //读取“DataBaseName”节点的值，设置数据库名称。
            XmlNode node_DataBaseName = doc.SelectSingleNode("/ConnectServer/DataBaseName", xnm);
            node_DataBaseName.InnerText = this.cboDataBaseName.Text.Trim(); ;

            //读取“UserId”节点的值，设置用户名。
            XmlNode node_UserId = doc.SelectSingleNode("/ConnectServer/UserId", xnm);
            node_UserId.InnerText = this.txtUserID.Text.Trim();

            //读取“UserPwd”节点的值，设置密码。
            XmlNode node_UserPwd = doc.SelectSingleNode("/ConnectServer/UserPwd", xnm);
            node_UserPwd.InnerText = this.txtUserPwd.Text.Trim();

            //保存XML文档
            doc.Save(xmlFilePath);

            //关闭窗体
            this.Close();
        }
        
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}