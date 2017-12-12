using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Complexity
{
    public class StringFunctions
    {

        private readonly string[] _curseWords = {"poo", "numpty", "silly billy", "fiddlesticks"};

        public string DeprofanedBackwardsToLowerCaseTrimmed(string input)
        {
            input = ToLower(input);

            foreach (var word in _curseWords)
            {
                input = Regex.Replace(input, word, "XXXX", RegexOptions.IgnoreCase);
            }

            input = new string(input.Reverse().ToArray());

            return input.Trim();

        }

        private string ToLower(string input)
        {
            return input.ToLower();
        }
    }
}

