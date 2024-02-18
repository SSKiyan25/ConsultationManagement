using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class WorkSchedule
    {
        public int WorkSchedID { get; set; }
        public string Title { get; set; }
        public DateTime Schedule;
        public Frequency Frequency { get; set; }

        public WorkSchedule(int workSchedID, string title, DateTime schedule, Frequency frequency)
        {
            this.WorkSchedID = workSchedID;
            this.Title = title;
            this.Schedule = schedule;
            this.Frequency = frequency;
        }
    }
}
