using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace EkpaideftikoLogismiko
{
    class DataAccess
    {
        //private NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=19921992;Database=EkpaideftikoLogismiko");
        private NpgsqlConnection con = new NpgsqlConnection("host=localhost;port=5432;database=EkpaideftikoLogismiko;user id=postgres");

        public DataAccess()
        {
            con.Open();
        }

        public User AuthenticateUser(string username, string password)
        {
            var sql = "SELECT * FROM users WHERE username=@username;";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar);
            cmd.Parameters["@username"].Value = username;
            //cmd.Parameters.AddWithValue("@username", username);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (password == (string)dr[2])
                {
                    return new User((int)dr[0], (string)dr[1], (bool)dr[3]);
                }
            }
            return null;
        }
    }
}