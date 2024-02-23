﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public class Admin
    {
        private static int adminIdCounter = 0;
        public int AdminId { get; set; }
        private HashSet<Personnel> personnels;
        public Account Account { get; set; }
        public Admin(string email, string password)
        {
            this.AdminId = System.Threading.Interlocked.Increment(ref adminIdCounter);
            this.personnels = new HashSet<Personnel>();
            this.Account = new Account(email, password, true);
        }
        public bool AddPersonnel(Personnel personnel)
        {
            return this.personnels.Add(personnel);
        }
        public bool RemovePersonnel(Personnel personnel)
        {
            return this.personnels.Remove(personnel);
        }
        public void ViewPersonnelRequest(Personnel personnel)
        {
            /*
            access requestDB
            iterate all requests with personnel properties
            display all these requests
            */
        }
        public bool DeleteRequest(Request request)
        {
            request.IsArchived = true;
            return request.IsArchived;
        }
    }
}
