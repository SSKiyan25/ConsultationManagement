using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsultationManagement.UnitTests
{
    [TestClass]
    public class WorkScheduleTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            string title = "Class 1";
            DateTime start = new DateTime(2024, 02, 28, 08, 00, 00);
            DateTime end = start.AddHours(8);
            Frequency frequency = Frequency.Once;

            var workSchedule = new WorkSchedule(title, start, end, frequency);

            Assert.AreEqual(workSchedule.Title, title);
            Assert.AreEqual(workSchedule.StartTime, start);
            Assert.AreEqual(workSchedule.EndTime, end);
            Assert.AreEqual(workSchedule.Frequency, frequency);
        }
    }
}
