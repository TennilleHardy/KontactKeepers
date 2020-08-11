using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Agent
    {
		private int pidagent;

		public int PIDAgent
		{
			get { return pidagent; }
			set { pidagent = value; }
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
		private int totalhours;

		public int TotalHours
		{
			get { return totalhours; }
			set { totalhours = value; }
		}
		private string agentext;

		public string AgentEXT
		{
			get { return agentext; }
			set { agentext = value; }
		}
		private int avgcalllength;

		public int AVGCallLength
		{
			get { return avgcalllength; }
			set { avgcalllength = value; }
		}
		private int totalcalls;

		public int TotalCalls
		{
			get { return totalcalls; }
			set { totalcalls = value; }
		}
		private int performancescore;

		public int PerformanceScore
		{
			get { return performancescore; }
			set { performancescore = value; }
		}

		public Agent(int pidagent, string fname, string lname, string uname, string password, int totalhours, string agentext, int avgcalllength, int totalcalls, int performancescore)
		{
			this.pidagent = pidagent;
			this.fname = fname;
			this.lname = lname;
			this.uname = uname;
			this.password = password;
			this.totalhours = totalhours;
			this.agentext = agentext;
			this.avgcalllength = avgcalllength;
			this.totalcalls = totalcalls;
			this.performancescore = performancescore;
		}
	}
}
