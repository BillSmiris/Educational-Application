using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;

namespace EkpaideftikoLogismikoWeb
{
    public class DataAccess
    {
        private NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=19921992;Database=EkpaideftikoLogismiko");

        public DataAccess()
        {
            con.Open();
        }

        public Models.User AuthenticateUser(string username, string password)
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
                    return new Models.User((int)dr[0], (string)dr[1], (bool)dr[3]);
                }
            }
            return null;
        }
    }
}