using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    internal class Request
    {
        public enum RequestStatus { Pending, Ongoing, Done, Denied}
        protected int requestID { get; set; }
        public string purpose { get; set; }
        public DateTime dateRequested { get; set; }
        protected bool isArchived { get; set; }
        public Personnel personnel { get; set; }
        public RequestStatus status { get; set; }


        public Request(Personnel personnel, string purpose, DateTime date)
        {
            this.personnel = personnel;
            this.purpose = purpose;
            this.dateRequested = date;
            this.isArchived = false;
            this.status = RequestStatus.Pending;
            this.dateRequested = DateTime.Now;
        }
    }
}
