using ConsultationManagement;

namespace ConsultationManagementTest
{
    public class RequestTest
    {
        [Fact]
        public void RequestTest_RequestCreation()
        {
            var personnel = new Personnel("Jade", "09123456789");
            var request1 = new Request(personnel, "Ask for handsome registration form", new DateTime(2024, 02, 28), new DateTime(2024, 02, 29));
            var request2 = new Request(personnel, "Ask for handsome Grades", new DateTime(2024, 02, 28), new DateTime(2024, 02, 29));
            var request3 = new Request(personnel, "Ask for handsome registration form", new DateTime(2024, 02, 28), new DateTime(2024, 02, 29));
           
            var personnelcheck = request1.Personnel;
            request2.Status = RequestStatus.Denied;
            var purpose1 = request1.Purpose;
            var purpose2 = request2.Purpose;
            var purpose3 = request3.Purpose;

            var rID1 = request1.RequestID;
            var rID2 = request2.RequestID;
            var rID3 = request3.RequestID;

            Assert.Same(personnel, personnelcheck);
            Assert.NotSame(request1, request3);
            Assert.NotEqual(request1, request2);
            Assert.DoesNotMatch(purpose1, purpose2);
            Assert.Matches(purpose1, purpose3);
            Assert.NotEqual(rID3 , rID1);
            Assert.NotEqual(rID2 , rID3);
        }

    }
}