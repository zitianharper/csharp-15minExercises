using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
    internal class ReverseString
    {
        /* Reverse a string
         * Could make the string into a char array
         * Then push the last char into an empty list
         * Then make that list into a string
         * 
         * for loop to add i into reversedList.
         */
        public string ReverseStringMethod(string input)
        {
            List<char> reversedList = [];

            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Something wrong");

                

            char[] inputArray = input.ToCharArray();

            for(int i = 0; i < inputArray.Length; i++)
            {
                reversedList.Add(inputArray[inputArray.Length - 1 - i]);
            }

            string output = string.Join(", ", reversedList);

            return output;
            
        }
    }
}
/* Testing
 * null
 * empty space
 * string with empty space
 * success
 */