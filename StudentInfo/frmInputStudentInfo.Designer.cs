namespace StudentAttendanceMgr.StudentInfo
{
    partial class frmInputStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputStudentInfo));
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cboDormName = new System.Windows.Forms.ComboBox();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.tsslblDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblDormName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuId = new System.Windows.Forms.Label();
            this.statusStripDesc = new System.Windows.Forms.StatusStrip();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.statusStripDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(61, 418);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(55, 23);
            this.btnInput.TabIndex = 47;
            this.btnInput.Text = "录入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(134, 418);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 23);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "下一条";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cboDormName
            // 
            this.cboDormName.FormattingEnabled = true;
            this.cboDormName.Location = new System.Drawing.Point(130, 227);
            this.cboDormName.Name = "cboDormName";
            this.cboDormName.Size = new System.Drawing.Size(205, 20);
            this.cboDormName.TabIndex = 37;
            // 
            // cboClassName
            // 
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(130, 181);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(205, 20);
            this.cboClassName.TabIndex = 35;
            // 
            // tsslblDesc
            // 
            this.tsslblDesc.Name = "tsslblDesc";
            this.tsslblDesc.Size = new System.Drawing.Size(329, 17);
            this.tsslblDesc.Text = "说明：可连续输入多条记录，输入结束后，单击“下一条”。";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(130, 135);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(205, 20);
            this.cboSex.TabIndex = 34;
            this.cboSex.Text = "男";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(59, 368);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(65, 12);
            this.lblHomePhone.TabIndex = 32;
            this.lblHomePhone.Text = "家庭电话：";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(59, 322);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(65, 12);
            this.lblHomeAddress.TabIndex = 31;
            this.lblHomeAddress.Text = "家庭住址：";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(59, 276);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(65, 12);
            this.lblTelephone.TabIndex = 30;
            this.lblTelephone.Text = "联系电话：";
            // 
            // lblDormName
            // 
            this.lblDormName.AutoSize = true;
            this.lblDormName.Location = new System.Drawing.Point(59, 230);
            this.lblDormName.Name = "lblDormName";
            this.lblDormName.Size = new System.Drawing.Size(65, 12);
            this.lblDormName.TabIndex = 29;
            this.lblDormName.Text = "宿舍名称：";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(59, 184);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(65, 12);
            this.lblClassName.TabIndex = 28;
            this.lblClassName.Text = "班级名称：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(59, 138);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 27;
            this.lblSex.Text = "性    别：";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(59, 92);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(65, 12);
            this.lblStuName.TabIndex = 26;
            this.lblStuName.Text = "姓    名：";
            // 
            // lblStuId
            // 
            this.lblStuId.AutoSize = true;
            this.lblStuId.Location = new System.Drawing.Point(59, 46);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(65, 12);
            this.lblStuId.TabIndex = 25;
            this.lblStuId.Text = "学    号：";
            // 
            // statusStripDesc
            // 
            this.statusStripDesc.Enabled = false;
            this.statusStripDesc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDesc});
            this.statusStripDesc.Location = new System.Drawing.Point(0, 544);
            this.statusStripDesc.Name = "statusStripDesc";
            this.statusStripDesc.Size = new System.Drawing.Size(792, 22);
            this.statusStripDesc.TabIndex = 24;
            this.statusStripDesc.Text = "statusStrip1";
            // 
            // txtStuId
            // 
            this.txtStuId.Location = new System.Drawing.Point(130, 43);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(205, 21);
            this.txtStuId.TabIndex = 48;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(130, 89);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(205, 21);
            this.txtStuName.TabIndex = 49;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(130, 273);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(205, 21);
            this.txtTelephone.TabIndex = 50;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(130, 319);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(205, 21);
            this.txtHomeAddress.TabIndex = 51;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(130, 365);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(205, 21);
            this.txtHomePhone.TabIndex = 52;
            // 
            // frmInputStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuId);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cboDormName);
            this.Controls.Add(this.cboClassName);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblDormName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.lblStuId);
            this.Controls.Add(this.statusStripDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInputStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息录入";
            this.Load += new System.EventHandler(this.frmInputStudentInf_Load);
            this.statusStripDesc.ResumeLayout(false);
            this.statusStripDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cboDormName;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDesc;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblDormName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.StatusStrip statusStripDesc;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtHomePhone;
    }
}