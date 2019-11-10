namespace StudentAttendanceMgr.TeacherService
{
    partial class frmSetTeacherInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetTeacherInfo));
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblOfficeName = new System.Windows.Forms.Label();
            this.lblStaffRoomName = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtStaffRoomName = new System.Windows.Forms.TextBox();
            this.txtOfficeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(141, 331);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(205, 21);
            this.txtTelephone.TabIndex = 94;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(58, 334);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(65, 12);
            this.lblTelephone.TabIndex = 91;
            this.lblTelephone.Text = "联系电话：";
            // 
            // lblOfficeName
            // 
            this.lblOfficeName.AutoSize = true;
            this.lblOfficeName.Location = new System.Drawing.Point(46, 278);
            this.lblOfficeName.Name = "lblOfficeName";
            this.lblOfficeName.Size = new System.Drawing.Size(77, 12);
            this.lblOfficeName.TabIndex = 90;
            this.lblOfficeName.Text = "办公室名称：";
            // 
            // lblStaffRoomName
            // 
            this.lblStaffRoomName.AutoSize = true;
            this.lblStaffRoomName.Location = new System.Drawing.Point(46, 222);
            this.lblStaffRoomName.Name = "lblStaffRoomName";
            this.lblStaffRoomName.Size = new System.Drawing.Size(77, 12);
            this.lblStaffRoomName.TabIndex = 89;
            this.lblStaffRoomName.Text = "教研室名称：";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(141, 106);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(205, 21);
            this.txtTeacherName.TabIndex = 88;
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(141, 49);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.ReadOnly = true;
            this.txtTeacherId.Size = new System.Drawing.Size(205, 21);
            this.txtTeacherId.TabIndex = 87;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(141, 163);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(205, 20);
            this.cboSex.TabIndex = 86;
            this.cboSex.Text = "男";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(58, 166);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 85;
            this.lblSex.Text = "性    别：";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(58, 109);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(65, 12);
            this.lblTeacherName.TabIndex = 84;
            this.lblTeacherName.Text = "姓    名：";
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.AutoSize = true;
            this.lblTeacherId.Location = new System.Drawing.Point(58, 52);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(65, 12);
            this.lblTeacherId.TabIndex = 83;
            this.lblTeacherId.Text = "工    号：";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(385, 272);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(76, 23);
            this.btnBrowser.TabIndex = 97;
            this.btnBrowser.Text = "更改照片";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(385, 69);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(145, 170);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 96;
            this.picPhoto.TabStop = false;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(383, 52);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(65, 12);
            this.lblPhoto.TabIndex = 95;
            this.lblPhoto.Text = "个人照片：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(141, 386);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 98;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtStaffRoomName
            // 
            this.txtStaffRoomName.Location = new System.Drawing.Point(141, 218);
            this.txtStaffRoomName.Name = "txtStaffRoomName";
            this.txtStaffRoomName.ReadOnly = true;
            this.txtStaffRoomName.Size = new System.Drawing.Size(205, 21);
            this.txtStaffRoomName.TabIndex = 100;
            // 
            // txtOfficeName
            // 
            this.txtOfficeName.Location = new System.Drawing.Point(141, 274);
            this.txtOfficeName.Name = "txtOfficeName";
            this.txtOfficeName.ReadOnly = true;
            this.txtOfficeName.Size = new System.Drawing.Size(205, 21);
            this.txtOfficeName.TabIndex = 101;
            // 
            // frmSetTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 468);
            this.Controls.Add(this.txtOfficeName);
            this.Controls.Add(this.txtStaffRoomName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblOfficeName);
            this.Controls.Add(this.lblStaffRoomName);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblTeacherId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSetTeacherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置个人资料";
            this.Load += new System.EventHandler(this.frmSetTeacherInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblOfficeName;
        private System.Windows.Forms.Label lblStaffRoomName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtStaffRoomName;
        private System.Windows.Forms.TextBox txtOfficeName;
    }
}