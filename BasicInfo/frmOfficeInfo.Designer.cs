namespace StudentAttendanceMgr.BasicInfo
{
    partial class frmOfficeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficeInfo));
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblCondition = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblValue = new System.Windows.Forms.ToolStripLabel();
            this.cboCondition = new System.Windows.Forms.ToolStripComboBox();
            this.dgvOffice = new System.Windows.Forms.DataGridView();
            this.grbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtOfficeName = new System.Windows.Forms.TextBox();
            this.lblOfficeName = new System.Windows.Forms.Label();
            this.txtOfficeId = new System.Windows.Forms.TextBox();
            this.lblOfficeId = new System.Windows.Forms.Label();
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
            this.txtOfficeAddress = new System.Windows.Forms.TextBox();
            this.lblOfficeAddress = new System.Windows.Forms.Label();
            this.OfficeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffice)).BeginInit();
            this.grbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
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
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslblCondition
            // 
            this.tslblCondition.Name = "tslblCondition";
            this.tslblCondition.Size = new System.Drawing.Size(53, 22);
            this.tslblCondition.Text = "查询条件";
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
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
            "办公室编号",
            "办公室名称",
            "办公室地址"});
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(121, 25);
            // 
            // dgvOffice
            // 
            this.dgvOffice.AllowUserToAddRows = false;
            this.dgvOffice.AllowUserToDeleteRows = false;
            this.dgvOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfficeId,
            this.OfficeName,
            this.OfficeAddress});
            this.dgvOffice.Location = new System.Drawing.Point(23, 176);
            this.dgvOffice.MultiSelect = false;
            this.dgvOffice.Name = "dgvOffice";
            this.dgvOffice.ReadOnly = true;
            this.dgvOffice.RowTemplate.Height = 23;
            this.dgvOffice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOffice.Size = new System.Drawing.Size(750, 381);
            this.dgvOffice.TabIndex = 13;
            this.dgvOffice.SelectionChanged += new System.EventHandler(this.dgvOffice_SelectionChanged);
            // 
            // grbBasicInfo
            // 
            this.grbBasicInfo.Controls.Add(this.txtOfficeAddress);
            this.grbBasicInfo.Controls.Add(this.lblOfficeAddress);
            this.grbBasicInfo.Controls.Add(this.txtOfficeName);
            this.grbBasicInfo.Controls.Add(this.lblOfficeName);
            this.grbBasicInfo.Controls.Add(this.txtOfficeId);
            this.grbBasicInfo.Controls.Add(this.lblOfficeId);
            this.grbBasicInfo.Location = new System.Drawing.Point(23, 33);
            this.grbBasicInfo.Name = "grbBasicInfo";
            this.grbBasicInfo.Size = new System.Drawing.Size(750, 128);
            this.grbBasicInfo.TabIndex = 12;
            this.grbBasicInfo.TabStop = false;
            // 
            // txtOfficeName
            // 
            this.txtOfficeName.Location = new System.Drawing.Point(109, 58);
            this.txtOfficeName.Name = "txtOfficeName";
            this.txtOfficeName.Size = new System.Drawing.Size(150, 21);
            this.txtOfficeName.TabIndex = 3;
            // 
            // lblOfficeName
            // 
            this.lblOfficeName.AutoSize = true;
            this.lblOfficeName.Location = new System.Drawing.Point(26, 61);
            this.lblOfficeName.Name = "lblOfficeName";
            this.lblOfficeName.Size = new System.Drawing.Size(77, 12);
            this.lblOfficeName.TabIndex = 2;
            this.lblOfficeName.Text = "办公室名称：";
            // 
            // txtOfficeId
            // 
            this.txtOfficeId.Location = new System.Drawing.Point(109, 18);
            this.txtOfficeId.Name = "txtOfficeId";
            this.txtOfficeId.Size = new System.Drawing.Size(150, 21);
            this.txtOfficeId.TabIndex = 1;
            // 
            // lblOfficeId
            // 
            this.lblOfficeId.AutoSize = true;
            this.lblOfficeId.Location = new System.Drawing.Point(26, 21);
            this.lblOfficeId.Name = "lblOfficeId";
            this.lblOfficeId.Size = new System.Drawing.Size(77, 12);
            this.lblOfficeId.TabIndex = 0;
            this.lblOfficeId.Text = "办公室编号：";
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
            // txtOfficeAddress
            // 
            this.txtOfficeAddress.Location = new System.Drawing.Point(109, 96);
            this.txtOfficeAddress.Name = "txtOfficeAddress";
            this.txtOfficeAddress.Size = new System.Drawing.Size(150, 21);
            this.txtOfficeAddress.TabIndex = 5;
            // 
            // lblOfficeAddress
            // 
            this.lblOfficeAddress.AutoSize = true;
            this.lblOfficeAddress.Location = new System.Drawing.Point(26, 99);
            this.lblOfficeAddress.Name = "lblOfficeAddress";
            this.lblOfficeAddress.Size = new System.Drawing.Size(77, 12);
            this.lblOfficeAddress.TabIndex = 4;
            this.lblOfficeAddress.Text = "办公室地址：";
            // 
            // OfficeId
            // 
            this.OfficeId.DataPropertyName = "OfficeId";
            this.OfficeId.HeaderText = "办公室编号";
            this.OfficeId.Name = "OfficeId";
            this.OfficeId.ReadOnly = true;
            this.OfficeId.Width = 150;
            // 
            // OfficeName
            // 
            this.OfficeName.DataPropertyName = "OfficeName";
            this.OfficeName.HeaderText = "办公室名称";
            this.OfficeName.Name = "OfficeName";
            this.OfficeName.ReadOnly = true;
            this.OfficeName.Width = 250;
            // 
            // OfficeAddress
            // 
            this.OfficeAddress.DataPropertyName = "OfficeAddress";
            this.OfficeAddress.HeaderText = "办公室地址";
            this.OfficeAddress.Name = "OfficeAddress";
            this.OfficeAddress.ReadOnly = true;
            this.OfficeAddress.Width = 300;
            // 
            // frmOfficeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.dgvOffice);
            this.Controls.Add(this.grbBasicInfo);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOfficeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "办公室设置";
            this.Load += new System.EventHandler(this.frmOfficeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffice)).EndInit();
            this.grbBasicInfo.ResumeLayout(false);
            this.grbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripButton btnQuery;
        public System.Windows.Forms.ToolStripTextBox txtCondition;
        public System.Windows.Forms.ToolStripButton btnRefresh;
        public System.Windows.Forms.ToolStripSeparator tsSeparator3;
        public System.Windows.Forms.ToolStripLabel tslblCondition;
        public System.Windows.Forms.ToolStripSeparator tsSeparator2;
        public System.Windows.Forms.ToolStripLabel lblValue;
        public System.Windows.Forms.ToolStripComboBox cboCondition;
        public System.Windows.Forms.DataGridView dgvOffice;
        public System.Windows.Forms.GroupBox grbBasicInfo;
        private System.Windows.Forms.TextBox txtOfficeAddress;
        private System.Windows.Forms.Label lblOfficeAddress;
        private System.Windows.Forms.TextBox txtOfficeName;
        private System.Windows.Forms.Label lblOfficeName;
        private System.Windows.Forms.TextBox txtOfficeId;
        private System.Windows.Forms.Label lblOfficeId;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficeAddress;
    }
}