using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Coding.Exercise
{
    public class CombinationLock
    {
        private readonly int[] correctCombination;

        public CombinationLock(int[] combination)
        {
            correctCombination = combination;
        }

        public string Status = "LOCKED";

        public void EnterDigit(int digit)
        {
            if (!new Regex("^\\d+$").IsMatch(Status))
            {
                Status = "";
            }
            Status += $"{digit}";
            Console.WriteLine(Status);
            if (string.Join("", correctCombination.Select(v => v.ToString())) == Status)
            {
                Status = "OPEN";
            }
            else if (Status.Length >= correctCombination.Length)
            {
                Status = "ERROR";
            }
        }
    }
}