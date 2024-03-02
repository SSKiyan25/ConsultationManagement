using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsultationManagement.UnitTests
{
    [TestClass]
    public class RequestTests
    {
        private Request request;
        private Personnel personnel;

        [TestInitialize]
        public void TestInitialize()
        {
            personnel = new Personnel("Joonhee", "09987654321", PersonnelStatus.Available);
            request = new Request(personnel, "Consultation", new DateTime(2024, 02, 29, 15, 00, 00), new DateTime(2024, 02, 29, 16, 00, 00));
        }

        [TestMethod]
        public void TestRequestIDIsUnique()
        {
            var another_request = new Request(personnel, "Meeting", new DateTime(2024, 02, 29, 11, 00, 00), new DateTime(2024, 02, 29, 12, 00, 00));

            Assert.AreNotEqual(request.RequestID, another_request.RequestID);
        }
    }
}
