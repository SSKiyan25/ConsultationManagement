using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Request
    {
        private static int requestIDctr = 0;
        protected int requestID { get; private set; }
        public string purpose { get; set; }
        public DateTime dateRequested { get; set; }
        protected bool isArchived { get; set; }
        public Personnel personnel { get; private set; }
        public RequestStatus status { get; set; }


        public Request(Personnel personnel, string purpose, DateTime     date)
        {
            this.requestID = System.Threading.Interlocked.Increment(ref requestIDctr);
            this.personnel = personnel;
            this.purpose = purpose;
            this.dateRequested = date;
            this.isArchived = false;
            this.status = RequestStatus.Pending;
            this.dateRequested = DateTime.Now;
        }
    }
}
