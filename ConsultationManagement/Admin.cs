using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Admin
    {
        private HashSet<Personnel> personnels;
        public Account Account { get; private set; }
        public Admin(string email, string password)
        {
            this.Account = new Account(email, password, true);    
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
