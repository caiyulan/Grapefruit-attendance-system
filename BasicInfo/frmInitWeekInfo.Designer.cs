namespace StudentAttendanceMgr.BasicInfo
{
    partial class frmInitWeekInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInitWeekInfo));
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.ToolStripLabel();
            this.cboCondition = new System.Windows.Forms.ToolStripComboBox();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.grbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblFirstWeek = new System.Windows.Forms.Label();
            this.dgvInitWeek = new System.Windows.Forms.DataGridView();
            this.tslblCondition = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSchoolYear = new System.Windows.Forms.ComboBox();
            this.dtpFirstWeek = new System.Windows.Forms.DateTimePicker();
            this.grbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
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
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(26, 66);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(41, 12);
            this.lblSemester.TabIndex = 2;
            this.lblSemester.Text = "学期：";
            // 
            // lblValue
            // 
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(41, 22);
            this.lblValue.Text = "查询值";
            // 
            // cboCondition
            // 
            this.cboCondition.Items.AddRange(new object[] {
            "学年",
            "学期"});
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(121, 25);
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
            // txtCondition
            // 
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(100, 25);
            this.txtCondition.ToolTipText = "请输入查询值";
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Location = new System.Drawing.Point(26, 26);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(41, 12);
            this.lblSchoolYear.TabIndex = 0;
            this.lblSchoolYear.Text = "学年：";
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "上学期",
            "下学期"});
            this.cboSemester.Location = new System.Drawing.Point(85, 63);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(150, 20);
            this.cboSemester.TabIndex = 5;
            // 
            // grbBasicInfo
            // 
            this.grbBasicInfo.Controls.Add(this.dtpFirstWeek);
            this.grbBasicInfo.Controls.Add(this.cboSchoolYear);
            this.grbBasicInfo.Controls.Add(this.cboSemester);
            this.grbBasicInfo.Controls.Add(this.lblFirstWeek);
            this.grbBasicInfo.Controls.Add(this.lblSemester);
            this.grbBasicInfo.Controls.Add(this.lblSchoolYear);
            this.grbBasicInfo.Location = new System.Drawing.Point(23, 38);
            this.grbBasicInfo.Name = "grbBasicInfo";
            this.grbBasicInfo.Size = new System.Drawing.Size(750, 141);
            this.grbBasicInfo.TabIndex = 12;
            this.grbBasicInfo.TabStop = false;
            // 
            // lblFirstWeek
            // 
            this.lblFirstWeek.AutoSize = true;
            this.lblFirstWeek.Location = new System.Drawing.Point(26, 106);
            this.lblFirstWeek.Name = "lblFirstWeek";
            this.lblFirstWeek.Size = new System.Drawing.Size(53, 12);
            this.lblFirstWeek.TabIndex = 4;
            this.lblFirstWeek.Text = "初始周：";
            // 
            // dgvInitWeek
            // 
            this.dgvInitWeek.AllowUserToAddRows = false;
            this.dgvInitWeek.AllowUserToDeleteRows = false;
            this.dgvInitWeek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitWeek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SchoolYear,
            this.Semester,
            this.FirstWeek});
            this.dgvInitWeek.Location = new System.Drawing.Point(23, 198);
            this.dgvInitWeek.MultiSelect = false;
            this.dgvInitWeek.Name = "dgvInitWeek";
            this.dgvInitWeek.ReadOnly = true;
            this.dgvInitWeek.RowTemplate.Height = 23;
            this.dgvInitWeek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInitWeek.Size = new System.Drawing.Size(750, 358);
            this.dgvInitWeek.TabIndex = 13;
            this.dgvInitWeek.SelectionChanged += new System.EventHandler(this.dgvInitWeek_SelectionChanged);
            // 
            // tslblCondition
            // 
            this.tslblCondition.Name = "tslblCondition";
            this.tslblCondition.Size = new System.Drawing.Size(53, 22);
            this.tslblCondition.Text = "查询条件";
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
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.tsSeparator1,
            this.btnSave,
            this.btnCancel,
            this.tsSeparator2,
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
            this.bindingNavigator1.TabIndex = 11;
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::StudentAttendanceMgr.Properties.Resources.添加;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::StudentAttendanceMgr.Properties.Resources.修改;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::StudentAttendanceMgr.Properties.Resources.删除;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::StudentAttendanceMgr.Properties.Resources.保存;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = global::StudentAttendanceMgr.Properties.Resources.取消;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 22);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "记录编号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // SchoolYear
            // 
            this.SchoolYear.DataPropertyName = "SchoolYear";
            this.SchoolYear.HeaderText = "学年";
            this.SchoolYear.Name = "SchoolYear";
            this.SchoolYear.ReadOnly = true;
            this.SchoolYear.Width = 180;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "学期";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            this.Semester.Width = 200;
            // 
            // FirstWeek
            // 
            this.FirstWeek.DataPropertyName = "FirstWeek";
            this.FirstWeek.HeaderText = "初始周";
            this.FirstWeek.Name = "FirstWeek";
            this.FirstWeek.ReadOnly = true;
            this.FirstWeek.Width = 310;
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
            this.cboSchoolYear.Location = new System.Drawing.Point(85, 23);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(150, 20);
            this.cboSchoolYear.TabIndex = 6;
            // 
            // dtpFirstWeek
            // 
            this.dtpFirstWeek.Location = new System.Drawing.Point(85, 102);
            this.dtpFirstWeek.Name = "dtpFirstWeek";
            this.dtpFirstWeek.Size = new System.Drawing.Size(150, 21);
            this.dtpFirstWeek.TabIndex = 7;
            this.dtpFirstWeek.Value = new System.DateTime(2009, 12, 27, 0, 0, 0, 0);
            // 
            // frmInitWeekInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.grbBasicInfo);
            this.Controls.Add(this.dgvInitWeek);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInitWeekInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤时间设置";
            this.Load += new System.EventHandler(this.frmInitWeekInfo_Load);
            this.grbBasicInfo.ResumeLayout(false);
            this.grbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripSeparator tsSeparator3;
        public System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Label lblSemester;
        public System.Windows.Forms.ToolStripLabel lblValue;
        public System.Windows.Forms.ToolStripComboBox cboCondition;
        public System.Windows.Forms.ToolStripButton btnQuery;
        public System.Windows.Forms.ToolStripTextBox txtCondition;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.ComboBox cboSemester;
        public System.Windows.Forms.GroupBox grbBasicInfo;
        private System.Windows.Forms.Label lblFirstWeek;
        public System.Windows.Forms.DataGridView dgvInitWeek;
        public System.Windows.Forms.ToolStripLabel tslblCondition;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ToolStripButton btnAdd;
        public System.Windows.Forms.ToolStripButton btnEdit;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.ToolStripSeparator tsSeparator1;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnCancel;
        public System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstWeek;
        private System.Windows.Forms.ComboBox cboSchoolYear;
        private System.Windows.Forms.DateTimePicker dtpFirstWeek;
    }
}