namespace StudentAttendanceMgr.StudentAttendance
{
    partial class frmViewAttendanceInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAttendanceInfo));
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblValue = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblCondition = new System.Windows.Forms.ToolStripLabel();
            this.cboCondition = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainerCourseScheduleInfo = new System.Windows.Forms.SplitContainer();
            this.tvAttendanceInfo = new System.Windows.Forms.TreeView();
            this.statusStripDesc = new System.Windows.Forms.StatusStrip();
            this.tsslblDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.dgvAttendanceInfo = new System.Windows.Forms.DataGridView();
            this.SchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerCourseScheduleInfo.Panel1.SuspendLayout();
            this.splitContainerCourseScheduleInfo.Panel2.SuspendLayout();
            this.splitContainerCourseScheduleInfo.SuspendLayout();
            this.statusStripDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtCondition
            // 
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(100, 25);
            this.txtCondition.ToolTipText = "请输入查询值";
            // 
            // btnQuery
            // 
            this.btnQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQuery.Image = global::StudentAttendanceMgr.Properties.Resources.查询;
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(23, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblValue
            // 
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 22);
            this.lblValue.Text = "查询值";
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslblCondition
            // 
            this.tslblCondition.Name = "tslblCondition";
            this.tslblCondition.Size = new System.Drawing.Size(53, 22);
            this.tslblCondition.Text = "查询条件";
            // 
            // cboCondition
            // 
            this.cboCondition.Items.AddRange(new object[] {
            "学年",
            "学期",
            "周次",
            "星期",
            "节次",
            "课程名称",
            "学生姓名",
            "出勤状态",
            "备注"});
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(121, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // splitContainerCourseScheduleInfo
            // 
            this.splitContainerCourseScheduleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCourseScheduleInfo.Location = new System.Drawing.Point(0, 25);
            this.splitContainerCourseScheduleInfo.Name = "splitContainerCourseScheduleInfo";
            // 
            // splitContainerCourseScheduleInfo.Panel1
            // 
            this.splitContainerCourseScheduleInfo.Panel1.Controls.Add(this.tvAttendanceInfo);
            // 
            // splitContainerCourseScheduleInfo.Panel2
            // 
            this.splitContainerCourseScheduleInfo.Panel2.Controls.Add(this.dgvAttendanceInfo);
            this.splitContainerCourseScheduleInfo.Size = new System.Drawing.Size(794, 521);
            this.splitContainerCourseScheduleInfo.SplitterDistance = 249;
            this.splitContainerCourseScheduleInfo.TabIndex = 20;
            // 
            // tvAttendanceInfo
            // 
            this.tvAttendanceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAttendanceInfo.ItemHeight = 16;
            this.tvAttendanceInfo.Location = new System.Drawing.Point(0, 0);
            this.tvAttendanceInfo.Name = "tvAttendanceInfo";
            this.tvAttendanceInfo.Size = new System.Drawing.Size(249, 521);
            this.tvAttendanceInfo.TabIndex = 2;
            this.tvAttendanceInfo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAttendanceInfo_AfterSelect);
            // 
            // statusStripDesc
            // 
            this.statusStripDesc.Enabled = false;
            this.statusStripDesc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDesc});
            this.statusStripDesc.Location = new System.Drawing.Point(0, 546);
            this.statusStripDesc.Name = "statusStripDesc";
            this.statusStripDesc.Size = new System.Drawing.Size(794, 22);
            this.statusStripDesc.TabIndex = 19;
            this.statusStripDesc.Text = "statusStrip1";
            // 
            // tsslblDesc
            // 
            this.tsslblDesc.Name = "tsslblDesc";
            this.tsslblDesc.Size = new System.Drawing.Size(413, 17);
            this.tsslblDesc.Text = "说明：在左边列表中选择某个节点后，可在右边列表中显示具体的课表信息。";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::StudentAttendanceMgr.Properties.Resources.刷新;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.tsSeparator1,
            this.tslblCondition,
            this.cboCondition,
            this.lblValue,
            this.txtCondition,
            this.btnQuery,
            this.tsSeparator3,
            this.btnRefresh});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(794, 25);
            this.bindingNavigator1.TabIndex = 18;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // dgvAttendanceInfo
            // 
            this.dgvAttendanceInfo.AllowUserToAddRows = false;
            this.dgvAttendanceInfo.AllowUserToDeleteRows = false;
            this.dgvAttendanceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolYear,
            this.Semester,
            this.Week,
            this.Weekday,
            this.SchoolTime,
            this.CourseName,
            this.StuName,
            this.StatusName,
            this.Memo});
            this.dgvAttendanceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendanceInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvAttendanceInfo.MultiSelect = false;
            this.dgvAttendanceInfo.Name = "dgvAttendanceInfo";
            this.dgvAttendanceInfo.ReadOnly = true;
            this.dgvAttendanceInfo.RowTemplate.Height = 23;
            this.dgvAttendanceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceInfo.Size = new System.Drawing.Size(541, 521);
            this.dgvAttendanceInfo.TabIndex = 17;
            // 
            // SchoolYear
            // 
            this.SchoolYear.DataPropertyName = "SchoolYear";
            this.SchoolYear.HeaderText = "学年";
            this.SchoolYear.Name = "SchoolYear";
            this.SchoolYear.ReadOnly = true;
            this.SchoolYear.Width = 80;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "学期";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            this.Semester.Width = 80;
            // 
            // Week
            // 
            this.Week.DataPropertyName = "Week";
            this.Week.HeaderText = "周次";
            this.Week.Name = "Week";
            this.Week.ReadOnly = true;
            this.Week.Width = 80;
            // 
            // Weekday
            // 
            this.Weekday.DataPropertyName = "Weekday";
            this.Weekday.HeaderText = "星期";
            this.Weekday.Name = "Weekday";
            this.Weekday.ReadOnly = true;
            this.Weekday.Width = 80;
            // 
            // SchoolTime
            // 
            this.SchoolTime.DataPropertyName = "SchoolTime";
            this.SchoolTime.HeaderText = "节次";
            this.SchoolTime.Name = "SchoolTime";
            this.SchoolTime.ReadOnly = true;
            this.SchoolTime.Width = 80;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 120;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "学生姓名";
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            this.StuName.Width = 80;
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "出勤状态";
            this.StatusName.Name = "StatusName";
            this.StatusName.ReadOnly = true;
            this.StatusName.Width = 80;
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "Memo";
            this.Memo.HeaderText = "备注";
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            // 
            // frmViewAttendanceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.splitContainerCourseScheduleInfo);
            this.Controls.Add(this.statusStripDesc);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmViewAttendanceInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生出勤信息查看";
            this.Load += new System.EventHandler(this.frmViewAttendanceInfo_Load);
            this.splitContainerCourseScheduleInfo.Panel1.ResumeLayout(false);
            this.splitContainerCourseScheduleInfo.Panel2.ResumeLayout(false);
            this.splitContainerCourseScheduleInfo.ResumeLayout(false);
            this.statusStripDesc.ResumeLayout(false);
            this.statusStripDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripTextBox txtCondition;
        public System.Windows.Forms.ToolStripButton btnQuery;
        public System.Windows.Forms.ToolStripSeparator tsSeparator3;
        public System.Windows.Forms.ToolStripLabel lblValue;
        public System.Windows.Forms.ToolStripSeparator tsSeparator1;
        public System.Windows.Forms.ToolStripLabel tslblCondition;
        public System.Windows.Forms.ToolStripComboBox cboCondition;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.SplitContainer splitContainerCourseScheduleInfo;
        private System.Windows.Forms.TreeView tvAttendanceInfo;
        private System.Windows.Forms.StatusStrip statusStripDesc;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDesc;
        public System.Windows.Forms.ToolStripButton btnRefresh;
        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        public System.Windows.Forms.DataGridView dgvAttendanceInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
    }
}