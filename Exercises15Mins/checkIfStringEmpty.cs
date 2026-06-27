using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises15Mins
{


    public class checkIfStringEmpty
    {
        public string input = "hello";

        public bool IsEmpty(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return true;
            }

            return false;
        }
    }
}

/*
 Takes string, returns bool

- Define string
- What is empty? Nothing inside, not null
- .IsNullOrEmpty?
- Problem: IsNullOrEmpty does not differentiate null from empty
- Don't know how to only check for empty

Tests
- Empty state
- Not Empty



 */