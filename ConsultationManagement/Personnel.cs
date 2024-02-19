using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Personnel : Person
    {
        private static int personnelIDctr = 0;
        public int personnelID { get; set; }
        public List<Client> clients { get; set; }
        public Classification classification { get; set; }
        public PersonnelStatus status { get; set; }
        public Account account { get; set; }
        public WorkSchedule workSchedule { get; set; }
        
        public Personnel(string Name, string ContactNumber) : base(Name,ContactNumber) 
        {
            this.personnelID = System.Threading.Interlocked.Increment(ref personnelIDctr);
            this.clients = new List<Client>();
        }

        public void setAppointmentRequest(Client client)
        {
                        
        }

        public void setPersonnelStatus(PersonnelStatus status) 
        {
            this.status = status;
        }

        public void addWorkSchedule(WorkSchedule sched)
        {

        }

        public void removeWorkSchedule(WorkSchedule sched)
        {

        }
    }
}
