using System;
using System.Linq;
using System.Collections.Generic;
public class UserInputAverageCalculator : UserInput
{
    public decimal totalScore;

    public double battingAverage;

    private decimal numOuts;
    public double BattingAverageCalculator()
    {
        totalScore = battingScores.Sum();

        //check whether number of not outs equals number of innings so totalScore is not divided by zero

        if (battingScores.Count == NotOuts)
        {
            numOuts = 1;
        }
        else
        {
            numOuts = battingScores.Count - NotOuts;
        }

        return battingAverage = Math.Round(Convert.ToDouble(totalScore / numOuts), 2);
    }
}