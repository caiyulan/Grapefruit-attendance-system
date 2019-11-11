namespace StudentAttendanceMgr.SysManager
{
    partial class frmEditAdminPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAdminPwd));
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblConfirmNewPwd = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPwd = new System.Windows.Forms.TextBox();
            this.grbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.txtConfirmNewPwd);
            this.grbMain.Controls.Add(this.txtNewPwd);
            this.grbMain.Controls.Add(this.txtOldPwd);
            this.grbMain.Controls.Add(this.txtUserName);
            this.grbMain.Controls.Add(this.lblConfirmNewPwd);
            this.grbMain.Controls.Add(this.lblNewPwd);
            this.grbMain.Controls.Add(this.lblOldPwd);
            this.grbMain.Controls.Add(this.lblUserName);
            this.grbMain.Location = new System.Drawing.Point(12, 12);
            this.grbMain.Name = "grbMain";
            this.grbMain.Size = new System.Drawing.Size(370, 199);
            this.grbMain.TabIndex = 0;
            this.grbMain.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(66, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(52, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名称：";
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Location = new System.Drawing.Point(52, 73);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(53, 12);
            this.lblOldPwd.TabIndex = 1;
            this.lblOldPwd.Text = "旧密码：";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(52, 118);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(53, 12);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = "新密码：";
            // 
            // lblConfirmNewPwd
            // 
            this.lblConfirmNewPwd.AutoSize = true;
            this.lblConfirmNewPwd.Location = new System.Drawing.Point(52, 163);
            this.lblConfirmNewPwd.Name = "lblConfirmNewPwd";
            this.lblConfirmNewPwd.Size = new System.Drawing.Size(77, 12);
            this.lblConfirmNewPwd.TabIndex = 3;
            this.lblConfirmNewPwd.Text = "确认新密码：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(135, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(165, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(135, 70);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(165, 21);
            this.txtOldPwd.TabIndex = 5;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(135, 115);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(165, 21);
            this.txtNewPwd.TabIndex = 6;
            // 
            // txtConfirmNewPwd
            // 
            this.txtConfirmNewPwd.Location = new System.Drawing.Point(135, 160);
            this.txtConfirmNewPwd.Name = "txtConfirmNewPwd";
            this.txtConfirmNewPwd.PasswordChar = '*';
            this.txtConfirmNewPwd.Size = new System.Drawing.Size(165, 21);
            this.txtConfirmNewPwd.TabIndex = 7;
            // 
            // frmEditAdminPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 268);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditAdminPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.frmEditAdminPwd_Load);
            this.grbMain.ResumeLayout(false);
            this.grbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblConfirmNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtConfirmNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtUserName;
    }
}