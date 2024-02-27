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
        protected int RequestID { get; private set; }
        public string Purpose { get; set; }
        public DateTime DateRequested { get; set; }
        protected bool IsArchived { get; set; }
        public Personnel Personnel { get; private set; }
        public RequestStatus Status { get; set; }
        public Request(Personnel personnel, string purpose, DateTime date)
        {
            this.RequestID = System.Threading.Interlocked.Increment(ref requestIDctr);
            this.Personnel = personnel;
            this.Purpose = purpose;
            this.DateRequested = date;
            this.IsArchived = false;
            this.Status = RequestStatus.Pending;
            this.DateRequested = DateTime.Now;
        }
    }
}
