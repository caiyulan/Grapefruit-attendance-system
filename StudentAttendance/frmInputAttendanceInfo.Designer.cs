namespace StudentAttendanceMgr.StudentAttendance
{
    partial class frmInputAttendanceInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputAttendanceInfo));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cboSchoolTime = new System.Windows.Forms.ComboBox();
            this.cboWeekday = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.cboSchoolYear = new System.Windows.Forms.ComboBox();
            this.lblClassTime = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.statusStripDesc = new System.Windows.Forms.StatusStrip();
            this.tsslblDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboWeek = new System.Windows.Forms.ComboBox();
            this.lblClassWeek = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cboStuName = new System.Windows.Forms.ComboBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.cboAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.statusStripDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(316, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(243, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(170, 455);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 23);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "下一条";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cboSchoolTime
            // 
            this.cboSchoolTime.FormattingEnabled = true;
            this.cboSchoolTime.Items.AddRange(new object[] {
            "1-2节",
            "3-4节",
            "5-6节",
            "7-8节",
            "9-10节"});
            this.cboSchoolTime.Location = new System.Drawing.Point(280, 196);
            this.cboSchoolTime.Name = "cboSchoolTime";
            this.cboSchoolTime.Size = new System.Drawing.Size(88, 20);
            this.cboSchoolTime.TabIndex = 40;
            this.cboSchoolTime.Text = "1-2节";
            // 
            // cboWeekday
            // 
            this.cboWeekday.FormattingEnabled = true;
            this.cboWeekday.Items.AddRange(new object[] {
            "星期一",
            "星期二",
            "星期三",
            "星期四",
            "星期五",
            "星期六",
            "星期日"});
            this.cboWeekday.Location = new System.Drawing.Point(166, 196);
            this.cboWeekday.Name = "cboWeekday";
            this.cboWeekday.Size = new System.Drawing.Size(88, 20);
            this.cboWeekday.TabIndex = 39;
            this.cboWeekday.Text = "星期一";
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "上学期",
            "下学期"});
            this.cboSemester.Location = new System.Drawing.Point(166, 94);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(205, 20);
            this.cboSemester.TabIndex = 38;
            // 
            // cboSchoolYear
            // 
            this.cboSchoolYear.FormattingEnabled = true;
            this.cboSchoolYear.Items.AddRange(new object[] {
            "2009年",
            "2010年",
            "2011年",
            "2012年",
            "2013年",
            "2014年",
            "2015年",
            "2016年"});
            this.cboSchoolYear.Location = new System.Drawing.Point(166, 43);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(205, 20);
            this.cboSchoolYear.TabIndex = 37;
            // 
            // lblClassTime
            // 
            this.lblClassTime.AutoSize = true;
            this.lblClassTime.Location = new System.Drawing.Point(95, 199);
            this.lblClassTime.Name = "lblClassTime";
            this.lblClassTime.Size = new System.Drawing.Size(65, 12);
            this.lblClassTime.TabIndex = 31;
            this.lblClassTime.Text = "上课时间：";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(95, 97);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(65, 12);
            this.lblSemester.TabIndex = 30;
            this.lblSemester.Text = "学    期：";
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Location = new System.Drawing.Point(95, 46);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(65, 12);
            this.lblSchoolYear.TabIndex = 29;
            this.lblSchoolYear.Text = "学    年：";
            // 
            // statusStripDesc
            // 
            this.statusStripDesc.Enabled = false;
            this.statusStripDesc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDesc});
            this.statusStripDesc.Location = new System.Drawing.Point(0, 546);
            this.statusStripDesc.Name = "statusStripDesc";
            this.statusStripDesc.Size = new System.Drawing.Size(794, 22);
            this.statusStripDesc.TabIndex = 24;
            this.statusStripDesc.Text = "statusStrip1";
            // 
            // tsslblDesc
            // 
            this.tsslblDesc.Name = "tsslblDesc";
            this.tsslblDesc.Size = new System.Drawing.Size(318, 17);
            this.tsslblDesc.Text = "说明：可连续输入多条记录，输入结束后，单击“下一条”。";
            // 
            // cboWeek
            // 
            this.cboWeek.FormattingEnabled = true;
            this.cboWeek.Items.AddRange(new object[] {
            "第一周",
            "第二周",
            "第三周",
            "第四周",
            "第五周",
            "第六周",
            "第七周",
            "第八周",
            "第九周",
            "第十周",
            "第十一周",
            "第十二周",
            "第十三周",
            "第十四周",
            "第十五周",
            "第十六周",
            "第十七周",
            "第十八周",
            "第十九周",
            "第二十周",
            "第二十一周",
            "第二十二周"});
            this.cboWeek.Location = new System.Drawing.Point(166, 145);
            this.cboWeek.Name = "cboWeek";
            this.cboWeek.Size = new System.Drawing.Size(205, 20);
            this.cboWeek.TabIndex = 41;
            this.cboWeek.Text = "第一周";
            // 
            // lblClassWeek
            // 
            this.lblClassWeek.AutoSize = true;
            this.lblClassWeek.Location = new System.Drawing.Point(95, 148);
            this.lblClassWeek.Name = "lblClassWeek";
            this.lblClassWeek.Size = new System.Drawing.Size(65, 12);
            this.lblClassWeek.TabIndex = 32;
            this.lblClassWeek.Text = "上课周次：";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(97, 455);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(55, 23);
            this.btnInput.TabIndex = 47;
            this.btnInput.Text = "录入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(166, 247);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(205, 20);
            this.cboCourseName.TabIndex = 49;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(95, 250);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(65, 12);
            this.lblCourseName.TabIndex = 48;
            this.lblCourseName.Text = "课程名称：";
            // 
            // cboStuName
            // 
            this.cboStuName.FormattingEnabled = true;
            this.cboStuName.Location = new System.Drawing.Point(166, 298);
            this.cboStuName.Name = "cboStuName";
            this.cboStuName.Size = new System.Drawing.Size(205, 20);
            this.cboStuName.TabIndex = 51;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(95, 301);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(65, 12);
            this.lblStuName.TabIndex = 50;
            this.lblStuName.Text = "学生姓名：";
            // 
            // cboAttendanceStatus
            // 
            this.cboAttendanceStatus.FormattingEnabled = true;
            this.cboAttendanceStatus.Location = new System.Drawing.Point(166, 349);
            this.cboAttendanceStatus.Name = "cboAttendanceStatus";
            this.cboAttendanceStatus.Size = new System.Drawing.Size(205, 20);
            this.cboAttendanceStatus.TabIndex = 53;
            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.AutoSize = true;
            this.lblAttendanceStatus.Location = new System.Drawing.Point(95, 352);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(65, 12);
            this.lblAttendanceStatus.TabIndex = 52;
            this.lblAttendanceStatus.Text = "出勤状态：";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(95, 403);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(65, 12);
            this.lblMemo.TabIndex = 54;
            this.lblMemo.Text = "备    注：";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(166, 400);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(205, 21);
            this.txtMemo.TabIndex = 55;
            // 
            // frmInputAttendanceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.cboAttendanceStatus);
            this.Controls.Add(this.lblAttendanceStatus);
            this.Controls.Add(this.cboStuName);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.cboCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cboSchoolTime);
            this.Controls.Add(this.cboWeekday);
            this.Controls.Add(this.cboSemester);
            this.Controls.Add(this.cboSchoolYear);
            this.Controls.Add(this.lblClassTime);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblSchoolYear);
            this.Controls.Add(this.statusStripDesc);
            this.Controls.Add(this.cboWeek);
            this.Controls.Add(this.lblClassWeek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInputAttendanceInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生出勤信息录入";
            this.Load += new System.EventHandler(this.frmInputAttendanceInfo_Load);
            this.statusStripDesc.ResumeLayout(false);
            this.statusStripDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cboSchoolTime;
        private System.Windows.Forms.ComboBox cboWeekday;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.ComboBox cboSchoolYear;
        private System.Windows.Forms.Label lblClassTime;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.StatusStrip statusStripDesc;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDesc;
        private System.Windows.Forms.ComboBox cboWeek;
        private System.Windows.Forms.Label lblClassWeek;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox cboStuName;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.ComboBox cboAttendanceStatus;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
    }
}