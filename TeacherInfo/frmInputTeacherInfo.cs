using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;

namespace StudentAttendanceMgr.TeacherInfo
{
    public partial class frmInputTeacherInfo : Form
    {
        // 定义存储数据的临时表
        private DataTable dt;
        
        public frmInputTeacherInfo()
        {
            InitializeComponent();
        }

        // 填充教研室名称组合框
        private void FillStaffRoomNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select StaffRoomId, StaffRoomName, DepId from StaffRooms order by DepId asc, StaffRoomId asc";

                //创建数据集
                DataSet dsStaffRooms = new DataSet("Attendance");

                //填充数据集
                dsStaffRooms = DBHelper.getDataSet(selectSql, "StaffRooms");

                //指定“教研室名称组合框”的数据源
                this.cboStaffRoomName.DataSource = dsStaffRooms.Tables["StaffRooms"];
                this.cboStaffRoomName.DisplayMember = "StaffRoomName";
                this.cboStaffRoomName.ValueMember = "StaffRoomId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 填充办公室名称组合框
        private void FillOfficeNameComboBox()
        {
            try
            {
                //查询记录用的sql语句
                string selectSql = "select OfficeId, OfficeName from Offices order by OfficeId asc";

                //创建数据集
                DataSet dsOffices = new DataSet("Attendance");

                //填充数据集
                dsOffices = DBHelper.getDataSet(selectSql, "Offices");

                //指定“办公室名称组合框”的数据源
                this.cboOfficeName.DataSource = dsOffices.Tables["Offices"];
                this.cboOfficeName.DisplayMember = "OfficeName";
                this.cboOfficeName.ValueMember = "OfficeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清空文本框
        private void ClearTextBox()
        {
            this.txtTeacherId.Clear();
            this.txtTeacherName.Clear();
            this.cboSex.Text = "";
            this.cboStaffRoomName.Text = "";
            this.cboOfficeName.Text = "";
            this.txtTelephone.Clear();
        }

        // 锁定文本框，不允许用户输入
        private void LockedTextBox()
        {
            this.txtTeacherId.Enabled = false;
            this.txtTeacherName.Enabled = false;
            this.cboSex.Enabled = false;
            this.cboStaffRoomName.Enabled = false;
            this.cboOfficeName.Enabled = false;
            this.txtTelephone.Enabled = false;
        }

        // 解除锁定，允许用户输入
        private void UnLockedTextBox()
        {
            this.txtTeacherId.Enabled = true;
            this.txtTeacherName.Enabled = true;
            this.cboSex.Enabled = true;
            this.cboStaffRoomName.Enabled = true;
            this.cboOfficeName.Enabled = true;
            this.txtTelephone.Enabled = true;
        }

        // 验证用户输入
        private bool ValidateInput()
        {
            if (this.txtTeacherId.Text.Trim() == "")
            {
                MessageBox.Show("请输入工号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTeacherId.Focus();
                return false;
            }
            else if (this.txtTeacherName.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTeacherName.Focus();
                return false;
            }
            else if (this.cboSex.Text.Trim() == "")
            {
                MessageBox.Show("请输入性别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboSex.Focus();
                return false;
            }
            else if (this.cboStaffRoomName.Text.Trim() == "")
            {
                MessageBox.Show("请输入教研室名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboStaffRoomName.Focus();
                return false;
            }
            else if (this.cboOfficeName.Text.Trim() == "")
            {
                MessageBox.Show("请输入办公室名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboOfficeName.Focus();
                return false;
            }
            else if (this.txtTelephone.Text.Trim() == "")
            {
                MessageBox.Show("请输入联系电话", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTelephone.Focus();
                return false;
            }

            //检查后台数据库的Teachers表中是否存在重复的工号
            string selectSql = String.Format("select count(*) from Teachers where TeacherId = '{0}'", this.txtTeacherId.Text);

            //执行查询操作
            int result = (int)DBHelper.executeScalar(selectSql);

            //如果工号已存在，则提示用户重新输入，并终止操作。
            if (result >= 1)
            {
                MessageBox.Show("该工号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTeacherId.Focus();
                return false;
            }

            //检查临时表中是否存在重复的工号
            DataRow[] dataRowArray = null;

            dataRowArray = dt.Select(String.Format("TeacherId = '{0}'", this.txtTeacherId.Text));

            if (dataRowArray.Length >= 1)
            {
                MessageBox.Show("该工号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTeacherId.Focus();
                return false;
            }

            return true;
        }

        // 窗体加载
        private void frmInputTeacherInfo_Load(object sender, EventArgs e)
        {
            // 初始化教研室名称组合框
            this.FillStaffRoomNameComboBox();

            // 初始化办公室名称组合框
            this.FillOfficeNameComboBox();

            try
            {
                // 创建存储数据的临时表
                dt = new DataTable("Teachers");

                // 添加列
                dt.Columns.Add("TeacherId", typeof(string));
                dt.Columns.Add("TeacherName", typeof(string));
                dt.Columns.Add("Sex", typeof(string));
                dt.Columns.Add("StaffRoomId", typeof(string));
                dt.Columns.Add("OfficeId", typeof(string));
                dt.Columns.Add("Telephone", typeof(string));

                this.btnNext.Enabled = false;   //禁用“下一条”按钮
                this.btnSave.Enabled = false;   //禁用“保存”按钮
                this.btnCancel.Enabled = false; //禁用“取消”按钮

                // 清空文本框
                this.ClearTextBox();

                // 锁定文本框
                this.LockedTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 录入
        private void btnInput_Click(object sender, EventArgs e)
        {
            // 清空临时表
            dt.Rows.Clear();

            //清空文本框
            this.ClearTextBox();

            //解除锁定
            this.UnLockedTextBox();

            this.btnInput.Enabled = false; //禁用“录入”按钮
            this.btnNext.Enabled = true;   //启用“下一条”按钮
            this.btnSave.Enabled = true;   //启用“保存”按钮
            this.btnCancel.Enabled = true; //启用“取消”按钮

            this.txtTeacherId.Focus();
        }

        // 下一条
        private void btnNext_Click(object sender, EventArgs e)
        {
            // 验证用户输入
            if (this.ValidateInput() == false)
            {
                return;
            }

            try
            {
                // 添加新行
                DataRow dr = dt.NewRow();
                dr["TeacherId"] = this.txtTeacherId.Text;
                dr["TeacherName"] = this.txtTeacherName.Text;
                dr["Sex"] = this.cboSex.Text;
                dr["StaffRoomId"] = this.cboStaffRoomName.SelectedValue;
                dr["OfficeId"] = this.cboOfficeName.SelectedValue;
                dr["Telephone"] = this.txtTelephone.Text;

                // 加入新行
                dt.Rows.Add(dr);

                //清空文本框
                this.ClearTextBox();

                this.txtTeacherId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 验证用户输入
            if (this.ValidateInput() == false)
            {
                return;
            }

            try
            {
                // 在临时表中添加新行，以保存最后输入的一条记录。
                DataRow dr = dt.NewRow();
                dr["TeacherId"] = this.txtTeacherId.Text;
                dr["TeacherName"] = this.txtTeacherName.Text;
                dr["Sex"] = this.cboSex.Text;
                dr["StaffRoomId"] = this.cboStaffRoomName.SelectedValue;
                dr["OfficeId"] = this.cboOfficeName.SelectedValue;
                dr["Telephone"] = this.txtTelephone.Text;

                // 加入新行
                dt.Rows.Add(dr);

                int insertResult = 0;

                // 遍历临时表，取出临时表中的每一行，并保存到后台数据库中。
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //添加记录用的SQL语句

                    string insertSql = String.Format("insert into Teachers (TeacherId, TeacherName, TeacherPwd, Sex, StaffRoomId, OfficeId, Telephone) " +
                        "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}') ",
                        dt.Rows[i]["TeacherId"].ToString(),
                        dt.Rows[i]["TeacherName"].ToString(),
                        "888888",
                        dt.Rows[i]["Sex"].ToString(),
                        dt.Rows[i]["StaffRoomId"].ToString(),
                        dt.Rows[i]["OfficeId"].ToString(),
                        dt.Rows[i]["Telephone"].ToString());

                    //执行添加操作
                    insertResult = DBHelper.executeInsertSql(insertSql);
                }

                if (insertResult >= 1)
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 清空临时表
                    dt.Rows.Clear();

                    //锁定文本框
                    this.LockedTextBox();

                    this.btnInput.Enabled = true;    //启用“录入”按钮
                    this.btnNext.Enabled = false;    //禁用“下一条”按钮
                    this.btnSave.Enabled = false;    //禁用“保存”按钮
                    this.btnCancel.Enabled = false;  //禁用“取消”按钮
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 清空临时表
            dt.Rows.Clear();

            //清空文本框
            this.ClearTextBox();

            //锁定文本框
            this.LockedTextBox();

            this.btnInput.Enabled = true;    //启用“录入”按钮
            this.btnNext.Enabled = false;    //禁用“下一条”按钮
            this.btnSave.Enabled = false;    //禁用“保存”按钮
            this.btnCancel.Enabled = false;  //禁用“取消”按钮
        }
    }
}