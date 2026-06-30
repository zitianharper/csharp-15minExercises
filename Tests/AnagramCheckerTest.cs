using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Exercises15Mins;
using Shouldly;

namespace Tests
{
    internal class AnagramCheckerTest
    {
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

Tests
        - Null
        - Empty
        - NotAnagramByOneLetter
        - AnagramWithDifferentNumberOfSpaces
        - AnagramWithDifferentCases
        - Success
 */

        [Test] 
        public void ReturnExceptionWhenNull()
        {
            //assign
            var bl = new AnagramChecker();
            string string1 = null;
            string string2 = "friend";
            //act + assert
            Should.Throw<ArgumentException>(() => bl.AnagramCheckerMethod(string1, string2));
        }

        [Test]
        public void ReturnFalseWhenEmpty()
        {
            var bl = new AnagramChecker();
            string string1 = "";
            string string2 = "";

            var result = bl.AnagramCheckerMethod(string1, string2);

            result.ShouldBeFalse();
        }

        [Test]
        public void ReturnFalseWhenNotAnagramByOneLetter()
        {
            var bl = new AnagramChecker();
            string string1 = "qwerty";
            string string2 = "trewqf";

            var result = bl.AnagramCheckerMethod(string1, string2);

            result.ShouldBeFalse();
        }

        [Test]
        public void ReturnFalseWhenAnagramWithDifferentNumberOfSpaces()
        {
            var bl = new AnagramChecker();
            string string1 = "qw erty";
            string string2 = "ytrewq   ";

            var result = bl.AnagramCheckerMethod(string1, string2);

            result.ShouldBeTrue();
        }

        [Test]
        public void ReturnFalseWhenAnagramWithDifferentCases()
        {
            var bl = new AnagramChecker();
            string string1 = "qwErty";
            string string2 = "ytrewQ";

            var result = bl.AnagramCheckerMethod(string1, string2);

            result.ShouldBeTrue();
        }

        [Test]
        public void ReturnTrueWithAnagram()
        {
            var bl = new AnagramChecker();
            string string1 = "qwerty";
            string string2 = "ytrewq";

            var result = bl.AnagramCheckerMethod(string1, string2);

            result.ShouldBeTrue();
        }
    }
}
