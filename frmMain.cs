using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using StudentAttendanceMgr.CommonClass;
using StudentAttendanceMgr.BasicInfo;
using StudentAttendanceMgr.CourseScheduleInfo;
using StudentAttendanceMgr.StudentInfo;
using StudentAttendanceMgr.TeacherInfo;
using StudentAttendanceMgr.SysManager;
using StudentAttendanceMgr.StudentService;
using StudentAttendanceMgr.TeacherService;
using StudentAttendanceMgr.StudentAttendance;
using StudentAttendanceMgr.Help;


namespace StudentAttendanceMgr
{
    public partial class frmMain : Form
    {
        private frmDepartmentInfo  frmDepartment = null;
        private frmSpecialityInfo frmSpeciality = null;
        private frmClassInfo frmClass = null;
        private frmStaffRoomInfo frmStaffRoom = null;
        private frmDormInfo frmDorm = null;
        private frmOfficeInfo frmOffice = null;
        private frmClassRoomInfo frmClassRoom = null;
        private frmCourseInfo frmCourse = null;
        private frmInitWeekInfo frmInitWeek = null;
        private frmAttendanceStatusInfo frmAttendanceStatus = null;
        private frmInputCourseScheduleInfo frmInputCourseSchedule = null;
        private frmManageCourseScheduleInfo frmManageCourseSchedule = null;
        private frmViewCourseScheduleInfo frmViewCourseSchedule = null;
        private frmInputStudentInfo frmInputStudent = null;
        private frmManageStudentInfo frmManageStudent = null;
        private frmViewStudentInfo frmViewStudent = null;
        private frmInputTeacherInfo frmInputTeacher = null;
        private frmManageTeacherInfo frmManageTeacher = null;
        private frmViewTeacherInfo frmViewTeacher = null;
        private frmManageUserInfo frmManageUser = null;
        private frmEditAdminPwd frmUpdateAdminPwd = null;
        private frmViewStudentCourseInfo frmViewStudentCourse = null;
        private frmViewPersonalAttendance frmPersonalAttendance = null;
        private frmViewMyTeacherInfo frmViewMyTeacher = null;
        private frmSetStudentInfo frmSetStudent = null;
        private frmEditStudentPwd frmUpdateStudentPwd = null;
        private frmViewTeacherCourseInfo frmViewTeacherCourse = null;
        private frmViewMyStudentInfo frmViewMyStudent = null;
        private frmSetTeacherInfo frmSetTeacher = null;
        private frmEditTeacherPwd frmUpdateTeacherPwd = null;
        private frmInputAttendanceInfo frmInputAttendance = null;
        private frmManageAttendanceInfo frmManageAttendance = null;
        private frmViewAttendanceInfo frmViewAttendance = null;
        private frmViewCurrentAttendanceInfo frmViewCurrentAttendance = null;
        
        public frmMain()
        {
            InitializeComponent();
        }

        // 获取当前登录用户的名称
        private string getUserName()
        {
            string userName = "";
            
            if (CommonInfo.userType == "学生")
            {
                //查询记录用的SQL语句
                string selectSql = String.Format("select StuName from Students where StuId = '{0}'", CommonInfo.userId);

                //执行查询操作
                userName = (string)DBHelper.executeScalar(selectSql);
            }
            else if (CommonInfo.userType == "教师")
            {
                //查询记录用的SQL语句
                string selectSql = String.Format("select TeacherName from Teachers where TeacherId = '{0}'", CommonInfo.userId);

                //执行查询操作
                userName = (string)DBHelper.executeScalar(selectSql);
            }
            else if (CommonInfo.userType == "系统管理员")
            {
                //查询记录用的SQL语句
                string selectSql = String.Format("select UserName from Users where UserId = '{0}'", CommonInfo.userId);

                //执行查询操作
                userName = (string)DBHelper.executeScalar(selectSql);
            }

            return userName;
        }

        // 窗体加载
        private void frmMain_Load(object sender, EventArgs e)
        {
            //根据当前登录用户的类型，控制各个菜单和各个面板的可见性
            if (CommonInfo.userType == "学生")
            {
                this.mnuBasicInfo.Visible = false;           //隐藏“基础信息设置”主菜单
                this.mnuCourseScheduleInfo.Visible = false;  //隐藏“课表管理”主菜单
                this.mnuStudentInfo.Visible = false;         //隐藏“学生信息管理”主菜单
                this.mnuTeacherInfo.Visible = false;         //隐藏“教师信息管理”主菜单
                this.mnuSysManagement.Visible = false;       //隐藏“系统管理”主菜单
                this.mnuStudentService.Visible = true;       //显示“学生服务”主菜单
                this.mnuTeacherService.Visible = false;      //隐藏“教师服务”主菜单
                this.mnuAttendanceInfo.Visible = false;      //隐藏“学生出勤管理”主菜单

                this.xpnlBasicInfo.Visible = false;           //隐藏“基础信息设置”面板
                this.xpnlCourseScheduleInfo.Visible = false;  //隐藏“课表管理”面板
                this.xpnlStudentInfo.Visible = false;         //隐藏“学生信息管理”面板
                this.xpnlTeacherInfo.Visible = false;         //隐藏“教师信息管理”面板
                this.xpnlSysManagement.Visible = false;       //隐藏“系统管理”面板
                this.xpnlStudentService.Visible = true;       //显示“学生服务”面板
                this.xpnlTeacherService.Visible = false;      //隐藏“教师服务”面板
                this.xpnlAttendanceInfo.Visible = false;      //隐藏“学生出勤管理”面板

                this.xpnlStudentService.Expand = true;        //展开“学生服务”面板

                // 获取当前学生当天所有上课节次
                AttendanceHelper.getCurrentAllSchoolTimeOfStudent(CommonInfo.userId);

                // 启动 tmrStudent 计时器
                this.tmrStudent.Enabled = true;
            }
            else if (CommonInfo.userType == "教师")
            {
                this.mnuBasicInfo.Visible = false;           //隐藏“基础信息设置”主菜单
                this.mnuCourseScheduleInfo.Visible = false;  //隐藏“课表管理”主菜单
                this.mnuStudentInfo.Visible = false;         //隐藏“学生信息管理”主菜单
                this.mnuTeacherInfo.Visible = false;         //隐藏“教师信息管理”主菜单
                this.mnuSysManagement.Visible = false;       //隐藏“系统管理”主菜单
                this.mnuStudentService.Visible = false;      //隐藏“学生服务”主菜单
                this.mnuTeacherService.Visible = true;       //显示“教师服务”主菜单
                this.mnuAttendanceInfo.Visible = true;       //显示“学生出勤管理”主菜单

                this.xpnlBasicInfo.Visible = false;           //隐藏“基础信息设置”面板
                this.xpnlCourseScheduleInfo.Visible = false;  //隐藏“课表管理”面板
                this.xpnlStudentInfo.Visible = false;         //隐藏“学生信息管理”面板
                this.xpnlTeacherInfo.Visible = false;         //隐藏“教师信息管理”面板
                this.xpnlSysManagement.Visible = false;       //隐藏“系统管理”面板
                this.xpnlStudentService.Visible = false;      //隐藏“学生服务”面板
                this.xpnlTeacherService.Visible = true;       //显示“教师服务”面板
                this.xpnlAttendanceInfo.Visible = true;       //显示“学生出勤管理”面板

                this.xpnlTeacherService.Expand = true;        //展开“教师服务”面板

                // 获取当前教师当天所有上课节次、课程编号和班级编号
                AttendanceHelper.getCurrentAllSchoolTimeOfTeacher(CommonInfo.userId);

                // 启动 tmrTeacher 计时器
                this.tmrTeacher.Enabled = true;
            }
            else if (CommonInfo.userType == "系统管理员")
            {
                this.mnuBasicInfo.Visible = true;            //显示“基础信息设置”主菜单
                this.mnuCourseScheduleInfo.Visible = true;   //显示“课表管理”主菜单
                this.mnuStudentInfo.Visible = true;          //显示“学生信息管理”主菜单
                this.mnuTeacherInfo.Visible = true;          //显示“教师信息管理”主菜单
                this.mnuSysManagement.Visible = true;        //显示“系统管理”主菜单
                this.mnuStudentService.Visible = false;      //隐藏“学生服务”主菜单
                this.mnuTeacherService.Visible = false;      //隐藏“教师服务”主菜单
                this.mnuAttendanceInfo.Visible = false;      //隐藏“学生出勤管理”主菜单

                this.xpnlBasicInfo.Visible = true;           //显示“基础信息设置”面板
                this.xpnlCourseScheduleInfo.Visible = true;  //显示“课表管理”面板
                this.xpnlStudentInfo.Visible = true;         //显示“学生信息管理”面板
                this.xpnlTeacherInfo.Visible = true;         //显示“教师信息管理”面板
                this.xpnlSysManagement.Visible = true;       //显示“系统管理”面板
                this.xpnlStudentService.Visible = false;     //隐藏“学生服务”面板
                this.xpnlTeacherService.Visible = false;     //隐藏“教师服务”面板
                this.xpnlAttendanceInfo.Visible = false;     //隐藏“学生出勤管理”面板

                this.xpnlBasicInfo.Expand = true;            //展开“基础信息设置”面板
            }

            //设置状态栏的各个部分
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;  //获取屏幕的宽度
            this.tsslblLoginUser.Width = Convert.ToInt32(screenWidth * 0.3);       //“当前登录用户”标签的宽度占30%
            this.tsslblLoginTime.Width = Convert.ToInt32(screenWidth * 0.3);       //“登录时间”标签的宽度占30%
            this.tsslblCurrentTime.Width = Convert.ToInt32(screenWidth * 0.3);     //“当前时间”标签的宽度占30%

            this.tsslblLoginUser.Text = "当前登录用户： " + this.getUserName();        //显示“当前登录用户”
            this.tsslblLoginTime.Text = "登录时间： " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();  //显示“登录时间”
        
            //  自动显示滚动条
            this.xpnlBasicInfo.AutoScroll = true;
        }

        // 设置状态栏中的当前时间
        private void tmrCurrentTime_Tick(object sender, EventArgs e)
        {
            this.tsslblCurrentTime.Text = "当前时间： " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

     

        // 不断刷新当前时间，控制教师服务模块中“点名”按钮是否有效。
        private void tmrTeacher_Tick(object sender, EventArgs e)
        {
            // 如果能点名，则启用“点名”按钮。
            if (AttendanceHelper.CanTakeAttendance() == true)
            {
                this.btnTakeAttendance.Enabled = true;
            }
            else
            {
                // 如果不能点名，则禁用“点名”按钮。
                this.btnTakeAttendance.Enabled = false;
            }
        }

        // 关闭主窗体前，询问用户是真的要退出。
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确认要退出系统吗？", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        // 关闭主窗体后，退出应用程序。
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // 层叠
        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // 水平平铺
        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // 垂直平铺
        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // 打开“院系设置”窗体
        private void mnuDepartmentInfo_Click(object sender, EventArgs e)
        {
            if (frmDepartment == null)
            {
                frmDepartment = new frmDepartmentInfo();
                frmDepartment.MdiParent = this;
                frmDepartment.Show();
            }
            else
            {
                if (frmDepartment.IsDisposed)
                {
                    frmDepartment = new frmDepartmentInfo();
                }
                frmDepartment.MdiParent = this;
                frmDepartment.Show();
                frmDepartment.Activate();
            }
        }

        // 打开“专业设置”窗体
        private void mnuSpecialityInfo_Click(object sender, EventArgs e)
        {
            if (frmSpeciality == null)
            {
                frmSpeciality = new frmSpecialityInfo();
                frmSpeciality.MdiParent = this;
                frmSpeciality.Show();
            }
            else
            {
                if (frmSpeciality.IsDisposed)
                {
                    frmSpeciality = new frmSpecialityInfo();
                }
                frmSpeciality.MdiParent = this;
                frmSpeciality.Show();
                frmSpeciality.Activate();
            }
        }

        // 打开“班级设置”窗体
        private void mnuClassInfo_Click(object sender, EventArgs e)
        {
            if (frmClass == null)
            {
                frmClass = new frmClassInfo();
                frmClass.MdiParent = this;
                frmClass.Show();
            }
            else
            {
                if (frmClass.IsDisposed)
                {
                    frmClass = new frmClassInfo();
                }
                frmClass.MdiParent = this;
                frmClass.Show();
                frmClass.Activate();
            }
        }

        // 打开“教研室设置”窗体
        private void mnuStaffRoomInfo_Click(object sender, EventArgs e)
        {
            if (frmStaffRoom == null)
            {
                frmStaffRoom = new frmStaffRoomInfo();
                frmStaffRoom.MdiParent = this;
                frmStaffRoom.Show();
            }
            else
            {
                if (frmStaffRoom.IsDisposed)
                {
                    frmStaffRoom = new frmStaffRoomInfo();
                }
                frmStaffRoom.MdiParent = this;
                frmStaffRoom.Show();
                frmStaffRoom.Activate();
            }
        }

        // 打开“宿舍设置”窗体
        private void mnuDormInfo_Click(object sender, EventArgs e)
        {
            if (frmDorm == null)
            {
                frmDorm = new frmDormInfo();
                frmDorm.MdiParent = this;
                frmDorm.Show();
            }
            else
            {
                if (frmDorm.IsDisposed)
                {
                    frmDorm = new frmDormInfo();
                }
                frmDorm.MdiParent = this;
                frmDorm.Show();
                frmDorm.Activate();
            }
        }

        // 打开“办公室设置”窗体
        private void mnuOfficeInfo_Click(object sender, EventArgs e)
        {
            if (frmOffice == null)
            {
                frmOffice = new frmOfficeInfo();
                frmOffice.MdiParent = this;
                frmOffice.Show();
            }
            else
            {
                if (frmOffice.IsDisposed)
                {
                    frmOffice = new frmOfficeInfo();
                }
                frmOffice.MdiParent = this;
                frmOffice.Show();
                frmOffice.Activate();
            }
        }

        // 打开“教室设置”窗体
        private void mnuClassRoomInfo_Click(object sender, EventArgs e)
        {
            if (frmClassRoom == null)
            {
                frmClassRoom = new frmClassRoomInfo();
                frmClassRoom.MdiParent = this;
                frmClassRoom.Show();
            }
            else
            {
                if (frmClassRoom.IsDisposed)
                {
                    frmClassRoom = new frmClassRoomInfo();
                }
                frmClassRoom.MdiParent = this;
                frmClassRoom.Show();
                frmClassRoom.Activate();
            }
        }

        // 打开“课程设置”窗体
        private void mnuCourseInfo_Click(object sender, EventArgs e)
        {
            if (frmCourse == null)
            {
                frmCourse = new frmCourseInfo();
                frmCourse.MdiParent = this;
                frmCourse.Show();
            }
            else
            {
                if (frmCourse.IsDisposed)
                {
                    frmCourse = new frmCourseInfo();
                }
                frmCourse.MdiParent = this;
                frmCourse.Show();
                frmCourse.Activate();
            }
        }

        // 打开“考勤时间设置”窗体
        private void mnuInitWeekInfo_Click(object sender, EventArgs e)
        {
            if (frmInitWeek == null)
            {
                frmInitWeek = new frmInitWeekInfo();
                frmInitWeek.MdiParent = this;
                frmInitWeek.Show();
            }
            else
            {
                if (frmInitWeek.IsDisposed)
                {
                    frmInitWeek = new frmInitWeekInfo();
                }
                frmInitWeek.MdiParent = this;
                frmInitWeek.Show();
                frmInitWeek.Activate();
            }
        }

        // 打开“考勤状态设置”窗体
        private void mnuAttendanceStatusInfo_Click(object sender, EventArgs e)
        {
            if (frmAttendanceStatus == null)
            {
                frmAttendanceStatus = new frmAttendanceStatusInfo();
                frmAttendanceStatus.MdiParent = this;
                frmAttendanceStatus.Show();
            }
            else
            {
                if (frmAttendanceStatus.IsDisposed)
                {
                    frmAttendanceStatus = new frmAttendanceStatusInfo();
                }
                frmAttendanceStatus.MdiParent = this;
                frmAttendanceStatus.Show();
                frmAttendanceStatus.Activate();
            }
        }

        // 打开“课表录入”窗体
        private void mnuInputCourseScheduleInfo_Click(object sender, EventArgs e)
        {
            if (frmInputCourseSchedule == null)
            {
                frmInputCourseSchedule = new frmInputCourseScheduleInfo();
                frmInputCourseSchedule.MdiParent = this;
                frmInputCourseSchedule.Show();
            }
            else
            {
                if (frmInputCourseSchedule.IsDisposed)
                {
                    frmInputCourseSchedule = new frmInputCourseScheduleInfo();
                }
                frmInputCourseSchedule.MdiParent = this;
                frmInputCourseSchedule.Show();
                frmInputCourseSchedule.Activate();
            }
        }

        // 打开“课表维护”窗体
        private void mnuManageCourseScheduleInfo_Click(object sender, EventArgs e)
        {
            if (frmManageCourseSchedule == null)
            {
                frmManageCourseSchedule = new frmManageCourseScheduleInfo();
                frmManageCourseSchedule.MdiParent = this;
                frmManageCourseSchedule.Show();
            }
            else
            {
                if (frmManageCourseSchedule.IsDisposed)
                {
                    frmManageCourseSchedule = new frmManageCourseScheduleInfo();
                }
                frmManageCourseSchedule.MdiParent = this;
                frmManageCourseSchedule.Show();
                frmManageCourseSchedule.Activate();
            }
        }

        // 打开“课表查看”窗体
        private void mnuViewCourseScheduleInfo_Click(object sender, EventArgs e)
        {
            if (frmViewCourseSchedule == null)
            {
                frmViewCourseSchedule = new frmViewCourseScheduleInfo();
                frmViewCourseSchedule.MdiParent = this;
                frmViewCourseSchedule.Show();
            }
            else
            {
                if (frmViewCourseSchedule.IsDisposed)
                {
                    frmViewCourseSchedule = new frmViewCourseScheduleInfo();
                }
                frmViewCourseSchedule.MdiParent = this;
                frmViewCourseSchedule.Show();
                frmViewCourseSchedule.Activate();
            }
        }

        // 打开“学生信息录入”窗体
        private void mnuInputStudentInfo_Click(object sender, EventArgs e)
        {
            if (frmInputStudent == null)
            {
                frmInputStudent = new frmInputStudentInfo();
                frmInputStudent.MdiParent = this;
                frmInputStudent.Show();
            }
            else
            {
                if (frmInputStudent.IsDisposed)
                {
                    frmInputStudent = new frmInputStudentInfo();
                }
                frmInputStudent.MdiParent = this;
                frmInputStudent.Show();
                frmInputStudent.Activate();
            }
        }

        // 打开“学生信息维护”窗体
        private void mnuManageStudentInfo_Click(object sender, EventArgs e)
        {
            if (frmManageStudent == null)
            {
                frmManageStudent = new frmManageStudentInfo();
                frmManageStudent.MdiParent = this;
                frmManageStudent.Show();
            }
            else
            {
                if (frmManageStudent.IsDisposed)
                {
                    frmManageStudent = new frmManageStudentInfo();
                }
                frmManageStudent.MdiParent = this;
                frmManageStudent.Show();
                frmManageStudent.Activate();
            }
        }

        // 打开“学生信息查看”窗体
        private void mnuViewStudentInfo_Click(object sender, EventArgs e)
        {
            if (frmViewStudent == null)
            {
                frmViewStudent = new frmViewStudentInfo();
                frmViewStudent.MdiParent = this;
                frmViewStudent.Show();
            }
            else
            {
                if (frmViewStudent.IsDisposed)
                {
                    frmViewStudent = new frmViewStudentInfo();
                }
                frmViewStudent.MdiParent = this;
                frmViewStudent.Show();
                frmViewStudent.Activate();
            }
        }

        // 打开“教师信息录入”窗体
        private void mnuInputTeacherInfo_Click(object sender, EventArgs e)
        {
            if (frmInputTeacher == null)
            {
                frmInputTeacher = new frmInputTeacherInfo();
                frmInputTeacher.MdiParent = this;
                frmInputTeacher.Show();
            }
            else
            {
                if (frmInputTeacher.IsDisposed)
                {
                    frmInputTeacher = new frmInputTeacherInfo();
                }
                frmInputTeacher.MdiParent = this;
                frmInputTeacher.Show();
                frmInputTeacher.Activate();
            }
        }

        // 打开“教师信息维护”窗体
        private void mnuManageTeacherInfo_Click(object sender, EventArgs e)
        {
            if (frmManageTeacher == null)
            {
                frmManageTeacher = new frmManageTeacherInfo();
                frmManageTeacher.MdiParent = this;
                frmManageTeacher.Show();
            }
            else
            {
                if (frmManageTeacher.IsDisposed)
                {
                    frmManageTeacher = new frmManageTeacherInfo();
                }
                frmManageTeacher.MdiParent = this;
                frmManageTeacher.Show();
                frmManageTeacher.Activate();
            }
        }

        // 打开“教师信息查看”窗体
        private void mnuViewTeacherInfo_Click(object sender, EventArgs e)
        {
            if (frmViewTeacher == null)
            {
                frmViewTeacher = new frmViewTeacherInfo();
                frmViewTeacher.MdiParent = this;
                frmViewTeacher.Show();
            }
            else
            {
                if (frmViewTeacher.IsDisposed)
                {
                    frmViewTeacher = new frmViewTeacherInfo();
                }
                frmViewTeacher.MdiParent = this;
                frmViewTeacher.Show();
                frmViewTeacher.Activate();
            }
        }

        // 打开“用户信息维护”窗体
        private void mnuManageUserInfo_Click(object sender, EventArgs e)
        {
            if (frmManageUser == null)
            {
                frmManageUser = new frmManageUserInfo();
                frmManageUser.MdiParent = this;
                frmManageUser.Show();
            }
            else
            {
                if (frmManageUser.IsDisposed)
                {
                    frmManageUser = new frmManageUserInfo();
                }
                frmManageUser.MdiParent = this;
                frmManageUser.Show();
                frmManageUser.Activate();
            }
        }

        // 打开“修改密码”窗体 (系统管理员)
        private void mnuEditAdminPwd_Click(object sender, EventArgs e)
        {
            if (frmUpdateAdminPwd == null)
            {
                frmUpdateAdminPwd = new frmEditAdminPwd();
                frmUpdateAdminPwd.MdiParent = this;
                frmUpdateAdminPwd.Show();
            }
            else
            {
                if (frmUpdateAdminPwd.IsDisposed)
                {
                    frmUpdateAdminPwd = new frmEditAdminPwd();
                }
                frmUpdateAdminPwd.MdiParent = this;
                frmUpdateAdminPwd.Show();
                frmUpdateAdminPwd.Activate();
            }
        }

        // 退出系统 (系统管理员)
        private void mnuAdminExit_Click(object sender, EventArgs e)
        {
            this.Close();  // 关闭主窗体
        }

        // 打开“查看个人课表”窗体 (学生)
        private void mnuViewStudentCourseInfo_Click(object sender, EventArgs e)
        {
            if (frmViewStudentCourse == null)
            {
                frmViewStudentCourse = new frmViewStudentCourseInfo();
                frmViewStudentCourse.MdiParent = this;
                frmViewStudentCourse.Show();
            }
            else
            {
                if (frmViewStudentCourse.IsDisposed)
                {
                    frmViewStudentCourse = new frmViewStudentCourseInfo();
                }
                frmViewStudentCourse.MdiParent = this;
                frmViewStudentCourse.Show();
                frmViewStudentCourse.Activate();
            }
        }

        // 打开“查看个人出勤信息”窗体
        private void mnuViewPersonalAttendance_Click(object sender, EventArgs e)
        {
            if (frmPersonalAttendance == null)
            {
                frmPersonalAttendance = new frmViewPersonalAttendance();
                frmPersonalAttendance.MdiParent = this;
                frmPersonalAttendance.Show();
            }
            else
            {
                if (frmPersonalAttendance.IsDisposed)
                {
                    frmPersonalAttendance = new frmViewPersonalAttendance();
                }
                frmPersonalAttendance.MdiParent = this;
                frmPersonalAttendance.Show();
                frmPersonalAttendance.Activate();
            }
        }

        // 打开“查看教师信息”窗体
        private void mnuViewMyTeacherInfo_Click(object sender, EventArgs e)
        {
            if (frmViewMyTeacher == null)
            {
                frmViewMyTeacher = new frmViewMyTeacherInfo();
                frmViewMyTeacher.MdiParent = this;
                frmViewMyTeacher.Show();
            }
            else
            {
                if (frmViewMyTeacher.IsDisposed)
                {
                    frmViewMyTeacher = new frmViewMyTeacherInfo();
                }
                frmViewMyTeacher.MdiParent = this;
                frmViewMyTeacher.Show();
                frmViewMyTeacher.Activate();
            }
        }

        // 打开“设置个人资料”窗体 (学生)
        private void mnuSetStudentInfo_Click(object sender, EventArgs e)
        {
            if (frmSetStudent == null)
            {
                frmSetStudent = new frmSetStudentInfo();
                frmSetStudent.MdiParent = this;
                frmSetStudent.Show();
            }
            else
            {
                if (frmSetStudent.IsDisposed)
                {
                    frmSetStudent = new frmSetStudentInfo();
                }
                frmSetStudent.MdiParent = this;
                frmSetStudent.Show();
                frmSetStudent.Activate();
            }
        }

        // 打开“修改密码”窗体 (学生)
        private void mnuEditStudentPwd_Click(object sender, EventArgs e)
        {
            if (frmUpdateStudentPwd == null)
            {
                frmUpdateStudentPwd = new frmEditStudentPwd();
                frmUpdateStudentPwd.MdiParent = this;
                frmUpdateStudentPwd.Show();
            }
            else
            {
                if (frmUpdateStudentPwd.IsDisposed)
                {
                    frmUpdateStudentPwd = new frmEditStudentPwd();
                }
                frmUpdateStudentPwd.MdiParent = this;
                frmUpdateStudentPwd.Show();
                frmUpdateStudentPwd.Activate();
            }
        }

        // 退出系统 (学生)
        private void mnuStudentExit_Click(object sender, EventArgs e)
        {
            this.Close();  // 关闭主窗体
        }

        // 打开“查看个人课表”窗体 (教师)
        private void mnuViewTeacherCourseInfo_Click(object sender, EventArgs e)
        {
            if (frmViewTeacherCourse == null)
            {
                frmViewTeacherCourse = new frmViewTeacherCourseInfo();
                frmViewTeacherCourse.MdiParent = this;
                frmViewTeacherCourse.Show();
            }
            else
            {
                if (frmViewTeacherCourse.IsDisposed)
                {
                    frmViewTeacherCourse = new frmViewTeacherCourseInfo();
                }
                frmViewTeacherCourse.MdiParent = this;
                frmViewTeacherCourse.Show();
                frmViewTeacherCourse.Activate();
            }
        }

        // 打开“查看学生信息”窗体
        private void mnuViewMyStudentInfo_Click(object sender, EventArgs e)
        {
            if (frmViewMyStudent == null)
            {
                frmViewMyStudent = new frmViewMyStudentInfo();
                frmViewMyStudent.MdiParent = this;
                frmViewMyStudent.Show();
            }
            else
            {
                if (frmViewMyStudent.IsDisposed)
                {
                    frmViewMyStudent = new frmViewMyStudentInfo();
                }
                frmViewMyStudent.MdiParent = this;
                frmViewMyStudent.Show();
                frmViewMyStudent.Activate();
            }
        }

        // 打开“设置个人资料”窗体
        private void mnuSetTeacherInfo_Click(object sender, EventArgs e)
        {
            if (frmSetTeacher == null)
            {
                frmSetTeacher = new frmSetTeacherInfo();
                frmSetTeacher.MdiParent = this;
                frmSetTeacher.Show();
            }
            else
            {
                if (frmSetTeacher.IsDisposed)
                {
                    frmSetTeacher = new frmSetTeacherInfo();
                }
                frmSetTeacher.MdiParent = this;
                frmSetTeacher.Show();
                frmSetTeacher.Activate();
            }
        }

        // 打开“修改密码”窗体
        private void mnuEditTeacherPwd_Click(object sender, EventArgs e)
        {
            if (frmUpdateTeacherPwd == null)
            {
                frmUpdateTeacherPwd = new frmEditTeacherPwd();
                frmUpdateTeacherPwd.MdiParent = this;
                frmUpdateTeacherPwd.Show();
            }
            else
            {
                if (frmUpdateTeacherPwd.IsDisposed)
                {
                    frmUpdateTeacherPwd = new frmEditTeacherPwd();
                }
                frmUpdateTeacherPwd.MdiParent = this;
                frmUpdateTeacherPwd.Show();
                frmUpdateTeacherPwd.Activate();
            }
        }

        // 退出系统 (教师)
        private void mnuTeacherExit_Click(object sender, EventArgs e)
        {
            this.Close();  // 关闭主窗体
        }

        // 打开“学生出勤信息录入”窗体
        private void mnuInputAttendanceInfo_Click(object sender, EventArgs e)
        {
            if (frmInputAttendance == null)
            {
                frmInputAttendance = new frmInputAttendanceInfo();
                frmInputAttendance.MdiParent = this;
                frmInputAttendance.Show();
            }
            else
            {
                if (frmInputAttendance.IsDisposed)
                {
                    frmInputAttendance = new frmInputAttendanceInfo();
                }
                frmInputAttendance.MdiParent = this;
                frmInputAttendance.Show();
                frmInputAttendance.Activate();
            }
        }

        // 打开“学生出勤信息维护”窗体
        private void mnuManageAttendanceInfo_Click(object sender, EventArgs e)
        {
            if (frmManageAttendance == null)
            {
                frmManageAttendance = new frmManageAttendanceInfo();
                frmManageAttendance.MdiParent = this;
                frmManageAttendance.Show();
            }
            else
            {
                if (frmManageAttendance.IsDisposed)
                {
                    frmManageAttendance = new frmManageAttendanceInfo();
                }
                frmManageAttendance.MdiParent = this;
                frmManageAttendance.Show();
                frmManageAttendance.Activate();
            }
        }

        // 打开“学生出勤信息查看”窗体
        private void mnuViewAttendanceInfo_Click(object sender, EventArgs e)
        {
            if (frmViewAttendance == null)
            {
                frmViewAttendance = new frmViewAttendanceInfo();
                frmViewAttendance.MdiParent = this;
                frmViewAttendance.Show();
            }
            else
            {
                if (frmViewAttendance.IsDisposed)
                {
                    frmViewAttendance = new frmViewAttendanceInfo();
                }
                frmViewAttendance.MdiParent = this;
                frmViewAttendance.Show();
                frmViewAttendance.Activate();
            }
        }

        // 打开“关于”窗体
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

       

        // 点名 (教师)
        // 当教师单击“点名”按钮后，录入当前上课班级所有学生的迟到信息。
        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance f = new frmAttendance();
            f.Show();
            AttendanceHelper.insertAllStudentAttendancesInfo("2", "");

          
        }

        // 打开“查看当前出勤信息”窗体
        private void btnViewCurrentAttendance_Click(object sender, EventArgs e)
        {
            if (frmViewCurrentAttendance == null)
            {
                frmViewCurrentAttendance = new frmViewCurrentAttendanceInfo();
                frmViewCurrentAttendance.MdiParent = this;
                frmViewCurrentAttendance.Show();
            }
            else
            {
                if (frmViewCurrentAttendance.IsDisposed)
                {
                    frmViewCurrentAttendance = new frmViewCurrentAttendanceInfo();
                }
                frmViewCurrentAttendance.MdiParent = this;
                frmViewCurrentAttendance.Show();
                frmViewCurrentAttendance.Activate();
            }
        }
    }
}