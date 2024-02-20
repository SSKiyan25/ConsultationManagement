using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class WorkSchedule
    {
        private static int workSchedIdCounter = 0;
        public int WorkSchedID { get; private set; }
        public string Title { get; private set; }
        public DateTime Schedule;
        public Frequency Frequency { get; private set; }

        public WorkSchedule(int workSchedID, string title, DateTime schedule, Frequency frequency)
        {
            this.WorkSchedID = System.Threading.Interlocked.Increment(ref workSchedIdCounter);
            this.Title = title;
            this.Schedule = schedule;
            this.Frequency = frequency;
        }
    }
}
