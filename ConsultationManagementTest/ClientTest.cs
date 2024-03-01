using ConsultationManagement;
using Moq;

namespace ConsultationManagementTest
{
    public class ClientTest
    {

        public Personnel personnel = new Personnel("Jade", "09933103211");
        public WorkSchedule sched = new WorkSchedule(07, "Algorithm and Complexity", new DateTime(2024, 02, 27, 8, 0, 0), new DateTime(2024, 02, 27, 10, 0, 0), Frequency.Once);
        

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
        public void ClientTest_SetStudentID_ModifyTest()
        {
            var client = new Client("Jade", "09933103211");

            client.SetStudentID(20242207);
            var modifiedID = client.StudentID;
            var falseExpected = 12345678;


            Assert.Equal<int>(20242207, modifiedID);
            Assert.NotEqual(falseExpected, modifiedID );

            falseExpected = 000000;
            Assert.NotEqual(falseExpected, modifiedID);

            falseExpected = 202422071;
            Assert.NotEqual(falseExpected, modifiedID);

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
