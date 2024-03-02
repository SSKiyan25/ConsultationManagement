using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsultationManagement;

namespace ConsultationManagement.UnitTests
{
    [TestClass]
    public class AccountTests
    {
        private Account acc;

        [TestInitialize]
        public void TestInitialize()
        {
            acc = new Account("example@test.com", "test1234", true);
        }

        [TestMethod]
        public void Authenticate_ValidCredentials_ReturnsTrue()
        {
            bool result = acc.Authenticate("example@test.com", "test1234");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Authenticate_InvalidEmail_ReturnsFalse()
        {
            bool result = acc.Authenticate("wrong@email.com", "test1234");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Authenticate_InvalidPassword_ReturnsFalse()
        {
            bool result = acc.Authenticate("example@test.com", "wrongpassword");

            Assert.IsFalse(result);
        }



        [TestMethod]
        public void SetEmailAddress_ValidEmail_UpdatesEmail()
        {
            acc.SetEmailAddress("new@email.com");

            Assert.AreEqual("new@email.com", acc.GetEmailAddress());
        }

        [TestMethod]
        public void SetPassword_ValidPassword_UpdatesPassword()
        {
            acc.SetPassword("newpassword123");

            Assert.AreEqual("newpassword123", acc.GetPassword());
        }

        [TestMethod]
        public void SetAdminStatus_ChangeStatus_UpdatesStatus()
        {
            acc.SetAdminStatus(false);

            Assert.IsFalse(acc.GetAdminStatus());
        }

        [TestMethod]
        public void DeleteAccount_AfterDeletion_IsArchived()
        {
            acc.DeleteAccount();

            var result = acc.Authenticate("example@test.com", "test1234");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RestoreAccount_AfterRestoration_IsNotArchived()
        {
            acc.DeleteAccount();
            acc.RestoreAccount();

            var result = acc.Authenticate("example@test.com", "test1234");

            Assert.IsTrue(result);
        }
    }
}
