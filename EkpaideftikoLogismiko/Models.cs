using System;
using System.Collections.Generic;
using System.Text;

namespace EkpaideftikoLogismiko
{
    public class User
    {
		private int id;
		private string username;
		private bool userType;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		public bool UserType
		{
			get { return userType; }
			set { userType = value; }
		}

		public User(int id, string username, bool userType)
		{
			this.id = id;
			this.username = username;
			this.userType = userType;
		}
	}
}
