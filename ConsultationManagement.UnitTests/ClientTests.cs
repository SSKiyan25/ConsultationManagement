using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsultationManagement;

namespace ConsultationManagement.UnitTests
{
    [TestClass]
    public class ClientTests
    {
        private Client client;
        private Personnel personnel;

        [TestInitialize]
        public void TestInitialize()
        {
            client = new Client("Juan", "09987654321");
            personnel = new Personnel("Jonhei", "09987654321", PersonnelStatus.Available);
        }

        [TestMethod]
        public void SetEmailAddress_ValidEmailAddress_EmailAddressSet()
        {
            string email = "client@email.com";

            client.SetEmailAddress(email);

            Assert.AreEqual(email, client.EmailAddress);
        }

        [TestMethod]
        public void ClientID_UniqueID_ReturnsTrue()
        {
            var client2 = new Client("Jose", "09213214321");
            var client3 = new Client("Julio", "09324325432");

            Assert.IsTrue(client.ClientID != client2.ClientID);
            Assert.IsTrue(client.ClientID != client3.ClientID);
            Assert.IsTrue(client2.ClientID != client3.ClientID);
        }

        [TestMethod]
        public void SetStudentID_ValidStudentID_StudentIDSet()
        {
            string studentID = "23-1-00001";

            client.SetStudentID(studentID);

            Assert.AreEqual(studentID, client.StudentID);
        }

        [TestMethod]
        public void Client_IsStudent_ReturnsTrue()
        {
            client.SetStudentID("21-1-00001");
            Assert.IsTrue(client.IsStudent);
        }

        [TestMethod]
        public void Client_IsNotAStudent_ReturnsFalse()
        {
            bool isStudent = client.IsStudent;
            Assert.IsFalse(isStudent);
        }

        //[TestMethod]
        public void AddRequestAppointment_PersonnelAvailableAndNoScheduleConflict_RequestAddedAndReturnsTrue()
        {
            string purpose = "Consultation";
            DateTime start = DateTime.Now.AddDays(2);
            DateTime end = start.AddHours(1);

            bool result = client.AddRequestAppointment(personnel, purpose, start, end);

            Assert.IsTrue(result);
            Assert.AreEqual(1, client.Requests.Count);
            Assert.IsTrue(personnel.Clients.ContainsKey(client));
        }
    }
}
