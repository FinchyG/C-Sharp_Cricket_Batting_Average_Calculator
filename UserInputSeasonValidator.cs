using System;
public class UserInputSeasonValidator: UserInput
{
    public decimal seasonValidator(string seasonStr)
    {
        while (!decimal.TryParse(seasonStr, out decimal x))
        {
            Console.WriteLine("You must input a valid season year:");
            seasonStr = Console.ReadLine();
        }

        return Season = Convert.ToDecimal(seasonStr);
    }
}