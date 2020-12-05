using DeveloperRepo;
using System;
using System.Collections.Generic;

namespace DevTeamRepo
{
    public class DevTeam
    {
        public string TeamName { get; set; }

        public int TeamID { get; set; }

        public List<Developer> ListOfDevelopers { get; set; } = new List<Developer>();
        
       public DevTeam(string teamName, int teamID)
        {
            TeamName = teamName;
            TeamID = teamID;
            /* Fill list with developer objects*/
            
            
        }
        public DevTeam()
        {

        }
    }
}
