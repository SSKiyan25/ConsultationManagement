using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Admin : Account
    {
        private static int adminIdCounter = 0;
        public int AdminId { get; private set; }
        private HashSet<Personnel> personnels;
        public Account Account { get; private set; }
        public Admin(string email, string password) : base(email, password, true)
        {
            this.AdminId = System.Threading.Interlocked.Increment(ref adminIdCounter);
            this.personnels = new HashSet<Personnel>();
        }
        public void AddPersonnel(Personnel personnel)
        {
            this.personnels.Add(personnel);
        }
        public void RemovePersonnel(Personnel personnel)
        {
            this.personnels.Remove(personnel);
        }
        public void ViewPersonnelRequest(Personnel personnel)
        {

        }
        public void DeleteRequest(Request request)
        {

        }
    }
}
