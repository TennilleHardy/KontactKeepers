using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class EndUser
    {
		private int pidenduser;

		public int PIDEndUser
		{
			get { return pidenduser; }
			set { pidenduser = value; }
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
		private string idnumber;
		public string IDNumber
		{
			get { return idnumber; }
			set { idnumber = value; }
		}
		private string cellnumber;

		public string CellNumber
		{
			get { return cellnumber; }
			set { cellnumber = value; }
		}
		private bool waauthed;

		public bool WAAuthed
		{
			get { return waauthed; }
			set { waauthed = value; }
		}
		private bool waverified;

		public bool WAVerified
		{
			get { return waverified; }
			set { waverified = value; }
		}
		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		private bool emailauthed;

		public bool EmailAuthed
		{
			get { return emailauthed; }
			set { emailauthed = value; }
		}
		private bool emailverified;

		public bool EmailVerified
		{
			get { return emailverified; }
			set { emailverified = value; }
		}
		private string fburl;

		public string FBURL
		{
			get { return fburl; }
			set { fburl = value; }
		}
		private string fbmessengerid;

		public string FBMessengerID
		{
			get { return fbmessengerid; }
			set { fbmessengerid = value; }
		}
		private bool fbauthed;

		public bool FBAuthed
		{
			get { return fbauthed; }
			set { fbauthed = value; }
		}
		private bool fbverified;

		public bool FBVerified
		{
			get { return fbverified; }
			set { fbverified = value; }
		}
		private string twitterurl;

		public string TwitterURL
		{
			get { return twitterurl; }
			set { twitterurl = value; }
		}
		private DateTime lastverified;

		public DateTime LastVerified
		{
			get { return lastverified; }
			set { lastverified = value; }
		}
		private bool pursue;

		public bool Pursue
		{
			get { return pursue; }
			set { pursue = value; }
		}
		private DateTime lastpinged;

		public DateTime LastPinged
		{
			get { return lastpinged; }
			set { lastpinged = value; }
		}

		public EndUser(int pidenduser, string fname, string lname, string uname, string password, string idnumber, string cellnumber, bool waauthed, bool waverified, string email, bool emailauthed, bool emailverified, string fburl, string fbmessengerid, bool fbauthed, bool fbverified, string twitterurl, DateTime lastverified, bool pursue, DateTime lastpinged)
		{
			this.pidenduser = pidenduser;
			this.fname = fname;
			this.lname = lname;
			this.uname = uname;
			this.password = password;
			this.idnumber = idnumber;
			this.cellnumber = cellnumber;
			this.waauthed = waauthed;
			this.waverified = waverified;
			this.email = email;
			this.emailauthed = emailauthed;
			this.emailverified = emailverified;
			this.fburl = fburl;
			this.fbmessengerid = fbmessengerid;
			this.fbauthed = fbauthed;
			this.fbverified = fbverified;
			this.twitterurl = twitterurl;
			this.lastverified = lastverified;
			this.pursue = pursue;
			this.lastpinged = lastpinged;
		}
	}
}
