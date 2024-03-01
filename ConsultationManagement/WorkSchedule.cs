using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WorkschedID parameter useless, to be updated.
//dili bata mag need anig unsa nga day like monday, tuesday, etc.?

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
