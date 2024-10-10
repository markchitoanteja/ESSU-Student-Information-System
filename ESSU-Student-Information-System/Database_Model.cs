using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ESSU_Student_Information_System
{
    internal class Database_Model
    {
        public void Initialize_Database()
        {
            Database_Connection();
            Create_Users_Table();
        }

        private string Database_Connection()
        {
            string connection_string = "server=localhost;user id=root";
            string db_connection_string = "";

            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                try
                {
                    conn.Open();

                    string db_name = "essu_student_information_system";

                    MySqlCommand cmd = new MySqlCommand($"SHOW DATABASES LIKE '{db_name}'", conn);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MySqlCommand query = new MySqlCommand($"CREATE DATABASE {db_name}", conn);

                        query.ExecuteNonQuery();
                    }

                    db_connection_string = $"server=localhost;user id=root;database={db_name}";
                }
                catch (MySqlException err)
                {
                    MessageBox.Show("Error: " + err.Message, "MySQL Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                }
            }

            return db_connection_string;
        }

        private void Create_Users_Table()
        {
            string database_connection = Database_Connection();

            using (MySqlConnection conn = new MySqlConnection(database_connection))
            {
                conn.Open();

                MySqlCommand cmd_1 = new MySqlCommand("SHOW TABLES LIKE 'users'", conn);

                object result_1 = cmd_1.ExecuteScalar();

                if (result_1 == null)
                {
                    string sql_2 = "CREATE TABLE `users` (`id` INT AUTO_INCREMENT PRIMARY KEY, `uuid` CHAR(36) NOT NULL, `name` VARCHAR(100) NOT NULL, `username` VARCHAR(100) NOT NULL UNIQUE, `password` VARCHAR(255) NOT NULL, `image` VARCHAR(100) NOT NULL, `user_type` VARCHAR(10) NOT NULL, `created_at` VARCHAR(20) NOT NULL, `updated_at` VARCHAR(20) NOT NULL)";

                    MySqlCommand cmd_2 = new MySqlCommand(sql_2, conn);

                    cmd_2.ExecuteNonQuery();

                    Insert_Admin_Data();
                }
            }
        }

        private void Insert_Admin_Data()
        {
            DateTime currentDateTime = DateTime.Now;

            Dictionary<string, object> user_data = new Dictionary<string, object>
            {
                { "uuid", Guid.NewGuid().ToString() },
                { "name", "Administrator" },
                { "username", "admin" },
                { "password", BCrypt.Net.BCrypt.HashPassword("admin123") },
                { "image", "default-user-image.png" },
                { "user_type", "admin" },
                { "created_at", currentDateTime },
                { "updated_at", currentDateTime }
            };

            Insert("users", user_data);
        }

        public bool Insert(string table_name, Dictionary<string, object> data)
        {
            try
            {
                string database_connection = Database_Connection();

                using (MySqlConnection conn = new MySqlConnection(database_connection))
                {
                    conn.Open();

                    string columns = string.Join(", ", data.Keys);
                    string parameters = string.Join(", ", data.Keys.Select(key => "@" + key));

                    string query = $"INSERT INTO {table_name} ({columns}) VALUES ({parameters})";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        foreach (var kvp in data)
                        {
                            cmd.Parameters.AddWithValue("@" + kvp.Key, kvp.Value ?? DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void Update(string table_name, Dictionary<string, object> data, string column, object value)
        {
            string database_connection = Database_Connection();

            using (MySqlConnection conn = new MySqlConnection(database_connection))
            {
                conn.Open();

                var setClause = string.Join(", ", data.Keys.Select(key => $"{key} = @{key}"));

                string query = $"UPDATE {table_name} SET {setClause} WHERE {column} = @value";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    foreach (var kvp in data)
                    {
                        cmd.Parameters.AddWithValue("@" + kvp.Key, kvp.Value ?? DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@value", value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string table_name, string column, object value)
        {
            string database_connection = Database_Connection();

            using (MySqlConnection conn = new MySqlConnection(database_connection))
            {
                try
                {
                    conn.Open();

                    string query = $"DELETE FROM {table_name} WHERE {column} = @value";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", value);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}");
                }
            }
        }

        public Dictionary<string, object> Get_One(string table_name, string column_name, object value)
        {
            string database_connection = Database_Connection();

            Dictionary<string, object> result = new Dictionary<string, object>();

            using (MySqlConnection conn = new MySqlConnection(database_connection))
            {
                conn.Open();

                string query = $"SELECT * FROM {table_name} WHERE {column_name} = @value LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@value", value);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                result.Add(reader.GetName(i), reader.GetValue(i));
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Dictionary<string, object>> Get_Many(string table_name, string column_name, object value)
        {
            string database_connection = Database_Connection();
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            using (MySqlConnection conn = new MySqlConnection(database_connection))
            {
                conn.Open();

                string query = $"SELECT * FROM {table_name} WHERE {column_name} = @value";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@value", value);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            results.Add(row);
                        }
                    }
                }
            }

            return results;
        }

        public List<Dictionary<string, object>> Get_All(string table_name, string order_by_column, string order_by_value)
        {
            string database_connection = Database_Connection();
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            using (MySqlConnection conn = new MySqlConnection(database_connection))
            {
                conn.Open();

                string query = $"SELECT * FROM `{table_name}` ORDER BY `{order_by_column}` {order_by_value}";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            results.Add(row);
                        }
                    }
                }
            }

            return results;
        }
    }
}
