using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dwelly.Models;

namespace Dwelly.ModelViews
{
    internal class UsersMV
    {
        private string connectionString;
        public List<UsersModel>Users { get; set; } = new List<UsersModel>();

        public UsersMV()
        {
            // Assuming the connection string is stored in App.config
            connectionString = ConfigurationManager.ConnectionStrings["MyDefaultConnection"].ConnectionString;
            LoadUsers();
        }

        public void LoadUsers()
        {
            Users.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT user_id, user_username, user_password, user_birthday, user_firstname, user_lastname, user_email FROM users;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UsersModel users = new UsersModel
                    {
                        user_id = reader.GetInt32(0),
                        user_username = reader.GetString(1),
                        user_password = reader.GetString(2),
                        user_birthday = reader.GetString(3),
                        user_firstname = reader.GetString(4),
                        user_lastname = reader.GetString(5),
                        user_email = reader.GetString(6),
                    };
                    Users.Add(users);
                }
                connection.Close();
            }
        }
    }
}
