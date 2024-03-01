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
