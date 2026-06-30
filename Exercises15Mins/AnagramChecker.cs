using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
    public class AnagramChecker
    {
        public bool AnagramCheckerMethod(string string1, string string2)
        {
            if (string1 == null)
                throw new ArgumentException(nameof(string1));

            if (string2 == null)
                throw new ArgumentException(nameof(string2));

            if (string1 == "")
                return false;

            if (string2 == "")
                return false;

            List<char> clean1 = string1.ToLower().Replace(" ", "").ToList<char>();
            List<char> clean2 = string2.ToLower().Replace(" ", "").ToList<char>();

            if (clean1.Count != clean2.Count)
                return false;

            clean1.Sort();
            clean2.Sort();

            for (int i = 0; i < clean1.Count; i++)
            {
                if (clean1[i] != clean2[i])
                    return false;
            }

            return true;
        }
    }
}

/*
 Assumptions and Business Questions
    - Takes 2 strings and return a bool
    - Throw exception if either string is null
    - Return false for empty strings 
    - Ignore spaces
    - No case sensitivity 
    - Anagram - same number of chars in each string 
      and each char is used same number of times

Algorithm
    - Deal with null with throw
    - Deal with empty string with return false
    - .ToLower both strings
    - .Sort both strings 
    - need to match them exactly
    - no need for loop - just return if both are exactly the same
    - Not sure if this ignores spaces - if not, use .Replace() to replace " " with ""
 */