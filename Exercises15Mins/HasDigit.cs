using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
    public class HasDigit
    {
        public bool HasDigitMethod(string input)
        {
            char[] cArray = input.ToCharArray();
            int count = 0;

            if (string.IsNullOrEmpty(input))
                return false;

            foreach (char c in cArray)
            {
                if (char.IsDigit(c))
                    count++;
            }
            if (count > 0)
                return true;

            return false;
                
        }
    }

    //return bool - true if string contains at least one digit
    //.Any() and .IsDigit are great for this
    //Using ForEach instead - it is more complicated,
    //because not sure how to use .Any() and IsDigit only works on char
    //


}
