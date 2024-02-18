using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public abstract class Account
    {
        protected string EmailAddress { get; private set; }
        protected string Password { get; private set; }
        protected bool IsAdmin { get; private set; }
        protected DateTime DateCreated { get; private set; }
        protected bool IsArchived { get; private set; }

        public Account(string emailAddress, string password, bool isAdmin)
        {
            this.EmailAddress = emailAddress;
            this.Password = password;
            this.IsAdmin = isAdmin;
            this.DateCreated = DateTime.Now;
        }

        public bool Authenticate(string email, string pw)
        {
            return (this.EmailAddress == email && this.Password == pw && !IsArchived);
        }

        public void DeleteAccount()
        {
            this.IsArchived = true;
        }
    }
}
