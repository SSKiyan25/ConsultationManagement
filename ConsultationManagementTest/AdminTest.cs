using ConsultationManagement;

namespace ConsultationManagementTest
{
    public class AdminTest
    {
        [Fact]
        public void AdminTest_AddRemovePersonnel_ReturnTrue()
        {
            var personnel = new Personnel("Jade", "09933103211", PersonnelStatus.Available);
            var admin = new Admin("pogi@gmail.com","pogi1234");

            var addResult = admin.AddPersonnel(personnel);
            Assert.True(addResult);

            var removeResult = admin.RemovePersonnel(personnel);
            Assert.True(removeResult);

        }   
        
       
        [Fact]
        public void AdminTest_DeleteRequest_ReturnTrue()
        {
            var personnel = new Personnel("Jade", "09933103211", PersonnelStatus.Available);
            var request = new Request(personnel, "Naay Klase?", new DateTime(2024, 01, 01), new DateTime(2024, 02, 27));
            var admin = new Admin("pogi@gmail.com","pogi1234");

            var result = admin.DeleteRequest(request);

            Assert.True(result);

        }




    }
}