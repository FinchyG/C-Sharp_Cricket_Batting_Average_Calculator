using System;
public class UserInputScoresValidator : UserInput
{
    public decimal ScoreValidator(string scoreStr)
    {
        while (!decimal.TryParse(scoreStr, out decimal x))
        {
            Console.WriteLine("You must input a valid score:");
            scoreStr = Console.ReadLine();
        }

        return Score = Convert.ToDecimal(scoreStr);
    }
}