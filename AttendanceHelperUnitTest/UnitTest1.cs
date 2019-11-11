using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentAttendanceMgr.StudentAttendance;
namespace AttendanceHelperUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string YearResult = "2019年";
            string res1 = AttendanceHelper.getCurrentSchoolYear();
            Assert.AreEqual(YearResult, res1);
            string WeekDayRsult = "星期日";
            string res2 = AttendanceHelper.getCurrentWeekday();
            Assert.AreEqual(WeekDayRsult,res2);
        }
    }
}
