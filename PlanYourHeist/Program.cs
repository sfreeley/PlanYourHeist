using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team();
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine(" 1) Add a Team Member");
                Console.WriteLine(" 2) Print out Team Members");
                Console.WriteLine(" 3) Exit");
                Console.WriteLine();
                Console.Write("> ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Plan Your Heist!");
                        // Console.WriteLine("Enter team name");
                        // string teamName = Console.ReadLine();
                        Console.WriteLine("Enter team member's name");
                        string name = Console.ReadLine();
                        if (name == "")
                        {
                            myTeam.SumOfMembers();
                            myTeam.ListTeamMembers();
                            return;
                            // Console.WriteLine("Menu");
                            // Console.WriteLine(" 1) Add a Team Member");
                            // Console.WriteLine(" 2) Print out Team Members");
                            // Console.WriteLine(" 3) Exit");
                            // Console.WriteLine();
                            // Console.Write("> ");
                        }
                        Console.WriteLine("Enter team member's skill level");
                        string skillLevel = Console.ReadLine();
                        Console.WriteLine("Enter team member's courage factor");
                        string courageFactor = Console.ReadLine();

                        TeamMember aNewTeamMember = new TeamMember(name, skillLevel, courageFactor);
                        myTeam.addTeamMember(aNewTeamMember);
                        break;
                    case "2":
                        myTeam.ListTeamMembers();
                        break;
                    case "3":
                        return;
                    default:
                        // if the "choice" variable didn't match any "case" we inform the user that they
                        //  didn't choose a valid option
                        Console.WriteLine("Invalid Menu Option. You should know better.");
                        break;
                }

                // Console.WriteLine("Plan Your Heist!");
                // Console.WriteLine("Enter team name");
                // string teamName = Console.ReadLine();
                // Console.WriteLine("Enter team member's names");
                // string name = Console.ReadLine();
                // Console.WriteLine("Enter team member's skill level");
                // string skillLevel = Console.ReadLine();
                // Console.WriteLine("Enter team member's courage factor");
                // string courageFactor = Console.ReadLine();

                // Team Cheddar = new Team(teamName);
                // TeamMember Faith = new TeamMember(name, skillLevel, courageFactor);
                // Cheddar.addTeamMember(Faith);
                // calling them with cheddar.ListTeamMembers
                // Cheddar.ListTeamMembers();

            }
        }
    }
}