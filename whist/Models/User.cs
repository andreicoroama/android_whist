using System;

namespace whist
{
	public class User
	{
		public Guid ID { get; set;}
		public string Name { get; set;}
		public string Avatar { get; set;}
		public int Bet { get; set;}

		public User ()
		{
		}

		public void AddUser(string name, string avatar)
		{
			ID = new Guid ();
			Name = name;
			Avatar = avatar;
		}
	}
}

