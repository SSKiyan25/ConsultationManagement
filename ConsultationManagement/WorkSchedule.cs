using System;

namespace ConsultationManagement
{
    public class WorkSchedule
    {
        private static int workSchedIdCounter = 0;
        public int WorkSchedID { get; private set; }
        public string Title { get; private set; }
        public DateTime StartTime;
        public DateTime EndTime;
        public Frequency Frequency { get; private set; }

        public WorkSchedule(int workSchedID, string title, DateTime start, DateTime end, Frequency frequency)
        {
            this.WorkSchedID = System.Threading.Interlocked.Increment(ref workSchedIdCounter);
            this.Title = title;
            this.StartTime = start;
            this.EndTime = end;
            this.Frequency = frequency;
        }
    }
}
