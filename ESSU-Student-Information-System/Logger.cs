using System;
using System.Collections.Generic;

namespace ESSU_Student_Information_System
{
    internal class Logger
    {
        public void Log(string activity)
        {
            DateTime currentDateTime = DateTime.Now;

            Database_Model database_model = new Database_Model();

            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "uuid", Guid.NewGuid().ToString() },
                { "activity", activity },
                { "created_at", currentDateTime },
                { "updated_at", currentDateTime }
            };

            database_model.Insert("logs", data);
        }
    }
}
