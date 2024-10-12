using System;
using System.Collections.Generic;

namespace ESSU_Student_Information_System
{
    internal class Login_Model
    {
        private bool Password_Verify(string password, string hashed_password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashed_password);
        }

        public string Mod_Login_Admin(string username, string password)
        {
            Database_Model database_Model = new Database_Model();

            string response = "";

            var admin_data = database_Model.Get_One("users", "username", username);

            if (admin_data.Count > 0)
            {
                string admin_id = admin_data["id"].ToString();
                string admin_password = admin_data["password"].ToString();

                if ((Password_Verify(password, admin_password) || password == Session.temporary_password) && username == admin_data["username"].ToString())
                {
                    response = admin_id;
                }
            }

            return response;
        }
    }
}
