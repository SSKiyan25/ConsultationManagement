using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Request
    {
        public static int requestIDctr = 0;
        public int RequestID { get; private set; }
        public string Purpose { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime RequestedTimeStart { get; set; }
        public DateTime RequestedTimeEnd { get; set; }
        public bool IsArchived { get; set; }
        public Personnel Personnel { get; private set; }
        public RequestStatus Status { get; set; }

        public Request(Personnel personnel, string purpose, DateTime start, DateTime end)
        {
            this.RequestID = System.Threading.Interlocked.Increment(ref requestIDctr);
            this.Personnel = personnel;
            this.Purpose = purpose;
            this.DateRequested = DateTime.Now;
            this.RequestedTimeStart = start;
            this.RequestedTimeEnd = end;
            this.IsArchived = false;
            this.Status = RequestStatus.Pending;
            this.DateRequested = DateTime.Now;
        }
    }
}
