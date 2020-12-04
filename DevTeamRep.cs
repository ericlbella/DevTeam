using DeveloperRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevTeamRepo
{
    public class DevTeamRep
    {
        private List<DevTeam> _listOfDevTeam = new List<DevTeam>();

        //Create
        public void AddDevTeamToList(DevTeam team)
        {
            _listOfDevTeam.Add(team);

        }

        public void AddDeveloperToTeam(Developer programmer, DevTeam team)
        {
            team.ListOfDevelopers.lis .Add(programmer);
        }

        //Read
        public List<DevTeam> GetDevTeamList() 
        {
            return _listOfDevTeam;
        }

        //Update
        public bool UpdateExistingDevTeam(int originalTeamID, DevTeam newTeam)
        {
            // Find the content
            DevTeam oldTeam = GetDevTeamByID(originalTeamID);
            
            // Update the content
            if(oldTeam != null)
            {
                oldTeam.TeamID = newTeam.TeamID;
                oldTeam.TeamName = newTeam.TeamName;
                return true;
            }
            else
            {
                return false;
            }

        }

        //Delete
        public bool RemoveTeamFromList(int teamID)
        {
            DevTeam team = GetDevTeamByID(teamID);

            if (team == null)
            {
                return false;
            }

            int initialCount = _listOfDevTeam.Count;
            _listOfDevTeam.Remove(team);

            if(initialCount > _listOfDevTeam.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public DevTeam GetDevTeamByID(int teamID)
        {
            foreach (DevTeam team in  _listOfDevTeam)
            {
                if (team.TeamID == teamID)
                {
                    return team;
               }

            }

            return null;
        }
    }
  }



