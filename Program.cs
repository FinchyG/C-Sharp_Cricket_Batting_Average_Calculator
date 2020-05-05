using System;
using System.Linq;
using System.Collections.Generic;

namespace Cricket_Batting_Average_Calculator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            UserInputSeasonValidator seasonValidator = new UserInputSeasonValidator();
            UserInputScoresValidator scoreValidator = new UserInputScoresValidator();
            UserInputNotOutValidator notOutValidator = new UserInputNotOutValidator();
            UserInputAverageCalculator averageCalculator = new UserInputAverageCalculator();


            Console.WriteLine("Welcome to your cricket batting average calculator.");
            
            Console.WriteLine("Please enter the season your scores are from:");
            seasonValidator.UserSeason = Console.ReadLine();
            seasonValidator.Season = seasonValidator.seasonValidator(seasonValidator.UserSeason);

            bool addAnotherScore = true;

            while (addAnotherScore)
            {
                Console.WriteLine("Please enter a score:");
                scoreValidator.UserScore = Console.ReadLine();
                scoreValidator.Score = scoreValidator.ScoreValidator(scoreValidator.UserScore);
                averageCalculator.battingScores.Add(scoreValidator.Score);

                Console.WriteLine("Enter a to add another score or any other key to finishing inputting scores:");
                string decision = Console.ReadLine();
                if(decision != "a")
                {
                    addAnotherScore = false;
                }
            }

            Console.WriteLine("How many times were you not out?");
            notOutValidator.UserNotOuts = Console.ReadLine();
            notOutValidator.NotOuts = notOutValidator.NotOutValidator(notOutValidator.UserNotOuts);

            averageCalculator.battingAverage = averageCalculator.BattingAverageCalculator();

            Console.WriteLine("For the {0} season your batting average was {1}.", seasonValidator.Season, averageCalculator.battingAverage);
        }
    }
}
