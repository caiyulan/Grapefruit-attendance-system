namespace StudentAttendanceMgr.CourseScheduleInfo
{
    partial class frmInputCourseScheduleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputCourseScheduleInfo));
            this.statusStripDesc = new System.Windows.Forms.StatusStrip();
            this.tsslblDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblClassTime = new System.Windows.Forms.Label();
            this.lblClassWeek = new System.Windows.Forms.Label();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.cboTeacherName = new System.Windows.Forms.ComboBox();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.cboRoomName = new System.Windows.Forms.ComboBox();
            this.cboSchoolYear = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.cboWeekday = new System.Windows.Forms.ComboBox();
            this.cboSchoolTime = new System.Windows.Forms.ComboBox();
            this.cboStartWeek = new System.Windows.Forms.ComboBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.cboEndWeek = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.statusStripDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripDesc
            // 
            this.statusStripDesc.Enabled = false;
            this.statusStripDesc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDesc});
            this.statusStripDesc.Location = new System.Drawing.Point(0, 544);
            this.statusStripDesc.Name = "statusStripDesc";
            this.statusStripDesc.Size = new System.Drawing.Size(792, 22);
            this.statusStripDesc.TabIndex = 0;
            this.statusStripDesc.Text = "statusStrip1";
            // 
            // tsslblDesc
            // 
            this.tsslblDesc.Name = "tsslblDesc";
            this.tsslblDesc.Size = new System.Drawing.Size(318, 17);
            this.tsslblDesc.Text = "说明：可连续输入多条记录，输入结束后，单击“下一条”。";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(59, 47);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(65, 12);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "课程名称：";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(59, 93);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(65, 12);
            this.lblTeacherName.TabIndex = 2;
            this.lblTeacherName.Text = "上课教师：";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(59, 139);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(65, 12);
            this.lblClassName.TabIndex = 3;
            this.lblClassName.Text = "上课班级：";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(59, 185);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(65, 12);
            this.lblRoomName.TabIndex = 4;
            this.lblRoomName.Text = "上课地点：";
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Location = new System.Drawing.Point(59, 231);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(65, 12);
            this.lblSchoolYear.TabIndex = 5;
            this.lblSchoolYear.Text = "学    年：";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(59, 277);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(65, 12);
            this.lblSemester.TabIndex = 6;
            this.lblSemester.Text = "学    期：";
            // 
            // lblClassTime
            // 
            this.lblClassTime.AutoSize = true;
            this.lblClassTime.Location = new System.Drawing.Point(59, 323);
            this.lblClassTime.Name = "lblClassTime";
            this.lblClassTime.Size = new System.Drawing.Size(65, 12);
            this.lblClassTime.TabIndex = 7;
            this.lblClassTime.Text = "上课时间：";
            // 
            // lblClassWeek
            // 
            this.lblClassWeek.AutoSize = true;
            this.lblClassWeek.Location = new System.Drawing.Point(59, 369);
            this.lblClassWeek.Name = "lblClassWeek";
            this.lblClassWeek.Size = new System.Drawing.Size(65, 12);
            this.lblClassWeek.TabIndex = 8;
            this.lblClassWeek.Text = "上课周次：";
            // 
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(130, 44);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(205, 20);
            this.cboCourseName.TabIndex = 9;
            // 
            // cboTeacherName
            // 
            this.cboTeacherName.FormattingEnabled = true;
            this.cboTeacherName.Location = new System.Drawing.Point(130, 90);
            this.cboTeacherName.Name = "cboTeacherName";
            this.cboTeacherName.Size = new System.Drawing.Size(205, 20);
            this.cboTeacherName.TabIndex = 10;
            // 
            // cboClassName
            // 
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(130, 136);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(205, 20);
            this.cboClassName.TabIndex = 11;
            // 
            // cboRoomName
            // 
            this.cboRoomName.FormattingEnabled = true;
            this.cboRoomName.Location = new System.Drawing.Point(130, 182);
            this.cboRoomName.Name = "cboRoomName";
            this.cboRoomName.Size = new System.Drawing.Size(205, 20);
            this.cboRoomName.TabIndex = 12;
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
            this.cboSchoolYear.Location = new System.Drawing.Point(130, 228);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(205, 20);
            this.cboSchoolYear.TabIndex = 13;
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "上学期",
            "下学期"});
            this.cboSemester.Location = new System.Drawing.Point(130, 274);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(205, 20);
            this.cboSemester.TabIndex = 14;
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
            this.cboWeekday.Location = new System.Drawing.Point(130, 320);
            this.cboWeekday.Name = "cboWeekday";
            this.cboWeekday.Size = new System.Drawing.Size(88, 20);
            this.cboWeekday.TabIndex = 15;
            this.cboWeekday.Text = "星期一";
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
            this.cboSchoolTime.Location = new System.Drawing.Point(247, 320);
            this.cboSchoolTime.Name = "cboSchoolTime";
            this.cboSchoolTime.Size = new System.Drawing.Size(88, 20);
            this.cboSchoolTime.TabIndex = 16;
            this.cboSchoolTime.Text = "1-2节";
            // 
            // cboStartWeek
            // 
            this.cboStartWeek.FormattingEnabled = true;
            this.cboStartWeek.Items.AddRange(new object[] {
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
            this.cboStartWeek.Location = new System.Drawing.Point(130, 366);
            this.cboStartWeek.Name = "cboStartWeek";
            this.cboStartWeek.Size = new System.Drawing.Size(88, 20);
            this.cboStartWeek.TabIndex = 17;
            this.cboStartWeek.Text = "第一周";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(224, 369);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(17, 12);
            this.lblWeek.TabIndex = 18;
            this.lblWeek.Text = "至";
            // 
            // cboEndWeek
            // 
            this.cboEndWeek.FormattingEnabled = true;
            this.cboEndWeek.Items.AddRange(new object[] {
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
            this.cboEndWeek.Location = new System.Drawing.Point(247, 366);
            this.cboEndWeek.Name = "cboEndWeek";
            this.cboEndWeek.Size = new System.Drawing.Size(88, 20);
            this.cboEndWeek.TabIndex = 19;
            this.cboEndWeek.Text = "第一周";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(134, 419);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "下一条";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(61, 419);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(55, 23);
            this.btnInput.TabIndex = 23;
            this.btnInput.Text = "录入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // frmInputCourseScheduleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cboEndWeek);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.cboStartWeek);
            this.Controls.Add(this.cboSchoolTime);
            this.Controls.Add(this.cboWeekday);
            this.Controls.Add(this.cboSemester);
            this.Controls.Add(this.cboSchoolYear);
            this.Controls.Add(this.cboRoomName);
            this.Controls.Add(this.cboClassName);
            this.Controls.Add(this.cboTeacherName);
            this.Controls.Add(this.cboCourseName);
            this.Controls.Add(this.lblClassWeek);
            this.Controls.Add(this.lblClassTime);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblSchoolYear);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.statusStripDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInputCourseScheduleInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课表录入";
            this.Load += new System.EventHandler(this.frmInputCourseScheduleInfo_Load);
            this.statusStripDesc.ResumeLayout(false);
            this.statusStripDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripDesc;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDesc;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblClassTime;
        private System.Windows.Forms.Label lblClassWeek;
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.ComboBox cboTeacherName;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.ComboBox cboRoomName;
        private System.Windows.Forms.ComboBox cboSchoolYear;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.ComboBox cboWeekday;
        private System.Windows.Forms.ComboBox cboSchoolTime;
        private System.Windows.Forms.ComboBox cboStartWeek;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.ComboBox cboEndWeek;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInput;
    }
}