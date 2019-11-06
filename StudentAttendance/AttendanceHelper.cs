using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using StudentAttendanceMgr.CommonClass;
using System.Globalization;
using System.Collections;

namespace StudentAttendanceMgr.StudentAttendance
{
    //学生出勤管理帮助类
    class AttendanceHelper
    {
        // 定义一个数组列表，用来存放当前学生当天所有上课节次。
        public static ArrayList arraySchoolTimeOfStudent = new ArrayList();

        // 定义一个数组列表，用来存放当前教师当天所有上课节次、课程编号和班级编号。
        public static ArrayList arraySchoolTimeOfTeacher = new ArrayList();
        
        // 获取当前学年
        public static string getCurrentSchoolYear()
        {
            string currentSchoolYear = "";    // 当前学年

            // 中国的农历
            ChineseLunisolarCalendar chineseDate = new ChineseLunisolarCalendar();

            // 获取当前学年以农历为准
            currentSchoolYear = Convert.ToString(chineseDate.GetYear(DateTime.Now)) + "年";

            return currentSchoolYear;
        }

        // 获取当前学期
        public static string getCurrentSemester()
        {
            string currenSemester = "";       // 当前学期

            // 获取当前学年的上学期的第一周的第一天
            // 查询记录用的SQL语句
            string selectFirstSemesterSql = String.Format("select FirstWeek from InitWeeks where SchoolYear = '{0}' and Semester = '上学期'",
                getCurrentSchoolYear());

            // 执行查询操作
            DateTime firstSemester_Start = Convert.ToDateTime(DBHelper.executeScalar(selectFirstSemesterSql));

            // 获取当前学年的下学期的第一周的第一天
            // 查询记录用的SQL语句
            string selectSecondSemesterSql = String.Format("select FirstWeek from InitWeeks where SchoolYear = '{0}' and Semester = '下学期'",
                getCurrentSchoolYear());

            // 执行查询操作
            DateTime secondSemester_Start = Convert.ToDateTime(DBHelper.executeScalar(selectSecondSemesterSql));

            // 判断当前时间属于哪个学期
            DateTime now = DateTime.Now;  // 当前时间
            DateTime firstSemester_End = Convert.ToDateTime(DateTime.Now.Year.ToString() + "-07-12");          //上学期结束时间
            DateTime secondSemester_End = Convert.ToDateTime((DateTime.Now.Year + 1).ToString() + "-01-18");   //下学期结束时间

            if (now >= firstSemester_Start && now <= firstSemester_End)
            {
                currenSemester = "上学期";
            }

            if (now >= secondSemester_Start && now <= secondSemester_End)
            {
                currenSemester = "下学期";
            }

            return currenSemester;
        }

        // 获取指定的时间属于一年中的第几周
        private static int GetWeekOfYear(DateTime dt)
        {
            CultureInfo ci = new CultureInfo("zh-CN");
            System.Globalization.Calendar cal = ci.Calendar;
            CalendarWeekRule cwr = ci.DateTimeFormat.CalendarWeekRule;
            DayOfWeek dow = DayOfWeek.Monday;
            int week = cal.GetWeekOfYear(dt, cwr, dow);
            return week;
        }

        // 获取当前周次
        public static string getCurrentWeek()
        {
            string currentWeek = "";       // 当前周次

            // 获取当前学期
            string currenSemester = getCurrentSemester();

            if (currenSemester != "")
            {
                // 获取当前学期的第一周的第一天
                // 查询记录用的SQL语句
                string selectFirstWeekSql = String.Format("select FirstWeek from InitWeeks where SchoolYear = '{0}' and Semester = '{1}'",
                    getCurrentSchoolYear(), currenSemester);

                // 执行查询操作
                DateTime firstWeek = Convert.ToDateTime(DBHelper.executeScalar(selectFirstWeekSql));

                int initWeek = GetWeekOfYear(firstWeek);

                int currWeek = 0;

                if (currenSemester == "上学期")
                {
                    currWeek = GetWeekOfYear(DateTime.Now) + 1 - initWeek;
                }
                else if (currenSemester == "下学期")
                {
                    if (firstWeek.Year == DateTime.Now.Year)
                    {
                        currWeek = GetWeekOfYear(DateTime.Now) + 1 - initWeek;
                    }
                    else if (firstWeek.Year < DateTime.Now.Year)
                    {

                        currWeek = GetWeekOfYear(new DateTime(firstWeek.Year, 12, 31)) + 1 - initWeek;

                        if (new DateTime(firstWeek.Year, 12, 31).DayOfWeek == DayOfWeek.Sunday)
                        {
                            currWeek = currWeek + GetWeekOfYear(DateTime.Now);
                        }
                        else
                        {
                            currWeek = currWeek + GetWeekOfYear(DateTime.Now) - 1;
                        }
                    }
                }

                switch (currWeek)
                {
                    case 1:
                        {
                            currentWeek = "第一周";
                            break;
                        }
                    case 2:
                        {
                            currentWeek = "第二周";
                            break;
                        }
                    case 3:
                        {
                            currentWeek = "第三周";
                            break;
                        }
                    case 4:
                        {
                            currentWeek = "第四周";
                            break;
                        }
                    case 5:
                        {
                            currentWeek = "第五周";
                            break;
                        }
                    case 6:
                        {
                            currentWeek = "第六周";
                            break;
                        }
                    case 7:
                        {
                            currentWeek = "第七周";
                            break;
                        }
                    case 8:
                        {
                            currentWeek = "第八周";
                            break;
                        }
                    case 9:
                        {
                            currentWeek = "第九周";
                            break;
                        }
                    case 10:
                        {
                            currentWeek = "第十周";
                            break;
                        }
                    case 11:
                        {
                            currentWeek = "第十一周";
                            break;
                        }
                    case 12:
                        {
                            currentWeek = "第十二周";
                            break;
                        }
                    case 13:
                        {
                            currentWeek = "第十三周";
                            break;
                        }
                    case 14:
                        {
                            currentWeek = "第十四周";
                            break;
                        }
                    case 15:
                        {
                            currentWeek = "第十五周";
                            break;
                        }
                    case 16:
                        {
                            currentWeek = "第十六周";
                            break;
                        }
                    case 17:
                        {
                            currentWeek = "第十七周";
                            break;
                        }
                    case 18:
                        {
                            currentWeek = "第十八周";
                            break;
                        }
                    case 19:
                        {
                            currentWeek = "第十九周";
                            break;
                        }
                    case 20:
                        {
                            currentWeek = "第二十周";
                            break;
                        }
                    case 21:
                        {
                            currentWeek = "第二十一周";
                            break;
                        }
                    case 22:
                        {
                            currentWeek = "第二十二周";
                            break;
                        }
                    default:
                        {
                            currentWeek = "";
                            break;
                        }
                }
            }

            return currentWeek;
        }

        // 获取当前星期
        public static string getCurrentWeekday()
        {
            string currentWeekday = "";       // 当前星期

            DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    {
                        currentWeekday = "星期一";
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        currentWeekday = "星期二";
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        currentWeekday = "星期三";
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        currentWeekday = "星期四";
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        currentWeekday = "星期五";
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        currentWeekday = "星期六";
                        break;
                    }
                case DayOfWeek.Sunday:
                    {
                        currentWeekday = "星期日";
                        break;
                    }
                default:
                    {
                        currentWeekday = "";
                        break;
                    }
            }

            return currentWeekday;
        }

        // 获取当前节次
        public static string getCurrentSchoolTime()
        {
            string currentSchoolTime = "";    // 当前节次

            int currentMonth = DateTime.Now.Month;  // 当前月份
            //作息时间

            if (currentMonth >= 1 && currentMonth <= 12 )
            {
                if (DateTime.Now >= Convert.ToDateTime("08:00") && DateTime.Now <= Convert.ToDateTime("09:35"))
                {
                    currentSchoolTime = "1-2节";
                }
                else if (DateTime.Now > Convert.ToDateTime("09:50") && DateTime.Now <= Convert.ToDateTime("11:25"))
                {
                    currentSchoolTime = "3-4节";
                }
                else if (DateTime.Now >= Convert.ToDateTime("11:30") && DateTime.Now <= Convert.ToDateTime("12:15"))
                {
                    currentSchoolTime = "5节";
                }
                else if (DateTime.Now > Convert.ToDateTime("14:30") && DateTime.Now <= Convert.ToDateTime("16:05"))
                {
                    currentSchoolTime = "6-7节";
                }
                else if (DateTime.Now >= Convert.ToDateTime("16:20") && DateTime.Now <= Convert.ToDateTime("17:55"))
                {
                    currentSchoolTime = "8-9节";
                }
                else if (DateTime.Now >= Convert.ToDateTime("19:00") && DateTime.Now <= Convert.ToDateTime("21:25"))
                {
                    currentSchoolTime = "9-12节";
                }
            } 
            return currentSchoolTime;
        }

        // 获取当前上课开始时间
        public static DateTime getCurrentClassTime()
        {
            DateTime currentClassTime = Convert.ToDateTime("00:00"); // 当前上课开始时间

            int currentMonth = DateTime.Now.Month;  // 当前月份

            // 作息时间
            if (currentMonth >= 1 && currentMonth <= 12)
            {
                if (DateTime.Now >= Convert.ToDateTime("08:00") && DateTime.Now <= Convert.ToDateTime("08:10"))
                {
                    currentClassTime = Convert.ToDateTime("08:00");
                }
                else if (DateTime.Now >= Convert.ToDateTime("09:50") && DateTime.Now <= Convert.ToDateTime("10:15"))
                {
                    currentClassTime = Convert.ToDateTime("09:50");
                }
                else if (DateTime.Now >= Convert.ToDateTime("14:00") && DateTime.Now <= Convert.ToDateTime("14:10"))
                {
                    currentClassTime = Convert.ToDateTime("14:00");
                }
                else if (DateTime.Now >= Convert.ToDateTime("15:50") && DateTime.Now <= Convert.ToDateTime("16:10"))
                {
                    currentClassTime = Convert.ToDateTime("16:05");
                }
                else if (DateTime.Now >= Convert.ToDateTime("16:20") && DateTime.Now <= Convert.ToDateTime("16:30"))
                {
                    currentClassTime = Convert.ToDateTime("16:20");
                }
                else if (DateTime.Now >= Convert.ToDateTime("19:00") && DateTime.Now <= Convert.ToDateTime("19:10"))
                {
                    currentClassTime = Convert.ToDateTime("19:00");
                }
                else
                {
                    currentClassTime = Convert.ToDateTime("00:00");
                }
            }
            return currentClassTime;
        } 

        // 获取当前课程名称
        public static string getCurrentCourseName()
        {
            string currentCourseName = "";    // 当前课程名称

            // 查询记录用的SQL语句
            string selectSql = String.Format("select CourseName from CourseSchedules cs, Courses c " +
                "where cs.CourseId = c.CourseId and cs.TeacherId = '{0}' and SchoolYear = '{1}' and Semester = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' " +
                "and dbo.getNumWeek('{5}') >= dbo.getNumWeek(StartWeek) and dbo.getNumWeek('{6}') <= dbo.getNumWeek(EndWeek)",
                CommonInfo.userId,
                getCurrentSchoolYear(),
                getCurrentSemester(),
                getCurrentWeekday(),
                getCurrentSchoolTime(),
                getCurrentWeek(),
                getCurrentWeek());

            // 执行查询操作
            currentCourseName = (string)DBHelper.executeScalar(selectSql);

            return currentCourseName;
        }

        // 获取当前课程编号
        public static string getCurrentCourseId(string ClassId)
        {
            string currentCourseId = "";    // 当前课程编号

            // 查询记录用的SQL语句
            string selectSql = String.Format("select CourseId from CourseSchedules " +
                "where SchoolYear = '{0}' and Semester = '{1}' and Weekday = '{2}' and SchoolTime = '{3}' " +
                "and dbo.getNumWeek('{4}') >= dbo.getNumWeek(StartWeek) and dbo.getNumWeek('{5}') <= dbo.getNumWeek(EndWeek) " +
                "and ClassId = '{6}'",
                getCurrentSchoolYear(),
                getCurrentSemester(),
                getCurrentWeekday(),
                getCurrentSchoolTime(),
                getCurrentWeek(),
                getCurrentWeek(),
                ClassId);

            // 执行查询操作
            currentCourseId = (string)DBHelper.executeScalar(selectSql);

            return currentCourseId;
        }

        // 获取当前学生当天所有上课节次
        public static void getCurrentAllSchoolTimeOfStudent(string StuId)
        {
            try
            {
                // 清空数组列表
                arraySchoolTimeOfStudent.Clear();
                
                // 查询记录用的SQL语句
                string selectSql = String.Format("select SchoolTime from CourseSchedules cs, Students s " +
                    "where cs.ClassId = s.ClassId  and SchoolYear = '{0}' and Semester = '{1}' and Weekday = '{2}' " +
                    "and dbo.getNumWeek('{3}') >= dbo.getNumWeek(StartWeek) and dbo.getNumWeek('{4}') <= dbo.getNumWeek(EndWeek) " +
                    "and s.StuId = '{5}'",
                    getCurrentSchoolYear(),
                    getCurrentSemester(),
                    getCurrentWeekday(),
                    getCurrentWeek(),
                    getCurrentWeek(),
                    StuId);

                SqlCommand command = new SqlCommand(selectSql, DBHelper.connection);

                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    string SchoolTime = sdr["SchoolTime"].ToString();

                    // 将从 CourseSchedules 表中取出来的上课节次存储到数组列表中
                    arraySchoolTimeOfStudent.Add(SchoolTime);
                }

                if (sdr.IsClosed == false)
                {
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DBHelper.connection.State != ConnectionState.Closed)
                {
                    DBHelper.connection.Close();
                }
            }
        }

        // 获取当前教师当天所有上课节次、课程编号和班级编号
        public static void getCurrentAllSchoolTimeOfTeacher(string TeacherId)
        {
            try
            {
                // 清空数组列表
                arraySchoolTimeOfTeacher.Clear();

                // 查询记录用的SQL语句
                string selectSql = String.Format("select SchoolTime, CourseId, ClassId from CourseSchedules " +
                    "where SchoolYear = '{0}' and Semester = '{1}' and Weekday = '{2}' " +
                    "and dbo.getNumWeek('{3}') >= dbo.getNumWeek(StartWeek) and dbo.getNumWeek('{4}') <= dbo.getNumWeek(EndWeek) " +
                    "and TeacherId = '{5}'",
                    getCurrentSchoolYear(),
                    getCurrentSemester(),
                    getCurrentWeekday(),
                    getCurrentWeek(),
                    getCurrentWeek(),
                    TeacherId);

                SqlCommand command = new SqlCommand(selectSql, DBHelper.connection);

                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    string SchoolTime = sdr["SchoolTime"].ToString();
                    string CourseId = sdr["CourseId"].ToString();
                    string ClassId = sdr["ClassId"].ToString();

                    // 将从 CourseSchedules 表中取出来的上课节次、课程编号和班级编号存储到数组列表中
                    arraySchoolTimeOfTeacher.Add(SchoolTime + "@" + CourseId + "@" + ClassId);
                }

                if (sdr.IsClosed == false)
                {
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DBHelper.connection.State != ConnectionState.Closed)
                {
                    DBHelper.connection.Close();
                }
            }
        }

        // 遍历存储当前学生当天所有上课节次的数组列表
        // 判断是否能签到
        public static bool CanCheckIn()
        {
            bool result = false;  // 不允许学生签到

            // 首先：遍历数组列表，根据当前时间获取当前上课节次，如果能在数组列表中找到，则说明目前有课，否则，说明目前没有课。
            for (int i = 0; i <= arraySchoolTimeOfStudent.Count - 1; i++)
            {
                string currentSchoolTime = getCurrentSchoolTime();           // 根据当前时间获取当前上课节次

                string SchoolTime = arraySchoolTimeOfStudent[i].ToString();  // 根据数组下标取出数组列表中的上课节次

                // 如果相等，则说明目前有课。
                if (currentSchoolTime.Equals(SchoolTime) == true)            // 比较当前上课节次和数组列表中的上课节次
                {
                    // 然后：在有课的情况下，比较当前时间和当前上课的开始时间，如果当前时间小于等于当前上课的开始时间，则允许学生签到。
                    DateTime currentClassTime = getCurrentClassTime();

                    if (DateTime.Now <= currentClassTime)
                    {
                        result = true;  // 允许学生签到
                    }
                }
            }

            return result;
        }

        // 获取当前登录学生所在的班级编号
        private static string getCurrentClassIdOfStudent(string StuId)
        {
            string currentClassId = "";    // 当前班级编号

            // 查询记录用的SQL语句
            string selectSql = String.Format("select ClassId from Students where StuId = '{0}'", StuId);

            // 执行查询操作
            currentClassId = (string)DBHelper.executeScalar(selectSql);

            return currentClassId;
        }


        // 遍历存储当前教师当天所有上课节次、课程编号和班级编号的数组列表
        // 判断是否能点名
        public static bool CanTakeAttendance()
        {
            bool result = false;// 不允许教师点名

            // 首先：遍历数组列表，根据当前时间获取当前上课节次，如果能在数组列表中找到，则说明目前有课，否则，说明目前没有课。
            for (int i = 0; i <= arraySchoolTimeOfTeacher.Count - 1; i++)
            {
                string currentSchoolTime = getCurrentSchoolTime();           // 根据当前时间获取当前上课节次

                string[] strArray = arraySchoolTimeOfTeacher[i].ToString().Split('@');

                string SchoolTime = strArray[0];                             // 取出数组列表中的上课节次

                // 如果相等，则说明目前有课。
                if (currentSchoolTime.Equals(SchoolTime) == true)            // 比较当前上课节次和数组列表中的上课节次
                {
                    // 然后：在有课的情况下，比较当前时间和当前上课的开始时间，如果当前时间大于等于当前上课的开始时间，则允许教师点名。
                    DateTime currentClassTime = getCurrentClassTime();

                    if (DateTime.Now >currentClassTime)
                    {
                        result = true;  // 允许教师点名
                    }
                }
            }

            return result;
        }

        // 当教师单击“点名”按钮后，录入当前上课班级所有学生的迟到信息。
        public static void insertAllStudentAttendancesInfo(string StatusId, string Memo)
        {
            ArrayList studentList = new ArrayList();  // 用来存储当前上课班级所有学生的学号

            string CourseId = "";                     // 表示当前上课的课程编号
            
            // 首先：获取该班所有学生的学号，并存储在一个数组列表中。
            // 思路：遍历数组列表，根据当前时间获取当前上课节次，如果能在数组列表中找到，则获取当前上课班级所有学生的学号，并终止循环。
            for (int i = 0; i <= arraySchoolTimeOfTeacher.Count - 1; i++)
            {
                string currentSchoolTime = getCurrentSchoolTime();           // 根据当前时间获取当前上课节次

                string[] strArray = arraySchoolTimeOfTeacher[i].ToString().Split('@');

                string SchoolTime = strArray[0];                             // 取出数组列表中的上课节次

                // 如果相等，则说明目前有课。
                if (currentSchoolTime.Equals(SchoolTime) == true)            // 比较当前上课节次和数组列表中的上课节次
                {
                    CourseId = strArray[1];                                  // 取出课程编号  
                    
                    string ClassId = strArray[2];                            // 取出班级编号

                    // 获取当前上课班级所有学生的学号，并存储在数组列表 studentList 中。
                    try
                    {
                        // 查询记录用的SQL语句
                        string selectSql1 = String.Format("select StuId from Students where ClassId = '{0}' order by StuId", ClassId);

                        SqlCommand command = new SqlCommand(selectSql1, DBHelper.connection);

                        if (DBHelper.connection.State == ConnectionState.Closed)
                        {
                            DBHelper.connection.Open();
                        }

                        SqlDataReader sdr = command.ExecuteReader();

                        while (sdr.Read())
                        {
                            string StuId = sdr["StuId"].ToString();

                            // 将从 Students 表中取出来的学号存储到数组列表中
                            studentList.Add(StuId);
                        }

                        if (sdr.IsClosed == false)
                        {
                            sdr.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (DBHelper.connection.State != ConnectionState.Closed)
                        {
                            DBHelper.connection.Close();
                        }
                    }
                }
            }
            
            // 然后：遍历数组列表 studentList， 取出当前上课班级所有学生的学号， 录入迟到信息。
            // 思路：检查后台数据库的 StudentAttendances 表中是否存在该生的出勤记录，如果不存在，则录入迟到信息。
            for (int i = 0; i <= studentList.Count - 1; i++)
            {
                string StuId = studentList[i].ToString();

                string selectSql2 = String.Format("select count(*) from StudentAttendances " + 
                    "where SchoolYear = '{0}' and Semester = '{1}' and Week = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' and StuId = '{5}'",
                    getCurrentSchoolYear(),
                    getCurrentSemester(),
                    getCurrentWeek(),
                    getCurrentWeekday(),
                    getCurrentSchoolTime(),
                    StuId);

                //执行查询操作
                int result = (int)DBHelper.executeScalar(selectSql2);

                //如果出勤记录已存在，则不能再录入迟到信息，继续循环，继续判断下是否需要录入下一个学生的迟到信息。
                if (result >= 1){
                    continue;
                }

                //添加记录用的SQL语句
                string insertSql = String.Format("insert into StudentAttendances (StuId, CourseId, SchoolYear, Semester, Week, Weekday, SchoolTime, StatusId, Memo) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}') ",
                    StuId,
                    CourseId,
                    getCurrentSchoolYear(),
                    getCurrentSemester(),
                    getCurrentWeek(),
                    getCurrentWeekday(),
                    getCurrentSchoolTime(),
                    StatusId,
                    Memo);

                //执行添加操作
                int insertResult = DBHelper.executeInsertSql(insertSql);
            }

           
        }

        // 当教师登录系统后，获取当前上课班级所有学生的学号、姓名。
        public static ArrayList getCurrentAllStudentInfoByTeacher(string TeacherId)
        {
            // 定义一个数组列表，用来存放当前上课班级所有学生的学号、姓名。
            ArrayList studentList = new ArrayList();

            try
            {
                // 查询记录用的SQL语句
                string selectSql = String.Format("select StuId, StuName from CourseSchedules cs, Students s " +
                    "where cs.ClassId = s.ClassId and SchoolYear = '{0}' and Semester = '{1}' and Weekday = '{2}' and SchoolTime = '{3}'" +
                    "and dbo.getNumWeek('{4}') >= dbo.getNumWeek(StartWeek) and dbo.getNumWeek('{5}') <= dbo.getNumWeek(EndWeek) " +
                    "and TeacherId = '{6}' " +
                    "order by s.StuId asc",
                    getCurrentSchoolYear(),
                    getCurrentSemester(),
                    getCurrentWeekday(),
                    getCurrentSchoolTime(),
                    getCurrentWeek(),
                    getCurrentWeek(),
                    TeacherId);

                SqlCommand command = new SqlCommand(selectSql, DBHelper.connection);

                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }

                SqlDataReader sdr = command.ExecuteReader();

                while (sdr.Read())
                {
                    string StuId = sdr["StuId"].ToString();
                    string StuName = sdr["StuName"].ToString();

                    // 将取出来的学号和学生姓名存储到数组列表中
                    studentList.Add(StuId + "@" + StuName);
                }

                if (sdr.IsClosed == false)
                {
                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DBHelper.connection.State != ConnectionState.Closed)
                {
                    DBHelper.connection.Close();
                }
            }

            return studentList;
        }

        // 获取当前时间某个学生的出勤状态
        public static string getCurrentAttendanceStatus(string StuId)
        {
            string StatusName = "";
            
            //查询记录用的SQL语句
            string selectSql = String.Format("select StatusName from StudentAttendances sa, AttendanceStatus attend " +
                "where sa.StatusId = attend.StatusId and SchoolYear = '{0}' and Semester = '{1}' " + 
                "and Week = '{2}' and Weekday = '{3}' and SchoolTime = '{4}' and StuId = '{5}'",
                getCurrentSchoolYear(),
                getCurrentSemester(),
                getCurrentWeek(),
                getCurrentWeekday(),
                getCurrentSchoolTime(),
                StuId);

            //执行查询操作
            StatusName = (string)DBHelper.executeScalar(selectSql);

            return StatusName;
        }
    }
}