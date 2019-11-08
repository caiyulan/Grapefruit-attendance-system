using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAttendanceMgr.CommonClass
{
    //公共信息类，用来存储全局变量。
    public class CommonInfo
    {
        public static string userId;           //当前登录用户的账号

        public static string userType;         //当前登录用户的类型： 学生； 教师； 系统管理员

        public static string connString = "";  //数据库连接字符串
    }
}
