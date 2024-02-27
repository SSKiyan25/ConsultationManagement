using System;
using System.Collections.Generic;

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

        public bool AddRequestAppointment(Personnel personnel, string purpose, DateTime start, DateTime end)
        {
            if (personnel.Status == PersonnelStatus.DnD || personnel.Status == PersonnelStatus.OnLeave)
            {
                return false;
            }

            foreach (WorkSchedule r in personnel.WorkSchedule)
            {
                if ((end > r.StartTime && end < r.EndTime) || (start > r.StartTime && start < r.EndTime))
                {
                    return false;
                }
            }

            this.Requests.Add(new Request(personnel, purpose, start, end));
            personnel.Clients.Add(this, this.ClientID);
            return true;
        }
    }
}
