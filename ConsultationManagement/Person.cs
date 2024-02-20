using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string ContactNum { get; set; }

        public Person(string name, string contactNum)
        {
            this.Name = name;
            this.ContactNum = contactNum;
        }
    }
}
