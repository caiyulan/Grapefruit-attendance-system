﻿namespace StudentAttendanceMgr.CourseScheduleInfo
{
    partial class frmViewCourseScheduleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCourseScheduleInfo));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblCondition = new System.Windows.Forms.ToolStripLabel();
            this.cboCondition = new System.Windows.Forms.ToolStripComboBox();
            this.lblValue = new System.Windows.Forms.ToolStripLabel();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.statusStripDesc = new System.Windows.Forms.StatusStrip();
            this.tsslblDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerCourseScheduleInfo = new System.Windows.Forms.SplitContainer();
            this.tvCourseInfo = new System.Windows.Forms.TreeView();
            this.dgvCourseSchedule = new System.Windows.Forms.DataGridView();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.statusStripDesc.SuspendLayout();
            this.splitContainerCourseScheduleInfo.Panel1.SuspendLayout();
            this.splitContainerCourseScheduleInfo.Panel2.SuspendLayout();
            this.splitContainerCourseScheduleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).BeginInit();
            this.SuspendLayout();
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
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
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
            "课程名称",
            "上课班级",
            "上课地点",
            "学年",
            "学期",
            "星期",
            "节次"});
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(121, 25);
            // 
            // lblValue
            // 
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 22);
            this.lblValue.Text = "查询值";
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
            // statusStripDesc
            // 
            this.statusStripDesc.Enabled = false;
            this.statusStripDesc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDesc});
            this.statusStripDesc.Location = new System.Drawing.Point(0, 546);
            this.statusStripDesc.Name = "statusStripDesc";
            this.statusStripDesc.Size = new System.Drawing.Size(794, 22);
            this.statusStripDesc.TabIndex = 13;
            this.statusStripDesc.Text = "statusStrip1";
            // 
            // tsslblDesc
            // 
            this.tsslblDesc.Name = "tsslblDesc";
            this.tsslblDesc.Size = new System.Drawing.Size(413, 17);
            this.tsslblDesc.Text = "说明：在左边列表中选择某个节点后，可在右边列表中显示具体的课表信息。";
            // 
            // splitContainerCourseScheduleInfo
            // 
            this.splitContainerCourseScheduleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCourseScheduleInfo.Location = new System.Drawing.Point(0, 25);
            this.splitContainerCourseScheduleInfo.Name = "splitContainerCourseScheduleInfo";
            // 
            // splitContainerCourseScheduleInfo.Panel1
            // 
            this.splitContainerCourseScheduleInfo.Panel1.Controls.Add(this.tvCourseInfo);
            // 
            // splitContainerCourseScheduleInfo.Panel2
            // 
            this.splitContainerCourseScheduleInfo.Panel2.Controls.Add(this.dgvCourseSchedule);
            this.splitContainerCourseScheduleInfo.Size = new System.Drawing.Size(794, 521);
            this.splitContainerCourseScheduleInfo.SplitterDistance = 249;
            this.splitContainerCourseScheduleInfo.TabIndex = 14;
            // 
            // tvCourseInfo
            // 
            this.tvCourseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCourseInfo.ItemHeight = 16;
            this.tvCourseInfo.Location = new System.Drawing.Point(0, 0);
            this.tvCourseInfo.Name = "tvCourseInfo";
            this.tvCourseInfo.Size = new System.Drawing.Size(249, 521);
            this.tvCourseInfo.TabIndex = 2;
            this.tvCourseInfo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCourseInfo_AfterSelect);
            // 
            // dgvCourseSchedule
            // 
            this.dgvCourseSchedule.AllowUserToAddRows = false;
            this.dgvCourseSchedule.AllowUserToDeleteRows = false;
            this.dgvCourseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.CourseName,
            this.TeacherName,
            this.ClassName,
            this.RoomName,
            this.SchoolYear,
            this.Semester,
            this.Weekday,
            this.SchoolTime,
            this.StartWeek,
            this.EndWeek});
            this.dgvCourseSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourseSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgvCourseSchedule.MultiSelect = false;
            this.dgvCourseSchedule.Name = "dgvCourseSchedule";
            this.dgvCourseSchedule.ReadOnly = true;
            this.dgvCourseSchedule.RowTemplate.Height = 23;
            this.dgvCourseSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseSchedule.Size = new System.Drawing.Size(541, 521);
            this.dgvCourseSchedule.TabIndex = 14;
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "课程编号";
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Visible = false;
            this.CourseId.Width = 5;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 120;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "上课教师";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "上课班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 120;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "上课地点";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
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
            // StartWeek
            // 
            this.StartWeek.DataPropertyName = "StartWeek";
            this.StartWeek.HeaderText = "起始周";
            this.StartWeek.Name = "StartWeek";
            this.StartWeek.ReadOnly = true;
            this.StartWeek.Width = 80;
            // 
            // EndWeek
            // 
            this.EndWeek.DataPropertyName = "EndWeek";
            this.EndWeek.HeaderText = "结束周";
            this.EndWeek.Name = "EndWeek";
            this.EndWeek.ReadOnly = true;
            this.EndWeek.Width = 80;
            // 
            // frmViewCourseScheduleInfo
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
            this.Name = "frmViewCourseScheduleInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课表查看";
            this.Load += new System.EventHandler(this.frmViewCourseScheduleInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.statusStripDesc.ResumeLayout(false);
            this.statusStripDesc.PerformLayout();
            this.splitContainerCourseScheduleInfo.Panel1.ResumeLayout(false);
            this.splitContainerCourseScheduleInfo.Panel2.ResumeLayout(false);
            this.splitContainerCourseScheduleInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator tsSeparator1;
        public System.Windows.Forms.ToolStripLabel tslblCondition;
        public System.Windows.Forms.ToolStripComboBox cboCondition;
        public System.Windows.Forms.ToolStripLabel lblValue;
        public System.Windows.Forms.ToolStripTextBox txtCondition;
        public System.Windows.Forms.ToolStripButton btnQuery;
        public System.Windows.Forms.ToolStripSeparator tsSeparator3;
        public System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.StatusStrip statusStripDesc;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDesc;
        private System.Windows.Forms.SplitContainer splitContainerCourseScheduleInfo;
        private System.Windows.Forms.TreeView tvCourseInfo;
        public System.Windows.Forms.DataGridView dgvCourseSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWeek;
    }
}