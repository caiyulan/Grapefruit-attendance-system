namespace StudentAttendanceMgr.StudentAttendance
{
    partial class frmManageAttendanceInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAttendanceInfo));
            this.tslblCondition = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cboCondition = new System.Windows.Forms.ToolStripComboBox();
            this.lblValue = new System.Windows.Forms.ToolStripLabel();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.cboEndWeek = new System.Windows.Forms.ComboBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.cboStartWeek = new System.Windows.Forms.ComboBox();
            this.grbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.cboAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.lblStuId = new System.Windows.Forms.Label();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.cboSchoolTime = new System.Windows.Forms.ComboBox();
            this.cboWeekday = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.cboSchoolYear = new System.Windows.Forms.ComboBox();
            this.lblClassTime = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.cboWeek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClassWeek = new System.Windows.Forms.Label();
            this.dgvAttendanceInfo = new System.Windows.Forms.DataGridView();
            this.AttendanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.grbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tslblCondition
            // 
            this.tslblCondition.Name = "tslblCondition";
            this.tslblCondition.Size = new System.Drawing.Size(53, 22);
            this.tslblCondition.Text = "查询条件";
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
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // cboCondition
            // 
            this.cboCondition.Items.AddRange(new object[] {
            "学年",
            "学期",
            "周次",
            "星期",
            "节次",
            "课程名称",
            "学号",
            "出勤状态",
            "备注"});
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
            this.cboEndWeek.Location = new System.Drawing.Point(189, 206);
            this.cboEndWeek.Name = "cboEndWeek";
            this.cboEndWeek.Size = new System.Drawing.Size(88, 20);
            this.cboEndWeek.TabIndex = 31;
            this.cboEndWeek.Text = "第一周";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(166, 209);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(17, 12);
            this.lblWeek.TabIndex = 30;
            this.lblWeek.Text = "至";
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
            this.cboStartWeek.Location = new System.Drawing.Point(72, 206);
            this.cboStartWeek.Name = "cboStartWeek";
            this.cboStartWeek.Size = new System.Drawing.Size(88, 20);
            this.cboStartWeek.TabIndex = 29;
            this.cboStartWeek.Text = "第一周";
            // 
            // grbBasicInfo
            // 
            this.grbBasicInfo.Controls.Add(this.txtStuId);
            this.grbBasicInfo.Controls.Add(this.txtMemo);
            this.grbBasicInfo.Controls.Add(this.lblMemo);
            this.grbBasicInfo.Controls.Add(this.cboAttendanceStatus);
            this.grbBasicInfo.Controls.Add(this.lblAttendanceStatus);
            this.grbBasicInfo.Controls.Add(this.lblStuId);
            this.grbBasicInfo.Controls.Add(this.cboCourseName);
            this.grbBasicInfo.Controls.Add(this.lblCourseName);
            this.grbBasicInfo.Controls.Add(this.cboSchoolTime);
            this.grbBasicInfo.Controls.Add(this.cboWeekday);
            this.grbBasicInfo.Controls.Add(this.cboSemester);
            this.grbBasicInfo.Controls.Add(this.cboSchoolYear);
            this.grbBasicInfo.Controls.Add(this.lblClassTime);
            this.grbBasicInfo.Controls.Add(this.lblSemester);
            this.grbBasicInfo.Controls.Add(this.lblSchoolYear);
            this.grbBasicInfo.Controls.Add(this.cboWeek);
            this.grbBasicInfo.Controls.Add(this.label1);
            this.grbBasicInfo.Controls.Add(this.cboEndWeek);
            this.grbBasicInfo.Controls.Add(this.lblWeek);
            this.grbBasicInfo.Controls.Add(this.cboStartWeek);
            this.grbBasicInfo.Controls.Add(this.lblClassWeek);
            this.grbBasicInfo.Location = new System.Drawing.Point(23, 30);
            this.grbBasicInfo.Name = "grbBasicInfo";
            this.grbBasicInfo.Size = new System.Drawing.Size(750, 201);
            this.grbBasicInfo.TabIndex = 15;
            this.grbBasicInfo.TabStop = false;
            // 
            // txtStuId
            // 
            this.txtStuId.Location = new System.Drawing.Point(475, 70);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(205, 21);
            this.txtStuId.TabIndex = 64;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(475, 166);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(205, 21);
            this.txtMemo.TabIndex = 63;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(404, 170);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(65, 12);
            this.lblMemo.TabIndex = 62;
            this.lblMemo.Text = "备    注：";
            // 
            // cboAttendanceStatus
            // 
            this.cboAttendanceStatus.FormattingEnabled = true;
            this.cboAttendanceStatus.Location = new System.Drawing.Point(475, 119);
            this.cboAttendanceStatus.Name = "cboAttendanceStatus";
            this.cboAttendanceStatus.Size = new System.Drawing.Size(205, 20);
            this.cboAttendanceStatus.TabIndex = 61;
            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.AutoSize = true;
            this.lblAttendanceStatus.Location = new System.Drawing.Point(404, 122);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(65, 12);
            this.lblAttendanceStatus.TabIndex = 60;
            this.lblAttendanceStatus.Text = "出勤状态：";
            // 
            // lblStuId
            // 
            this.lblStuId.AutoSize = true;
            this.lblStuId.Location = new System.Drawing.Point(404, 74);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(65, 12);
            this.lblStuId.TabIndex = 58;
            this.lblStuId.Text = "学    号：";
            // 
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(475, 23);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(205, 20);
            this.cboCourseName.TabIndex = 57;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(404, 26);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(65, 12);
            this.lblCourseName.TabIndex = 56;
            this.lblCourseName.Text = "课程名称：";
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
            this.cboSchoolTime.Location = new System.Drawing.Point(241, 167);
            this.cboSchoolTime.Name = "cboSchoolTime";
            this.cboSchoolTime.Size = new System.Drawing.Size(88, 20);
            this.cboSchoolTime.TabIndex = 49;
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
            this.cboWeekday.Location = new System.Drawing.Point(124, 167);
            this.cboWeekday.Name = "cboWeekday";
            this.cboWeekday.Size = new System.Drawing.Size(88, 20);
            this.cboWeekday.TabIndex = 48;
            this.cboWeekday.Text = "星期一";
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "上学期",
            "下学期"});
            this.cboSemester.Location = new System.Drawing.Point(124, 71);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(205, 20);
            this.cboSemester.TabIndex = 47;
            this.cboSemester.Text = "上学期";
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
            this.cboSchoolYear.Location = new System.Drawing.Point(124, 23);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(205, 20);
            this.cboSchoolYear.TabIndex = 46;
            this.cboSchoolYear.Text = "2009年";
            // 
            // lblClassTime
            // 
            this.lblClassTime.AutoSize = true;
            this.lblClassTime.Location = new System.Drawing.Point(53, 170);
            this.lblClassTime.Name = "lblClassTime";
            this.lblClassTime.Size = new System.Drawing.Size(65, 12);
            this.lblClassTime.TabIndex = 44;
            this.lblClassTime.Text = "上课时间：";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(53, 74);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(65, 12);
            this.lblSemester.TabIndex = 43;
            this.lblSemester.Text = "学    期：";
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Location = new System.Drawing.Point(53, 26);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(65, 12);
            this.lblSchoolYear.TabIndex = 42;
            this.lblSchoolYear.Text = "学    年：";
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
            this.cboWeek.Location = new System.Drawing.Point(124, 119);
            this.cboWeek.Name = "cboWeek";
            this.cboWeek.Size = new System.Drawing.Size(205, 20);
            this.cboWeek.TabIndex = 50;
            this.cboWeek.Text = "第一周";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "上课周次：";
            // 
            // lblClassWeek
            // 
            this.lblClassWeek.AutoSize = true;
            this.lblClassWeek.Location = new System.Drawing.Point(1, 209);
            this.lblClassWeek.Name = "lblClassWeek";
            this.lblClassWeek.Size = new System.Drawing.Size(65, 12);
            this.lblClassWeek.TabIndex = 24;
            this.lblClassWeek.Text = "上课周次：";
            // 
            // dgvAttendanceInfo
            // 
            this.dgvAttendanceInfo.AllowUserToAddRows = false;
            this.dgvAttendanceInfo.AllowUserToDeleteRows = false;
            this.dgvAttendanceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceId,
            this.SchoolYear,
            this.Semester,
            this.Week,
            this.Weekday,
            this.SchoolTime,
            this.CourseName,
            this.StuId,
            this.StatusName,
            this.Memo});
            this.dgvAttendanceInfo.Location = new System.Drawing.Point(23, 240);
            this.dgvAttendanceInfo.MultiSelect = false;
            this.dgvAttendanceInfo.Name = "dgvAttendanceInfo";
            this.dgvAttendanceInfo.ReadOnly = true;
            this.dgvAttendanceInfo.RowTemplate.Height = 23;
            this.dgvAttendanceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendanceInfo.Size = new System.Drawing.Size(750, 320);
            this.dgvAttendanceInfo.TabIndex = 16;
            this.dgvAttendanceInfo.SelectionChanged += new System.EventHandler(this.dgvAttendanceInfo_SelectionChanged);
            // 
            // AttendanceId
            // 
            this.AttendanceId.DataPropertyName = "AttendanceId";
            this.AttendanceId.HeaderText = "记录编号";
            this.AttendanceId.Name = "AttendanceId";
            this.AttendanceId.ReadOnly = true;
            this.AttendanceId.Visible = false;
            this.AttendanceId.Width = 5;
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
            // StuId
            // 
            this.StuId.DataPropertyName = "StuId";
            this.StuId.HeaderText = "学号";
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
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
            // frmManageAttendanceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.grbBasicInfo);
            this.Controls.Add(this.dgvAttendanceInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManageAttendanceInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生出勤信息维护";
            this.Load += new System.EventHandler(this.frmManageAttendanceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.grbBasicInfo.ResumeLayout(false);
            this.grbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripLabel tslblCondition;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.ToolStripButton btnEdit;
        public System.Windows.Forms.ToolStripButton btnAdd;
        public System.Windows.Forms.ToolStripSeparator tsSeparator1;
        public System.Windows.Forms.ToolStripSeparator tsSeparator2;
        public System.Windows.Forms.ToolStripButton btnCancel;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ToolStripComboBox cboCondition;
        public System.Windows.Forms.ToolStripLabel lblValue;
        public System.Windows.Forms.ToolStripTextBox txtCondition;
        public System.Windows.Forms.ToolStripButton btnQuery;
        public System.Windows.Forms.ToolStripSeparator tsSeparator3;
        public System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ComboBox cboEndWeek;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.ComboBox cboStartWeek;
        public System.Windows.Forms.GroupBox grbBasicInfo;
        private System.Windows.Forms.Label lblClassWeek;
        public System.Windows.Forms.DataGridView dgvAttendanceInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.ComboBox cboSchoolTime;
        private System.Windows.Forms.ComboBox cboWeekday;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.ComboBox cboSchoolYear;
        private System.Windows.Forms.Label lblClassTime;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.ComboBox cboWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.ComboBox cboAttendanceStatus;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.Label lblCourseName;
    }
}