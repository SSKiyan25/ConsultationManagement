using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Account
    {
        private string emailAddress { get; set; }
        private string password { get; set; }
        private bool isAdmin { get; set; }
        private DateTime dateCreated { get; set; }
        private bool isArchived { get; set; }

        public Account(string emailAddress, string password, bool isAdmin)
        {
            this.emailAddress = emailAddress;
            this.password = password;
            this.isAdmin = isAdmin;
            this.dateCreated = DateTime.Now;
        }

        public bool Authenticate(string email, string pw)
        {
            return (this.emailAddress == email && this.password == pw && !isArchived);
        }

        public void DeleteAccount()
        {
            this.isArchived = true;
        }
    }
}
