using System;
using System.Linq;
using System.Collections.Generic;
using System.Dynamic;

public class UserInput
{
    public string UserSeason { get; set; }
    public decimal Season { get; set; }
    public string UserScore { get; set; }
    public decimal Score { get; set; }
    public string UserNotOuts { get; set; }
    public decimal NotOuts { get; set; }

    public List<decimal> battingScores = new List<decimal>();


}