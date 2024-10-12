using System;
using System.Collections.Generic;

namespace ESSU_Student_Information_System
{
    internal class Main_Model
    {
        public Dictionary<string, object> Mod_Get_Admin_data(string id)
        {
            Database_Model database_model = new Database_Model();

            var result = database_model.Get_One("users", "id", id);

            return result;
        }

        public void Mod_Update_Admin(string id, string name, string username, string password, string image)
        {
            Database_Model database_model = new Database_Model();

            DateTime currentDateTime = DateTime.Now;

            Dictionary<string, object> user_data = new Dictionary<string, object>
            {
                { "name", name },
                { "username", username },
                { "password", password },
                { "image", image },
                { "updated_at", currentDateTime }
            };

            database_model.Update("users", user_data, "id", id);
        }

        public bool Mod_Insert_Student(string student_number, string course, string year, string section, string first_name, string middle_name, string last_name, string birthday, string mobile_number, string email, string address, string image)
        {
            bool response = false;

            DateTime currentDateTime = DateTime.Now;

            Database_Model database_model = new Database_Model();

            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "uuid", Guid.NewGuid().ToString() },
                { "student_number", student_number },
                { "course", course },
                { "year", year },
                { "section", section },
                { "first_name", first_name },
                { "middle_name", middle_name },
                { "last_name", last_name },
                { "birthday", birthday },
                { "mobile_number", mobile_number },
                { "email", email },
                { "address", address },
                { "image", image },
                { "status", "Active" },
                { "created_at", currentDateTime },
                { "updated_at", currentDateTime }
            };

            if (database_model.Insert("students", data))
            {
                response = true;
            }

            return response;
        }

        public bool Mod_Update_Student(string id, string student_number, string course, string year, string section, string first_name, string middle_name, string last_name, string birthday, string mobile_number, string email, string address, string image)
        {
            Database_Model database_model = new Database_Model();

            DateTime currentDateTime = DateTime.Now;

            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "student_number", student_number },
                { "course", course },
                { "year", year },
                { "section", section },
                { "first_name", first_name },
                { "middle_name", middle_name },
                { "last_name", last_name },
                { "birthday", birthday },
                { "mobile_number", mobile_number },
                { "email", email },
                { "address", address },
                { "image", image },
                { "updated_at", currentDateTime }
            };

            if (database_model.Update("students", data, "id", id))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
