using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class RequestData
    {
        public int RequestID { get; set; }
        public Personnel personnel { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime RequestedTimeStart { get; set; }
        public DateTime RequestedTimeEnd { get; set; }
        public RequestStatus Status { get; set; }
    }
}
