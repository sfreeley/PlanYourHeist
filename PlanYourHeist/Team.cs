using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    public class Team
    {
        public Dictionary<string, TeamMember> Group = new Dictionary<string, TeamMember>();

        //  method
        // adding a team member into the dictionary of the group
        public void addTeamMember(TeamMember newTeamMember)
        {
            Group.Add(newTeamMember.Name, newTeamMember);
        }

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

        //getting sum of dictionary for property of SkillLevel

        public int SumSkillLevel()
        {

            return Group.Sum(member => member.Value.SkillLevel);

        }

    }

}