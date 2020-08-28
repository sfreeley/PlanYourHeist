using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class Team
    {
        public string name { get; set; }
        public Dictionary<string, TeamMember> Group = new Dictionary<string, TeamMember>();

        //  method
        // adding a team member into the dictionary of the group
        public void addTeamMember(TeamMember newTeamMember)
        {
            Group.Add(newTeamMember.Name, newTeamMember);
        }

        //constructor
        // this is adding a team name 
        // public Team(string name)
        // {
        //     this.name = name;
        // }
        // looping through our dictionary and calling the function print on each method
        public void ListTeamMembers()
        {
            foreach (KeyValuePair<string, TeamMember> member in Group)
            {
                member.Value.print();
            }
        }

        public void SumOfMembers()
        {
            Console.WriteLine($"The Number of Team Members In your group: {Group.Count}");
        }

    }

}