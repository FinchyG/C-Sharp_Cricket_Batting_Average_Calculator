using System;
using System.Linq;
using System.Collections.Generic;

namespace Cricket_Batting_Average_Calculator
{
    abstract class AverageStatement
    {
        public string SeasonAverage(Int16 year, Int16 average)
        {
            return $"For the {year} your batting average was {average}.";
        }
    }

    class UserInput : AverageStatement
    {
        public string userSeason;
        public int season;
        public string userScore;
        public int score;
        public string userNotOuts;
        public int notOuts;
        public int totalScore;
        public List<Int32> battingScores = new List<Int32>();

        public int SeasonValidator(string seasonStr)
        {
            while (!int.TryParse(seasonStr, out int x))
            {
                Console.WriteLine("You must input a valid season year:");
                seasonStr = Console.ReadLine();
            }

            return season = Convert.ToInt16(seasonStr);
        }

        public int ScoreValidator(string scoreStr)
        {
            while (!int.TryParse(scoreStr, out int x))
            {
                Console.WriteLine("You must input a valid score:");
                scoreStr = Console.ReadLine();
            }

            return score = Convert.ToInt32(scoreStr);
        }

        public int NotOutValidator(string notOutsStr)
        {
            while (!int.TryParse(notOutsStr, out int x))
            {
                Console.WriteLine("You must input a valid number of times you were not out:");
                notOutsStr = Console.ReadLine();
            }

            return notOuts = Convert.ToInt32(notOutsStr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserInput usrinpt = new UserInput();


            Console.WriteLine("Welcome to your cricket batting average calculator.");
            
            Console.WriteLine("Please enter the season your scores are from:");
            usrinpt.userSeason = Console.ReadLine();
            usrinpt.season = usrinpt.SeasonValidator(usrinpt.userSeason);

            bool addAnotherScore = true;

            while (addAnotherScore)
            {
                Console.WriteLine("Please enter a score:");
                usrinpt.userScore = Console.ReadLine();
                usrinpt.score = usrinpt.ScoreValidator(usrinpt.userScore);
                usrinpt.battingScores.Add(usrinpt.score);

                Console.WriteLine("Enter a to add another score or any other key to finishing inputting scores:");
                string decision = Console.ReadLine();
                if(decision != "a")
                {
                    addAnotherScore = false;
                }
            }

            Console.WriteLine("How many times were you not out?");
            usrinpt.userNotOuts = Console.ReadLine();
            usrinpt.notOuts = usrinpt.NotOutValidator(usrinpt.userNotOuts);



            usrinpt.totalScore = usrinpt.battingScores.Sum();

            Console.WriteLine(usrinpt.battingScores.Count);

            Console.WriteLine(usrinpt.totalScore);
            
            Console.WriteLine(usrinpt.season);

            Console.WriteLine(usrinpt.notOuts);

            Console.ReadLine();
            
        }
    }
}
