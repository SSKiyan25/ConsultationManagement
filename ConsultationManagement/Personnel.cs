using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{

    internal class Personnel : Person
    {
        public enum Classification { Faculty, Staff }
        public enum PersonnelStatus { DnD, OnLeave, Available }
        public int personnelID { get; set; }
        public List<Client> clients { get; set; }
        public Classification classification { get; set; }
        public PersonnelStatus status { get; set; }
        //public Account account { get; set; }
        
        public Personnel(string Name, string ContactNumber) : base(Name,ContactNumber) 
        {
            this.clients = new List<Client>();
        }

        public void setAppointmentRequest(Client client)
        {

            foreach(Request r in client.requests)
            {
                
                if(r.personnel.Equals(this) && r.status.Equals(Request.RequestStatus.Pending))
                {
                    Console.WriteLine("Set request status: \n[1] Ongoing\n[2] Done\n[3] Denied");
                    int opt = Convert.ToInt32(Console.ReadLine());
                    if (opt == 1)
                    {
                        r.status = Request.RequestStatus.Ongoing;
                    }
                    else if (opt == 2)
                    {
                        r.status = Request.RequestStatus.Done;
                    }
                    else if (opt == 3)
                    {
                        r.status = Request.RequestStatus.Denied;
                    }
                }
            }
        }

        public void setPersonnelStatus(PersonnelStatus status) 
        {
            this.status = status;
        }
    }
}
