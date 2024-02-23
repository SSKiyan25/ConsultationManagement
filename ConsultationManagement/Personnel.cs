using System.Collections.Generic;

namespace ConsultationManagement
{
    public class Personnel : Person
    {
        public static int personnelIDctr = 0;
        public int PersonnelID { get; set; }
        public List<Client> Clients { get; set; }
        public Classification Classification { get; set; }
        public PersonnelStatus Status { get; set; }
        public Account Account { get; set; }
        public List<WorkSchedule> WorkSchedule { get; set; }

        public Personnel(string Name, string ContactNumber) : base(Name, ContactNumber)
        {
            this.PersonnelID = System.Threading.Interlocked.Increment(ref personnelIDctr);
            this.Clients = new List<Client>();
        }

        public void SetAppointmentRequest(Client client, RequestStatus status)
        {
            if (!Clients.Contains(client)) { return; }

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

        public void AddWorkSchedule(WorkSchedule sched)
        {
            this.WorkSchedule.Add(sched);
        }

        public void RemoveWorkSchedule(WorkSchedule sched)
        {
            this.WorkSchedule.Remove(sched);
        }
    }
}
