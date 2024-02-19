using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Account
    {
        private string emailAddress;
        private string password;
        private bool isAdmin;
        private DateTime dateCreated;
        private bool isArchived;

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

        public void SetEmailAddress(string emailAdd)
        {
            this.emailAddress = emailAdd;
        }
        public string GetEmailAddress()
        {
            return this.emailAddress;
        }
        public void SetPassword(string pw)
        {
            this.password = pw;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public void SetAdminStatus(bool status)
        {
            this.isAdmin = status;
        }
        public bool GetAdminStatus()
        {
            return this.isAdmin;
        }
        public DateTime GetDateCreated()
        {
            return this.dateCreated;
        }
        public void RestoreAccount()
        {
            this.isArchived = false;
        }
        public void DeleteAccount()
        {
            this.isArchived = true;
        }
    }
}
