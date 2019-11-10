namespace StudentAttendanceMgr.BasicInfo
{
    partial class frmDepartmentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentInfo));
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblCondition = new System.Windows.Forms.ToolStripLabel();
            this.cboCondition = new System.Windows.Forms.ToolStripComboBox();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.DepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.lblDepName = new System.Windows.Forms.Label();
            this.txtDepId = new System.Windows.Forms.TextBox();
            this.lblDepId = new System.Windows.Forms.Label();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblValue = new System.Windows.Forms.ToolStripLabel();
            this.txtCondition = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.grbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
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
            "院系编号",
            "院系名称"});
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(121, 25);
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
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepId,
            this.DepName});
            this.dgvDepartment.Location = new System.Drawing.Point(23, 160);
            this.dgvDepartment.MultiSelect = false;
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.RowTemplate.Height = 23;
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(750, 396);
            this.dgvDepartment.TabIndex = 7;
            this.dgvDepartment.SelectionChanged += new System.EventHandler(this.dgvDepartment_SelectionChanged);
            // 
            // DepId
            // 
            this.DepId.DataPropertyName = "DepId";
            this.DepId.HeaderText = "院系编号";
            this.DepId.Name = "DepId";
            this.DepId.ReadOnly = true;
            this.DepId.Width = 200;
            // 
            // DepName
            // 
            this.DepName.DataPropertyName = "DepName";
            this.DepName.HeaderText = "院系名称";
            this.DepName.Name = "DepName";
            this.DepName.ReadOnly = true;
            this.DepName.Width = 500;
            // 
            // grbBasicInfo
            // 
            this.grbBasicInfo.Controls.Add(this.txtDepName);
            this.grbBasicInfo.Controls.Add(this.lblDepName);
            this.grbBasicInfo.Controls.Add(this.txtDepId);
            this.grbBasicInfo.Controls.Add(this.lblDepId);
            this.grbBasicInfo.Location = new System.Drawing.Point(23, 38);
            this.grbBasicInfo.Name = "grbBasicInfo";
            this.grbBasicInfo.Size = new System.Drawing.Size(750, 103);
            this.grbBasicInfo.TabIndex = 6;
            this.grbBasicInfo.TabStop = false;
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(97, 63);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(150, 21);
            this.txtDepName.TabIndex = 3;
            // 
            // lblDepName
            // 
            this.lblDepName.AutoSize = true;
            this.lblDepName.Location = new System.Drawing.Point(26, 66);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Size = new System.Drawing.Size(65, 12);
            this.lblDepName.TabIndex = 2;
            this.lblDepName.Text = "院系名称：";
            // 
            // txtDepId
            // 
            this.txtDepId.Location = new System.Drawing.Point(97, 23);
            this.txtDepId.Name = "txtDepId";
            this.txtDepId.Size = new System.Drawing.Size(150, 21);
            this.txtDepId.TabIndex = 1;
            // 
            // lblDepId
            // 
            this.lblDepId.AutoSize = true;
            this.lblDepId.Location = new System.Drawing.Point(26, 26);
            this.lblDepId.Name = "lblDepId";
            this.lblDepId.Size = new System.Drawing.Size(65, 12);
            this.lblDepId.TabIndex = 0;
            this.lblDepId.Text = "院系编号：";
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
            this.bindingNavigator1.TabIndex = 5;
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
            // frmDepartmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.grbBasicInfo);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDepartmentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "院系设置";
            this.Load += new System.EventHandler(this.frmDepartmentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.grbBasicInfo.ResumeLayout(false);
            this.grbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripSeparator tsSeparator2;
        public System.Windows.Forms.ToolStripLabel tslblCondition;
        public System.Windows.Forms.ToolStripComboBox cboCondition;
        public System.Windows.Forms.ToolStripButton btnCancel;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.ToolStripSeparator tsSeparator1;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnRefresh;
        public System.Windows.Forms.DataGridView dgvDepartment;
        public System.Windows.Forms.GroupBox grbBasicInfo;
        public System.Windows.Forms.ToolStripSeparator tsSeparator3;
        public System.Windows.Forms.ToolStripLabel lblValue;
        public System.Windows.Forms.ToolStripTextBox txtCondition;
        public System.Windows.Forms.ToolStripButton btnQuery;
        public System.Windows.Forms.BindingNavigator bindingNavigator1;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ToolStripButton btnAdd;
        public System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.Label lblDepName;
        private System.Windows.Forms.TextBox txtDepId;
        private System.Windows.Forms.Label lblDepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
    }
}