using ConsultationManagement;
using Moq;

namespace ConsultationManagementTest
{
    public class ClientTest
    {

        [Fact]
        public void ClientTest_ClientId_ShouldBe_Unique()
        {
            var client1 = new Client("Jae", "09123456789");
            var client2 = new Client("Jaes", "09123400789");
            var client3 = new Client("Jaed", "09003456789");
            var client4 = new Client("Jaer", "09123456009");
            var client5 = new Client("Jaek", "09100456789");

            var client1ID = client1.ClientID;
            var client2ID = client2.ClientID;
            var client3ID = client3.ClientID;
            var client4ID = client4.ClientID;
            var client5ID = client5.ClientID;

            Assert.False(client1ID == client2ID);
            Assert.False(client2ID == client3ID);
            Assert.False(client3ID == client4ID);
            Assert.False(client4ID == client5ID);

        }

        



        [Fact]
        public void ClientTest_SetEmailAddress_ModifyTest()
        {
            var client = new Client("Jade", "09933103211");

            client.SetEmailAddress("jadepogi@gmail.com");
            var modifiedEmail = client.EmailAddress;
            var falseExpected = "false@gmail.com";

            Assert.True(modifiedEmail != null);
            Assert.Matches("jadepogi@gmail.com", modifiedEmail.ToString());
            Assert.DoesNotMatch(falseExpected, modifiedEmail );
           
        }

        [Fact]
        public void ClientTest_Initially_A_Non_StudentClient()
        {
            var client = new Client("Jae", "09123456789");
            var isStudent = client.IsStudent;

            Assert.False(isStudent);
        }

        [Fact]
        public void ClientTest_ShouldbeAStudent_WhenStudentIDPresent()
        {
            var client = new Client("Jae", "09123456789");
            client.SetStudentID("22-1-00159");
            var isStudent = client.IsStudent;

            Assert.True(isStudent);
        }

        [Fact]
        public void ClientTest_StudentID_Should_Match()
        {
            var client = new Client("Jade", "09933103211");

            client.SetStudentID("22-1-01059");
            var modifiedID = client.StudentID;
            var falseExpected = "22-1-00000";


            Assert.Equal("22-1-01059", modifiedID);
            Assert.NotEqual(falseExpected, modifiedID );

            falseExpected ="22101059";
            Assert.NotEqual(falseExpected, modifiedID);


        }

        [Fact]
        public void ClientTest_ClientRequest_AccumulatesAndAccessible()
        {
            var count = 0;
            var client = new Client("Jae", "09123498765");
            var Sir = new Personnel("Sir Isaac", "09123456789",PersonnelStatus.Available);
          
            var request = new Request(Sir, "Pede ko Magpahimo Research?", new DateTime(2024, 03, 1, 8, 0, 0), new DateTime(2024, 03, 2, 16, 0, 0));
            var request2 = new Request(Sir, "Request sad kog Loa", new DateTime(2024, 03, 1, 8, 0, 0), new DateTime(2024, 03, 2, 16, 0, 0));
            var request3 = new Request(Sir, "Ay asta Form 137 sad diay", new DateTime(2024, 03, 1, 8, 0, 0), new DateTime(2024, 03, 2, 16, 0, 0));

            client.Requests.Add(request);
            client.Requests.Add(request2);
            client.Requests.Add(request3);

            foreach (Request r in client.Requests)
            {
                count++;
                Assert.NotNull(r);
            }
            var purpose1 = client.Requests[0].Purpose;
            var purpose2 = client.Requests[1].Purpose;
            var purpose3 = client.Requests[2].Purpose;

            var endreq1 = client.Requests[0].RequestedTimeEnd;
            var endreq2 = client.Requests[1].RequestedTimeEnd;
            var endreq3 = client.Requests[2].RequestedTimeEnd;

            var targetpersonnel1 = client.Requests[0].Personnel; 
            var targetpersonnel2 = client.Requests[1].Personnel; 
            var targetpersonnel3 = client.Requests[2].Personnel; 
            
            Assert.NotEqual(purpose1, purpose2);
            Assert.NotEqual(purpose1, purpose3);
            Assert.Equal(endreq1, endreq2);
            Assert.Equal(endreq2, endreq3);
            Assert.Same(Sir, targetpersonnel1);
            Assert.Same(Sir, targetpersonnel2);
            Assert.Same(Sir, targetpersonnel3);
            Assert.Equal(3, count);

        }
        
        [Fact]
        public void ClientTest_AddRequestAppointment_ReturnBool()
        {
            //var personnel = new Personnel("Jade", "09933103211");
            //var workSched1 = new WorkSchedule(07, "Algorithm and Complexity", new DateTime(2024, 02, 27, 8,0,0), new DateTime(2024, 02, 27,10,0,0), Frequency.Once);
            //var workSched2 = new WorkSchedule(07, "EDP", new DateTime(2024, 02, 26, 13,0,0), new DateTime(2024, 02, 26,16,0,0), Frequency.Once);
            //var workSched3 = new WorkSchedule(07, "Algorithm and Complexity", new DateTime(2024, 02, 24), new DateTime(2024, 02, 25,23,0,0), Frequency.Once);
            //personnel.SetPersonnelStatus(PersonnelStatus.Available);


            //personnel.AddWorkSchedule(workSched1);
            //personnel.AddWorkSchedule(workSched2);
            //personnel.AddWorkSchedule(workSched3);

            //var person = personnel.Status;

            //var client = new Client("ninja turtles", "09876543213");
            //var appointment = client.AddRequestAppointment(personnel, "Can I consult about how I feel", new DateTime(2024, 02, 27, 11, 0, 0), new DateTime(2024, 02, 27, 12, 0, 0));
            //var addedClient = personnel.Clients;
            //var addedRequest = client.Requests;

            //Assert.Equal();
        }



        /* [Fact]
         public void AddRequestAppointment_WorkScheduleConflict_ReturnsFalse()
         {

             var client = new Client("John Doe", "123-456-7890");
             var personnelMock = new Mock<Personnel>(); 
             personnelMock.SetupGet(p => p.Status).Returns(PersonnelStatus.Available); 
             personnelMock.Setup(p => p.AddWorkSchedule(It.IsAny<WorkSchedule>())).Returns(true); 


             var conflictingWorkSchedule = new WorkSchedule(1, "Conflicting Schedule", new DateTime(2024, 2, 28, 11, 0, 0), new DateTime(2024, 2, 28, 13, 0, 0), Frequency.Once);
             personnelMock.Setup(p => p.WorkSchedule).Returns(new HashSet<WorkSchedule> { conflictingWorkSchedule });

             DateTime start = new DateTime(2024, 2, 28, 12, 0, 0); 
             DateTime end = new DateTime(2024, 2, 28, 14, 0, 0);


             //bool result = client.AddRequestAppointment(personnelMock.Object, "Meeting", start, end);


             Assert.False(result); 
             Assert.Empty(client.Requests); 
         }*/

      /*  [Fact]
        public void ClientCheck_IsStudent()
        {
            var client = new Client("Jade", "09123456789");
            client.
        }*/


    }


}
