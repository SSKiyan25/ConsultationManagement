using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    internal class Person
    {
        public string name { get; set; }
        public string contactNum { get; set; }

        public Person(string name, string contactNum)
        {
            this.name = name;
            this.contactNum = contactNum;
        }
    }
}
