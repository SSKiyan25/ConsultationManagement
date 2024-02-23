using System;
using System.Collections.Generic;

namespace ConsultationManagement
{
    public class Personnel : Person
    {
        public static int personnelIDctr = 0;
        public int PersonnelID { get; set; }
        public Dictionary<Client, int> Clients { get; set; }
        public Classification Classification { get; set; }
        public PersonnelStatus Status { get; set; }
        public Account Account { get; set; }
        public HashSet<WorkSchedule> WorkSchedule { get; set; }

        public Personnel(string Name, string ContactNumber) : base(Name, ContactNumber)
        {
            this.PersonnelID = System.Threading.Interlocked.Increment(ref personnelIDctr);
            this.Clients = new Dictionary<Client, int>();
        }

        public void SetAppointmentRequest(Client client, RequestStatus status)
        {
            if (!Clients.Contains(Clients)) { return false; }

            foreach (Request r in client.Requests)
            {
                if (r.Personnel.Equals(this))
                {
                    r.Status = status;
                    if (Clients.Remove(client))
                        break;
                }
            }
        }

        public void SetPersonnelStatus(PersonnelStatus status)
        {
            this.Status = status;
        }

        public bool AddWorkSchedule(WorkSchedule sched)
        {
            foreach (WorkSchedule r in this.WorkSchedule)
            {
                if ((sched.EndTime > r.StartTime && sched.EndTime < r.EndTime) || (sched.StartTime > r.StartTime && sched.StartTime < r.EndTime))
                {
                    return false;
                }
            }
            this.WorkSchedule.Add(sched);
            return true;
        }

        public bool RemoveWorkSchedule(WorkSchedule sched)
        {
            return this.WorkSchedule.Remove(sched);
        }
    }
}
