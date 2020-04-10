using System;
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
        public int score;
        public List<Int16> battingAverage = new List<Int16>();

        public int SeasonValidator(string seasonStr)
        {
            while (!int.TryParse(seasonStr, out int x))
            {
                Console.WriteLine("You must input a valid season year:");
                seasonStr = Console.ReadLine();
            }

            return season = Convert.ToInt16(seasonStr);
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

            usrinpt.battingAverage.Add(10);
            usrinpt.battingAverage.Add(15);

            foreach(Int16 score in usrinpt.battingAverage)
            Console.WriteLine(score);
            Console.WriteLine(usrinpt.season);

            Console.ReadLine();
            
        }
    }
}
