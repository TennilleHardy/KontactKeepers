using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Admin
    {
		private int pidadmin;

		public int PIDAdmin
		{
			get { return pidadmin; }
			set { pidadmin = value; }
		}
		private string fname;

		public string FName
		{
			get { return fname; }
			set { fname = value; }
		}
		private string lname;

		public string LName
		{
			get { return lname; }
			set { lname = value; }
		}
		private string uname;

		public string UName
		{
			get { return uname; }
			set { uname = value; }
		}
		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}
		public Admin(int pidadmin, string fname, string lname, string uname, string password)
		{
			this.pidadmin = pidadmin;
			this.fname = fname;
			this.lname = lname;
			this.uname = uname;
			this.password = password;
		}
	}
}
