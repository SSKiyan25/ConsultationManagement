using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsultationManagement;

namespace ConsultationManagement.UnitTests
{
    [TestClass]
    public class AdminTests
    {
        private Admin admin;
        private Personnel personnel;
        private Request request;

        [TestInitialize]
        public void TestInitialize()
        {
            admin = new Admin("admin@admin.com", "adminpass123");
            personnel = new Personnel("Joonhee", "09123456789", PersonnelStatus.Available);
            request = new Request(personnel, "Consultation", new DateTime(2024, 02, 25), new DateTime(2024, 02, 29));
        }

        [TestMethod]
        public void AddPersonnel_AddsPersonnelToHashSet_ReturnsTrue()
        {
            bool result = admin.AddPersonnel(personnel);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RemovePersonnel_RemovesPersonnelFromHashSet_ReturnsTrue()
        {
            admin.AddPersonnel(personnel);
            bool result = admin.RemovePersonnel(personnel);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DeleteRequest_SetsIsArchivedToTrue_ReturnsTrue()
        {
            bool result = admin.DeleteRequest(request);
            Assert.IsTrue(result);
        }
    }
}
