using System;
public class UserInputNotOutValidator : UserInput
{
    public decimal NotOutValidator(string notOutsStr)
    {
        while (!decimal.TryParse(notOutsStr, out decimal x))
        {
            Console.WriteLine("You must input a valid number of times you were not out:");
            notOutsStr = Console.ReadLine();
        }

        NotOuts = Convert.ToDecimal(notOutsStr);

        //check for whether number of not outs is greater than number of innings

        if (NotOuts > battingScores.Count)
        {
            Console.WriteLine("You must input a valid number of times you were not out:");
            NotOutValidator(Console.ReadLine());
        }

        return NotOuts;
    }
}