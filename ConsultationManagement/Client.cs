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
        public int clientID { get; private set; }
        public bool isStudent { get; set; }
        public int studentID { get; private set; }
        public string emailAddress { get; private set; }
        public List<Request> requests { get; set; }

        public Client(string name, string contactNumber) : base(name, contactNumber) 
        {
            this.clientID = System.Threading.Interlocked.Increment(ref clientIDctr);
            this.requests = new List<Request>();
        }

        public void setEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }

        public void setStudentID(int StudentID)
        {
            this.studentID = StudentID;
        }

        public void addRequestAppointment(Personnel personnel, string purpose, DateTime date)
        {
            this.requests.Add(new Request(personnel, purpose, date));
            personnel.clients.Add(this);
        }
    }
}
