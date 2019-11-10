namespace StudentAttendanceMgr.TeacherService
{
    partial class frmViewMyStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMyStudentInfo));
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
            this.tvStudentInfo = new System.Windows.Forms.TreeView();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.statusStripDesc = new System.Windows.Forms.StatusStrip();
            this.tsslblDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblStudentPhoto = new System.Windows.Forms.Label();
            this.picStudentPhoto = new System.Windows.Forms.PictureBox();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainerCourseScheduleInfo.Panel1.SuspendLayout();
            this.splitContainerCourseScheduleInfo.Panel2.SuspendLayout();
            this.splitContainerCourseScheduleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.statusStripDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentPhoto)).BeginInit();
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
            "学号",
            "姓名",
            "性别",
            "宿舍名称",
            "联系电话",
            "家庭住址",
            "家庭电话"});
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
            this.splitContainerCourseScheduleInfo.Panel1.Controls.Add(this.tvStudentInfo);
            // 
            // splitContainerCourseScheduleInfo.Panel2
            // 
            this.splitContainerCourseScheduleInfo.Panel2.Controls.Add(this.lblStudentPhoto);
            this.splitContainerCourseScheduleInfo.Panel2.Controls.Add(this.picStudentPhoto);
            this.splitContainerCourseScheduleInfo.Panel2.Controls.Add(this.dgvStudent);
            this.splitContainerCourseScheduleInfo.Size = new System.Drawing.Size(824, 521);
            this.splitContainerCourseScheduleInfo.SplitterDistance = 209;
            this.splitContainerCourseScheduleInfo.TabIndex = 20;
            // 
            // tvStudentInfo
            // 
            this.tvStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStudentInfo.ItemHeight = 16;
            this.tvStudentInfo.Location = new System.Drawing.Point(0, 0);
            this.tvStudentInfo.Name = "tvStudentInfo";
            this.tvStudentInfo.Size = new System.Drawing.Size(209, 521);
            this.tvStudentInfo.TabIndex = 2;
            this.tvStudentInfo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStudentInfo_AfterSelect);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuId,
            this.StuName,
            this.Sex,
            this.DormName,
            this.Telephone,
            this.HomeAddress,
            this.HomePhone,
            this.Photo});
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(470, 521);
            this.dgvStudent.TabIndex = 17;
            this.dgvStudent.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // statusStripDesc
            // 
            this.statusStripDesc.Enabled = false;
            this.statusStripDesc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDesc});
            this.statusStripDesc.Location = new System.Drawing.Point(0, 546);
            this.statusStripDesc.Name = "statusStripDesc";
            this.statusStripDesc.Size = new System.Drawing.Size(824, 22);
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
            this.bindingNavigator1.Size = new System.Drawing.Size(824, 25);
            this.bindingNavigator1.TabIndex = 18;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // lblStudentPhoto
            // 
            this.lblStudentPhoto.AutoSize = true;
            this.lblStudentPhoto.Location = new System.Drawing.Point(475, 5);
            this.lblStudentPhoto.Name = "lblStudentPhoto";
            this.lblStudentPhoto.Size = new System.Drawing.Size(65, 12);
            this.lblStudentPhoto.TabIndex = 30;
            this.lblStudentPhoto.Text = "学生照片：";
            // 
            // picStudentPhoto
            // 
            this.picStudentPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudentPhoto.InitialImage = null;
            this.picStudentPhoto.Location = new System.Drawing.Point(477, 21);
            this.picStudentPhoto.Name = "picStudentPhoto";
            this.picStudentPhoto.Size = new System.Drawing.Size(125, 145);
            this.picStudentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudentPhoto.TabIndex = 29;
            this.picStudentPhoto.TabStop = false;
            // 
            // StuId
            // 
            this.StuId.DataPropertyName = "StuId";
            this.StuId.HeaderText = "学号";
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "姓名";
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            this.StuName.Width = 80;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 60;
            // 
            // DormName
            // 
            this.DormName.DataPropertyName = "DormName";
            this.DormName.HeaderText = "宿舍名称";
            this.DormName.Name = "DormName";
            this.DormName.ReadOnly = true;
            this.DormName.Width = 120;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "联系电话";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            this.Telephone.Width = 120;
            // 
            // HomeAddress
            // 
            this.HomeAddress.DataPropertyName = "HomeAddress";
            this.HomeAddress.HeaderText = "家庭住址";
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.ReadOnly = true;
            this.HomeAddress.Width = 120;
            // 
            // HomePhone
            // 
            this.HomePhone.DataPropertyName = "HomePhone";
            this.HomePhone.HeaderText = "家庭电话";
            this.HomePhone.Name = "HomePhone";
            this.HomePhone.ReadOnly = true;
            this.HomePhone.Width = 120;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "照片";
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Visible = false;
            this.Photo.Width = 5;
            // 
            // frmViewMyStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 568);
            this.Controls.Add(this.splitContainerCourseScheduleInfo);
            this.Controls.Add(this.statusStripDesc);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmViewMyStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看学生信息";
            this.Load += new System.EventHandler(this.frmViewMyStudentInfo_Load);
            this.splitContainerCourseScheduleInfo.Panel1.ResumeLayout(false);
            this.splitContainerCourseScheduleInfo.Panel2.ResumeLayout(false);
            this.splitContainerCourseScheduleInfo.Panel2.PerformLayout();
            this.splitContainerCourseScheduleInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.statusStripDesc.ResumeLayout(false);
            this.statusStripDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentPhoto)).EndInit();
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
        private System.Windows.Forms.TreeView tvStudentInfo;
        public System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.StatusStrip statusStripDesc;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDesc;
        public System.Windows.Forms.ToolStripButton btnRefresh;
        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Label lblStudentPhoto;
        private System.Windows.Forms.PictureBox picStudentPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePhone;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
    }
}