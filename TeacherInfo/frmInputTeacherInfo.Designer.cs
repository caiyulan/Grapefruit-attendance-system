namespace StudentAttendanceMgr.TeacherInfo
{
    partial class frmInputTeacherInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputTeacherInfo));
            this.tsslblDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cboOfficeName = new System.Windows.Forms.ComboBox();
            this.cboStaffRoomName = new System.Windows.Forms.ComboBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblOfficeName = new System.Windows.Forms.Label();
            this.lblStaffRoomName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.statusStripDesc = new System.Windows.Forms.StatusStrip();
            this.statusStripDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsslblDesc
            // 
            this.tsslblDesc.Name = "tsslblDesc";
            this.tsslblDesc.Size = new System.Drawing.Size(329, 17);
            this.tsslblDesc.Text = "说明：可连续输入多条记录，输入结束后，单击“下一条”。";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(159, 362);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(205, 21);
            this.txtTelephone.TabIndex = 71;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(159, 110);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(205, 21);
            this.txtTeacherName.TabIndex = 70;
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(159, 47);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(205, 21);
            this.txtTeacherId.TabIndex = 69;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(78, 424);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(55, 23);
            this.btnInput.TabIndex = 68;
            this.btnInput.Text = "录入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(232, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(155, 424);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 23);
            this.btnNext.TabIndex = 65;
            this.btnNext.Text = "下一条";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cboOfficeName
            // 
            this.cboOfficeName.FormattingEnabled = true;
            this.cboOfficeName.Location = new System.Drawing.Point(159, 299);
            this.cboOfficeName.Name = "cboOfficeName";
            this.cboOfficeName.Size = new System.Drawing.Size(205, 20);
            this.cboOfficeName.TabIndex = 64;
            // 
            // cboStaffRoomName
            // 
            this.cboStaffRoomName.FormattingEnabled = true;
            this.cboStaffRoomName.Location = new System.Drawing.Point(159, 236);
            this.cboStaffRoomName.Name = "cboStaffRoomName";
            this.cboStaffRoomName.Size = new System.Drawing.Size(205, 20);
            this.cboStaffRoomName.TabIndex = 63;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(159, 173);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(205, 20);
            this.cboSex.TabIndex = 62;
            this.cboSex.Text = "男";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(76, 365);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(65, 12);
            this.lblTelephone.TabIndex = 59;
            this.lblTelephone.Text = "联系电话：";
            // 
            // lblOfficeName
            // 
            this.lblOfficeName.AutoSize = true;
            this.lblOfficeName.Location = new System.Drawing.Point(76, 302);
            this.lblOfficeName.Name = "lblOfficeName";
            this.lblOfficeName.Size = new System.Drawing.Size(77, 12);
            this.lblOfficeName.TabIndex = 58;
            this.lblOfficeName.Text = "办公室名称：";
            // 
            // lblStaffRoomName
            // 
            this.lblStaffRoomName.AutoSize = true;
            this.lblStaffRoomName.Location = new System.Drawing.Point(76, 239);
            this.lblStaffRoomName.Name = "lblStaffRoomName";
            this.lblStaffRoomName.Size = new System.Drawing.Size(77, 12);
            this.lblStaffRoomName.TabIndex = 57;
            this.lblStaffRoomName.Text = "教研室名称：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(76, 176);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 56;
            this.lblSex.Text = "性    别：";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(76, 113);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(65, 12);
            this.lblTeacherName.TabIndex = 55;
            this.lblTeacherName.Text = "姓    名：";
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.AutoSize = true;
            this.lblTeacherId.Location = new System.Drawing.Point(76, 50);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(65, 12);
            this.lblTeacherId.TabIndex = 54;
            this.lblTeacherId.Text = "工    号：";
            // 
            // statusStripDesc
            // 
            this.statusStripDesc.Enabled = false;
            this.statusStripDesc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDesc});
            this.statusStripDesc.Location = new System.Drawing.Point(0, 546);
            this.statusStripDesc.Name = "statusStripDesc";
            this.statusStripDesc.Size = new System.Drawing.Size(794, 22);
            this.statusStripDesc.TabIndex = 53;
            this.statusStripDesc.Text = "statusStrip1";
            // 
            // frmInputTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cboOfficeName);
            this.Controls.Add(this.cboStaffRoomName);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblOfficeName);
            this.Controls.Add(this.lblStaffRoomName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblTeacherId);
            this.Controls.Add(this.statusStripDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInputTeacherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师信息录入";
            this.Load += new System.EventHandler(this.frmInputTeacherInfo_Load);
            this.statusStripDesc.ResumeLayout(false);
            this.statusStripDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel tsslblDesc;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cboOfficeName;
        private System.Windows.Forms.ComboBox cboStaffRoomName;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblOfficeName;
        private System.Windows.Forms.Label lblStaffRoomName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.StatusStrip statusStripDesc;
    }
}