using System.Collections.Generic;

namespace ESSU_Student_Information_System
{
    public static class Session
    {
        public static string admin_id;
        public static Dictionary<string, string> remember_me_data = new Dictionary<string, string>();
        public static bool is_application_exiting = false;
        public static string developer_password = BCrypt.Net.BCrypt.HashPassword("chito_mapagmahal");
        public static string temporary_password;
    }
}
