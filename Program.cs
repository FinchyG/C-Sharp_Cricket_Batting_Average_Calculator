using System;
using System.Linq;
using System.Collections.Generic;

namespace Cricket_Batting_Average_Calculator
{
    class UserInput
    {
        public string userSeason;
        public decimal season;
        public string userScore;
        public decimal score;
        public List<decimal> battingScores = new List<decimal>();
        public decimal totalScore;
        public string userNotOuts;
        public decimal notOuts;
        public decimal numOuts;
        public double battingAverage;
        
        public decimal SeasonValidator(string seasonStr)
        {
            while (!decimal.TryParse(seasonStr, out decimal x))
            {
                Console.WriteLine("You must input a valid season year:");
                seasonStr = Console.ReadLine();
            }

            return season = Convert.ToDecimal(seasonStr);
        }

        public decimal ScoreValidator(string scoreStr)
        {
            while (!decimal.TryParse(scoreStr, out decimal x))
            {
                Console.WriteLine("You must input a valid score:");
                scoreStr = Console.ReadLine();
            }

            return score = Convert.ToDecimal(scoreStr);
        }

        public decimal NotOutValidator(string notOutsStr)
        {
            while (!decimal.TryParse(notOutsStr, out decimal x))
            {
                Console.WriteLine("You must input a valid number of times you were not out:");
                notOutsStr = Console.ReadLine();
            }

            notOuts = Convert.ToDecimal(notOutsStr);

            //check for whether number of not outs is greater than number of innings

            if(notOuts > battingScores.Count)
            {
                Console.WriteLine("You must input a valid number of times you were not out:");
                NotOutValidator(Console.ReadLine());
            }

            return notOuts;
        }

        public double BattingAverageCalculator()
        {
            totalScore = battingScores.Sum();

            //check whether number of not outs equals number of innings so totalScore is not divided by zero

            if(battingScores.Count == notOuts)
            {
                numOuts = 1;
            }
            else
            {
                numOuts = battingScores.Count - notOuts;
            }
            
            return battingAverage = Math.Round(Convert.ToDouble(totalScore / numOuts),2);
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

            usrinpt.battingAverage = usrinpt.BattingAverageCalculator();

            Console.WriteLine("For the {0} season your batting average was {1}.",usrinpt.season, usrinpt.battingAverage);
        }
    }
}
