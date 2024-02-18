using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Account
    {
        protected string emailAddress { get; private set; }
        protected string password { get; private set; }
        protected bool isAdmin { get; private set; }
        protected DateTime dateCreated { get; private set; }
        protected bool isArchived { get; private set; }

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
