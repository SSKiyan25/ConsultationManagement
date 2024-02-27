using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationManagement
{
    [FirestoreData]
    public class UserData
    {
        [FirestoreProperty]
        public string Username { get; set; }
    }
}
