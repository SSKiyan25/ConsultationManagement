using ConsultationManagement;
using System.Security.Principal;


namespace ConsultationManagementTest
{
    public class AccountTest
    {
        [Fact]
        public void AccountTest_Authenticate_ReturnTrue()
        {
            var account1 = new Account("pogi@gmail.com", "pogi", true);
            var account2 = new Account("pogi2@gmail.com", "pogi", false);

            var result1 = account1.Authenticate("pogi@gmail.com", "pogi");
            var result2 = account2.Authenticate("pogi2@gmail.com", "pogi");

            Assert.True(result1);
            Assert.True(result2);

        }
        [Fact]
        public void AccountTest_Authenticate_ReturnFalse()
        {
            var account1 = new Account("pogi@gmail.com", "pogi", true);
            var account2 = new Account("pogi2@gmail.com", "pogi", false);

            var result1 = account1.Authenticate("pogi@gmail.com", "pogi1234");
            var result2 = account2.Authenticate("pogi2@gmail.com", "pogi4321");

            Assert.False(result1);
            Assert.False(result1);

        }

         [Fact]
         public void AccountTest_SetEmailAddress_GetEmailAddress()
         {
             var account = new Account("pogi@gmail.com", "pogi1234", true);

              account.SetEmailAddress("pogi1234@gmail.com");

             var result = account.GetEmailAddress();
            
            Assert.NotNull(result);
            Assert.Matches("pogi1234@gmail.com", result.ToString());
            Assert.DoesNotMatch("pogi@gmail.com", result.ToString());



         }  


        [Fact]
        public void AccountTest_SetPassword_GetPassword()
        {
            var account = new Account("pogi@gmail.com", "pogi1234", false);

            account.SetPassword("haynakopogiko");

            var result = account.GetPassword();

            Assert.NotNull (result);
            Assert.Matches("haynakopogiko",result.ToString());
            Assert.DoesNotMatch("pogi1234", result.ToString());

        }

        [Fact]
        public void AccountTest_SetAdminStatus_GetAdminStatus()
        {
            var account1 = new Account("pogi@gmail.com", "pogi", true);
            var account2 = new Account("pogi2@gmail.com", "pogi", false);

            account1.SetAdminStatus(false);
            account2.SetAdminStatus(true);

            var result1 = account1.GetAdminStatus();
            var result2 = account2.GetAdminStatus();


            Assert.True(result2);
            Assert.False(result1);


        }

        [Fact]
        public void AccountTest_GetDateCreated_ReturnDateTime()
        {
            var account = new Account("pogi@gmail.com", "pogi", false);

            var result = account.GetDateCreated();

            Assert.IsType<DateTime>(result);
            
            
        }

       
    }
}