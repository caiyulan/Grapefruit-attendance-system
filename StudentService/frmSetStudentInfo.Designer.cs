namespace StudentAttendanceMgr.StudentService
{
    partial class frmSetStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetStudentInfo));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblDormName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuId = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtDormName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(125, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(378, 254);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(76, 23);
            this.btnBrowser.TabIndex = 23;
            this.btnBrowser.Text = "更改照片";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(378, 51);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(150, 175);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 22;
            this.picPhoto.TabStop = false;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(376, 29);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(65, 12);
            this.lblPhoto.TabIndex = 21;
            this.lblPhoto.Text = "个人照片：";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(125, 348);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(205, 21);
            this.txtHomePhone.TabIndex = 68;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(125, 302);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(205, 21);
            this.txtHomeAddress.TabIndex = 67;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(125, 256);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(205, 21);
            this.txtTelephone.TabIndex = 66;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(125, 72);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(205, 21);
            this.txtStuName.TabIndex = 0;
            // 
            // txtStuId
            // 
            this.txtStuId.Location = new System.Drawing.Point(125, 26);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.ReadOnly = true;
            this.txtStuId.Size = new System.Drawing.Size(205, 21);
            this.txtStuId.TabIndex = 64;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(125, 118);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(205, 20);
            this.cboSex.TabIndex = 61;
            this.cboSex.Text = "男";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(54, 351);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(65, 12);
            this.lblHomePhone.TabIndex = 60;
            this.lblHomePhone.Text = "家庭电话：";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(54, 305);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(65, 12);
            this.lblHomeAddress.TabIndex = 59;
            this.lblHomeAddress.Text = "家庭住址：";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(54, 259);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(65, 12);
            this.lblTelephone.TabIndex = 58;
            this.lblTelephone.Text = "联系电话：";
            // 
            // lblDormName
            // 
            this.lblDormName.AutoSize = true;
            this.lblDormName.Location = new System.Drawing.Point(54, 213);
            this.lblDormName.Name = "lblDormName";
            this.lblDormName.Size = new System.Drawing.Size(65, 12);
            this.lblDormName.TabIndex = 57;
            this.lblDormName.Text = "宿舍名称：";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(54, 167);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(65, 12);
            this.lblClassName.TabIndex = 56;
            this.lblClassName.Text = "班级名称：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(54, 121);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 55;
            this.lblSex.Text = "性    别：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(54, 75);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(65, 12);
            this.lblStuName.TabIndex = 54;
            this.lblStuName.Text = "姓    名：";
            // 
            // lblStuId
            // 
            this.lblStuId.AutoSize = true;
            this.lblStuId.Location = new System.Drawing.Point(54, 29);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(65, 12);
            this.lblStuId.TabIndex = 53;
            this.lblStuId.Text = "学    号：";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(125, 164);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(205, 21);
            this.txtClassName.TabIndex = 69;
            // 
            // txtDormName
            // 
            this.txtDormName.Location = new System.Drawing.Point(125, 210);
            this.txtDormName.Name = "txtDormName";
            this.txtDormName.ReadOnly = true;
            this.txtDormName.Size = new System.Drawing.Size(205, 21);
            this.txtDormName.TabIndex = 70;
            // 
            // frmSetStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 468);
            this.Controls.Add(this.txtDormName);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuId);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblDormName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lblStuId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.lblPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSetStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置个人资料";
            this.Load += new System.EventHandler(this.frmSetStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblDormName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtDormName;
    }
}