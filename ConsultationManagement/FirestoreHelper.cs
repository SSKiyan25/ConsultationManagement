using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsultationManagement
{
    public static class FirestoreHelper
    {
        static string fireconfig = @"
        {
            ""type"": ""service_account"",
            ""project_id"": ""consultation-management-57818"",
            ""private_key_id"": ""5ca2367ea7d5ccb650078d6863ba17fd13a802d8"",
            ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCZcCcau+Pgb/Gf\nphR99WZVJDOQ23N/V0yy9jfEzX8kTcEgbe0bntMVZOneGzjrkdF1otTFKL0x5pgB\nCsr/wF4Xmqj91Nl4SKN/hpvrmsNhm+7xCoj9P2hFYoDaRX2BB+05vsfS8sDzqia7\nLlpiqFMYXBHxR7psnYmvljXEjDEeL7axLiyDuOw0Pzjebp6qqV+4mP251bTt7cWd\nsJTR8pcrLKUIr/CapF3l8Gb3SH315yXGISeiO2SvdsN2EB5RDAXJH5O/KwIwJWEG\neOdDbeOTnPS4E7sA++2lWeoiIuw0JHi+B9md6fYE0Cw0bp8O6nnifgXM8wVnkAla\n3FSXoWjVAgMBAAECggEAIMHsX01As7BChgJ3eoKzI7c0WRc427VgFw7wzg/PNolx\nE0LUraJlTzp5oWTvbH93l+U5BpSRe79OsV5EA4DmtaRbssFH4mGjojyzOgQS9VpM\nk2Jb57ErSjDi8HaIek0ebMcZsyQHZJ3tYeXd/xUPlHJHlFrrZnflprprZThG3jod\nrlk8nUH9rz3ZUz1znY8OaEP9SuUydbG2SZrduZCROFXcq6Qfm9tYpxiqG4/zXSLL\nRVS4eePK0hRy4cRthE2HQ+SkK84HChPUR84/ChgurwUFQ13UOTqanw5nsQk8Y3OZ\nd3icqqp8VU83s3rlCciiqO1hmDd1mXrDhdI15ocTywKBgQDVE9DjZ9JECwm/P9li\nlp1TFaKev5Fl/NnU5f113Q+Vt1/czcrcdRfKns/98nFTrnpVYunAgSnQFNlAYBSf\nI/7MjSzMWlLot4jcvpq8TL+LcPDP/n+uLP5vsYniT+SJeQMUGBm7NVopzq8Cn98f\n4l70ceBui10KvS60kxIdL7IwCwKBgQC4WMxuKP/l/acWhbG3YWJ07C3T3nSybGw7\nYZCIrUkyhrVMTj0EjuJ/PBZ7ACMbgwrYaua3psbl7TFsnQjk3ZHGDp6jx7du8V0a\nP4h8lFmPlIxR8pSUPeeOjcenvJAzh+ig9lyOToXFY/ZPolO/h6HvlniRG07TgJe+\n8jmhgUH2nwKBgQDAlN1qe26WoydXHL08lwZwjpBhTKF8fVDgVFKGEZvBZHCXH8Tn\nBknPj0RLsLFuwba9r923aMZC1GUbAvwAbccgV8SSmlxvC1r+sKMn53ID9LsiMlJy\nOSZqCxulWTIkciQvKC0xf+ITAUQ6agZ/SdkqtDX1k64vQ5eQC5EGohI5ywKBgAkl\nBocUa5VKHubEHQu+vfaU3LUc3OcY78mGTngpOG9UNVwiqW43dE7heTAC0rsDph8U\nNnu3vzgaqw/7Pjy0LQ4JHZ98QcI0IO0zZ57ecQ7pTIioIuyzoW/14oiUlwanYEfT\n0MWSaZpgGhDbOZJPtR3AdhykoSVmxKBJPcigM9h7AoGASGwmP60Ni5cH+X7gluz8\nN4MvOaQrm5OWKUn5yuMULYMWeIhNEAz3D+j1UNfp7Ngzd3I+p2TV4ocAb4j1vHpI\n3SL2EpFGpib2hC4vLewRDJXuxu3jQnLqYULEKLYnvC7W1wFDq0HcAeCWfcaWOZcF\nUIYomw/6C8jiai/VVhHE36I=\n-----END PRIVATE KEY-----\n"",
            ""client_email"": ""firebase-adminsdk-ir575@consultation-management-57818.iam.gserviceaccount.com"",
            ""client_id"": ""113350272377160759270"",
            ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
            ""token_uri"": ""https://oauth2.googleapis.com/token"",
            ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
            ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-ir575%40consultation-management-57818.iam.gserviceaccount.com"",
            ""universe_domain"": ""googleapis.com""
        }";

        static string filepath = "";
        public static FirestoreDb Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("consultation-management-57818");
            File.Delete(filepath);
        }
    }
}
