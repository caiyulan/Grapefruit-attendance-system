namespace StudentAttendanceMgr
{
    partial class frmConnectServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectServer));
            this.grbValidateType = new System.Windows.Forms.GroupBox();
            this.rbtnWindows = new System.Windows.Forms.RadioButton();
            this.rbtnSqlServer = new System.Windows.Forms.RadioButton();
            this.grbValidateInfo = new System.Windows.Forms.GroupBox();
            this.cboDataBaseName = new System.Windows.Forms.ComboBox();
            this.cboServerAddress = new System.Windows.Forms.ComboBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbValidateType.SuspendLayout();
            this.grbValidateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbValidateType
            // 
            this.grbValidateType.Controls.Add(this.rbtnWindows);
            this.grbValidateType.Controls.Add(this.rbtnSqlServer);
            this.grbValidateType.Location = new System.Drawing.Point(21, 12);
            this.grbValidateType.Name = "grbValidateType";
            this.grbValidateType.Size = new System.Drawing.Size(251, 83);
            this.grbValidateType.TabIndex = 0;
            this.grbValidateType.TabStop = false;
            this.grbValidateType.Text = "身份验证方式";
            // 
            // rbtnWindows
            // 
            this.rbtnWindows.Checked = true;
            this.rbtnWindows.Location = new System.Drawing.Point(22, 20);
            this.rbtnWindows.Name = "rbtnWindows";
            this.rbtnWindows.Size = new System.Drawing.Size(144, 16);
            this.rbtnWindows.TabIndex = 2;
            this.rbtnWindows.TabStop = true;
            this.rbtnWindows.Text = "Windows 身份验证";
            this.rbtnWindows.CheckedChanged += new System.EventHandler(this.rbtnWindows_CheckedChanged);
            // 
            // rbtnSqlServer
            // 
            this.rbtnSqlServer.Location = new System.Drawing.Point(22, 53);
            this.rbtnSqlServer.Name = "rbtnSqlServer";
            this.rbtnSqlServer.Size = new System.Drawing.Size(144, 16);
            this.rbtnSqlServer.TabIndex = 3;
            this.rbtnSqlServer.Text = "SQL Server 身份验证";
            this.rbtnSqlServer.CheckedChanged += new System.EventHandler(this.rbtnSqlServer_CheckedChanged);
            // 
            // grbValidateInfo
            // 
            this.grbValidateInfo.Controls.Add(this.cboDataBaseName);
            this.grbValidateInfo.Controls.Add(this.cboServerAddress);
            this.grbValidateInfo.Controls.Add(this.txtUserPwd);
            this.grbValidateInfo.Controls.Add(this.txtUserID);
            this.grbValidateInfo.Controls.Add(this.label4);
            this.grbValidateInfo.Controls.Add(this.label3);
            this.grbValidateInfo.Controls.Add(this.label2);
            this.grbValidateInfo.Controls.Add(this.label1);
            this.grbValidateInfo.Location = new System.Drawing.Point(21, 110);
            this.grbValidateInfo.Name = "grbValidateInfo";
            this.grbValidateInfo.Size = new System.Drawing.Size(251, 171);
            this.grbValidateInfo.TabIndex = 1;
            this.grbValidateInfo.TabStop = false;
            this.grbValidateInfo.Text = "身份验证信息";
            // 
            // cboDataBaseName
            // 
            this.cboDataBaseName.Items.AddRange(new object[] {
            "Attendance"});
            this.cboDataBaseName.Location = new System.Drawing.Point(106, 60);
            this.cboDataBaseName.Name = "cboDataBaseName";
            this.cboDataBaseName.Size = new System.Drawing.Size(124, 20);
            this.cboDataBaseName.TabIndex = 21;
            this.cboDataBaseName.Text = "Attendance";
            // 
            // cboServerAddress
            // 
            this.cboServerAddress.Items.AddRange(new object[] {
            "(local)"});
            this.cboServerAddress.Location = new System.Drawing.Point(105, 24);
            this.cboServerAddress.Name = "cboServerAddress";
            this.cboServerAddress.Size = new System.Drawing.Size(124, 20);
            this.cboServerAddress.TabIndex = 20;
            this.cboServerAddress.Text = "(local)";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Enabled = false;
            this.txtUserPwd.Location = new System.Drawing.Point(106, 133);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(124, 21);
            this.txtUserPwd.TabIndex = 19;
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(106, 96);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(124, 21);
            this.txtUserID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "数据库密码：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "数据库用户：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "数据库名称：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "服务器地址：";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(21, 298);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(75, 23);
            this.btnTestConnection.TabIndex = 2;
            this.btnTestConnection.Text = "测试连接";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(139, 298);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确　定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmConnectServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 343);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.grbValidateInfo);
            this.Controls.Add(this.grbValidateType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConnectServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接服务器";
            this.grbValidateType.ResumeLayout(false);
            this.grbValidateInfo.ResumeLayout(false);
            this.grbValidateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbValidateType;
        private System.Windows.Forms.RadioButton rbtnWindows;
        private System.Windows.Forms.RadioButton rbtnSqlServer;
        private System.Windows.Forms.GroupBox grbValidateInfo;
        private System.Windows.Forms.ComboBox cboDataBaseName;
        private System.Windows.Forms.ComboBox cboServerAddress;
        private System.Windows.Forms.TextBox txtUserPwd;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}