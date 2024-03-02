using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace ConsultationManagement.UnitTests
{
    [TestClass]
    public class PersonnelTests
    {
        private Personnel personnel;
        private Client client;
        private WorkSchedule sched;

        [TestInitialize]
        public void TestInitialize()
        {
            personnel = new Personnel("Jonhei", "09876543210", PersonnelStatus.Available);
            client = new Client("Juan", "09123456789");
            sched = new WorkSchedule("Class 1", new DateTime(2024, 02, 28, 08, 00, 00), new DateTime(2024, 02, 28, 10, 00, 00), Frequency.Once);

            var sched1 = new WorkSchedule("Class 2", new DateTime(2024, 02, 28, 13, 00, 00), new DateTime(2024, 02, 28, 14, 00, 00), Frequency.Once); 
        }

        [TestMethod]
        public void SetAccount_ValidAccount_AccountSet()
        {
            Account acc = new Account("personnel@account.com", "personnelpass123", false);
            
            personnel.setAccount(acc);

            Assert.AreEqual(acc, personnel.Account);
        }

        [TestMethod]
        public void SetAppointmentRequest_ValidRequest_StatusUpdated() 
        {
            Request request = new Request(personnel, "Consulation", new DateTime(2024, 02, 28, 11, 00, 00), new DateTime(2024, 02, 28, 11, 30, 00));
            client.Requests.Add(request);

            bool result = personnel.SetAppointmentRequest(client, RequestStatus.Done);

            Assert.IsTrue(result);
            Assert.AreEqual(RequestStatus.Done, request.Status);
        }

        [TestMethod]
        public void SetPersonnelStatus_ValidStatus_StatusUpdated()
        {
            PersonnelStatus status = PersonnelStatus.OnLeave;

            personnel.SetPersonnelStatus(status);

            Assert.AreEqual(status, personnel.Status);
        }

        //[TestMethod]
        public void AddWorkSchedule_ValidSchedule_ScheduleAdded()
        {
            bool result = personnel.AddWorkSchedule(sched);

            Assert.IsTrue(result);
        }

        //[TestMethod]
        public void RemoveWorkSchedule_ValidSchedule_ScheduleRemoved()
        {
            personnel.AddWorkSchedule(sched);

            bool result = personnel.RemoveWorkSchedule(sched);

            Assert.IsTrue(result);
            Assert.IsFalse(personnel.WorkSchedule.Contains(sched));
        }
    }
}
