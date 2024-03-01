using ConsultationManagement;

namespace ConsultationManagementTest
{
    public class WorkScheduleTest
    {
        [Fact]
        public void WorkSchedTest_Creation()
        {
            var workSched1 = new WorkSchedule( "Event Driven Programming", new DateTime(2024, 02, 26, 08, 00, 00), new DateTime(2024, 02, 26, 12, 00, 00), Frequency.Once);
            var workSched2 = new WorkSchedule( "Fundamentals of Programming", new DateTime(2024, 02, 26, 13, 00, 00), new DateTime(2024, 02, 26, 16, 00,00), Frequency.Once);
            var workSched3 = new WorkSchedule( "Fundamentals of Programming", new DateTime(2024, 02, 26, 13, 00, 00), new DateTime(2024, 02, 26, 16, 00, 00), Frequency.Once);
            var workSched4 = new WorkSchedule( "Event Driven Programming", new DateTime(2024, 02, 26, 08, 00, 00), new DateTime(2024, 02, 26, 12, 00, 00), Frequency.Weekly);

            var schedID1 = workSched1.WorkSchedID;
            var schedID2 = workSched2.WorkSchedID;
            var schedID3 = workSched3.WorkSchedID;

            var start1 = workSched1.StartTime;
            var start2 = workSched2.StartTime;
            var start3 = workSched3.StartTime;

            var end1 = workSched1.EndTime;
            var end2 = workSched2.EndTime;
            var end3 = workSched3.EndTime;

            Assert.NotEqual(schedID1, schedID2);
            Assert.NotEqual(schedID2, schedID3 );
            //WorkschedID parameter useless, to be updated.

            Assert.IsType<DateTime>(start1);
            Assert.IsType<DateTime>(start2);
            Assert.IsType<DateTime>(start3);
            Assert.IsType<DateTime>(end1);
            Assert.IsType<DateTime>(end2);
            Assert.IsType<DateTime>(end3);

            Assert.True(start1 < start2);
            Assert.True(start2 == start3);
            Assert.False(start1 == start3);
            Assert.False(start2 < start3);

            Assert.True(end1 < end2);
            Assert.True(end2 == end3);
            Assert.False(end1 == end3);
            Assert.False(end2 < end3);

            Assert.NotSame(workSched2, workSched3);
            Assert.NotSame(workSched1, workSched4);

        }

    }
}