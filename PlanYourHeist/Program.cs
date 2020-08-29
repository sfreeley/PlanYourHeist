using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanstiating a new Team class
            Team myTeam = new Team();

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine(" 1) Add a Team Member");
                Console.WriteLine(" 2) Run Scenarios");
                Console.WriteLine(" 3) Exit");
                Console.WriteLine();
                Console.Write("> ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Plan Your Heist!");
                        Console.WriteLine("Enter team member's name");
                        string name = Console.ReadLine();
                        if (name == "")
                        {
                            myTeam.SumOfMembers();
                            return;
                        }
                        Console.WriteLine("Enter team member's skill level");
                        string skillLevel = Console.ReadLine();
                        Console.WriteLine("Enter team member's courage factor between 0 and 2");
                        string courageFactor = Console.ReadLine();
                        while (int.Parse(courageFactor) > 2.0 || int.Parse(courageFactor) < 0)
                        {
                            Console.WriteLine("You need to input a number between 0 and 2...");
                            Console.WriteLine("Enter team member's courage factor between 0 and 2");
                            courageFactor = Console.ReadLine();
                        }

                        TeamMember aNewTeamMember = new TeamMember(name, skillLevel, courageFactor);
                        myTeam.addTeamMember(aNewTeamMember);
                        break;

                    case "2":

                        //if skillLevelSum is greater than difficulty level, heist will be successful, otherwise will fail;
                        Console.WriteLine("What is the difficulty of your bank heist?");
                        string difficultyLevel = Console.ReadLine();

                        Console.WriteLine("How many trial runs do you want to run?");
                        string trialRuns = Console.ReadLine();

                        //variables to increment successful and unsuccessful trials
                        int successfulTrials = 0;
                        int unsuccessfulTrials = 0;

                        for (int i = 0; i < int.Parse(trialRuns); i++)
                        {
                            int luckValue = new Random().Next(-10, 11);
                            int difficultyTotal = int.Parse(difficultyLevel) + luckValue;
                            int skillLevelSum = myTeam.SumSkillLevel();

                            Console.WriteLine($"Team's Skill Level: {skillLevelSum}");
                            Console.WriteLine($"Bank's difficulty Level: {difficultyTotal}");

                            if (skillLevelSum >= difficultyTotal)
                            {
                                successfulTrials++;
                                Console.WriteLine("You will succeed in your heist!");
                            }
                            else
                            {
                                unsuccessfulTrials++;
                                Console.WriteLine("Sorry, you will fail and get thrown in jail. Be prepared.");
                            }

                        }
                        Console.WriteLine($"You will be rich {successfulTrials} times out of {trialRuns}; you will go to jail {unsuccessfulTrials} times out of {trialRuns}");

                        break;
                    case "3":
                        return;
                    default:
                        //if didn't choose valid option
                        Console.WriteLine("Invalid Menu Option. Select valid heist planning options.");
                        break;
                }

            }
        }
    }
}