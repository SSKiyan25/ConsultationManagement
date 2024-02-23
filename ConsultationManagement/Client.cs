using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Client : Person
    {
        public static int clientIDctr = 0;
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

        public void SetEmailAddress(string emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        public void SetStudentID(int StudentID)
        {
            this.StudentID = StudentID;
        }

        public void AddRequestAppointment(Personnel personnel, string purpose, DateTime start, DateTime end)
        {
            if(personnel.Status == PersonnelStatus.DnD || personnel.Status == PersonnelStatus.OnLeave)
            {
                return;
            }

            foreach(WorkSchedule r in personnel.WorkSchedule)
            {
                if()
                {
                    return;
                }
            }

            this.Requests.Add(new Request(personnel, purpose));
            personnel.Clients.Add(this);
        }
    }
}
