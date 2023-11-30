using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._Teamwork_Projects
{
    public class Teams
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public Teams(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }

        public Teams(string creator, string teamName, List<string> members) : this(teamName, creator)
        {
            this.Members = members;

        }

    }
}
