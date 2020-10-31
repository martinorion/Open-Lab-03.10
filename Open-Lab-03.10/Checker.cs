using System;
using System.Linq;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {

            return str.Count(a => a == letter);
        }
    }
}
