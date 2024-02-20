using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Client : Person
    {
        private static int clientIDctr = 0;
        public int ClientID { get; private set; }
        public bool IsStudent { get; set; }
        public int StudentID { get; private set; }
        public string EmailAddress { get; private set; }
        public List<Request> Requests { get; set; }

        public Client(string name, string contactNumber) : base(name, contactNumber) 
        {
            this.ClientID = System.Threading.Interlocked.Increment(ref clientIDctr);
            this.Requests = new List<Request>();
        }

        public void setEmailAddress(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        public void setStudentID(int StudentID)
        {
            this.StudentID = StudentID;
        }

        public void addRequestAppointment(Personnel personnel, string purpose, DateTime date)
        {
            if(personnel.setPersonnelStatus(PersonnelStatus.DnD) || personnel.setPersonnelStatus(PersonnelStatus.OnLeave))
            {
                return;
            }

            foreach(WorkSchedule r in personnel.WorkSchedule)
            {
                if(date.Equals(r.Schedule))
                {
                    return;
                }
            }
            this.Requests.Add(new Request(personnel, purpose, date));
            personnel.Clients.Add(this);
        }
    }
}
