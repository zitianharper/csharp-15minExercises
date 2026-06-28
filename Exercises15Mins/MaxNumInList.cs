using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
    public class MaxNumInList
    {
        /*
         * Return max number in list<int>
         * check for null
         * Create a variable to hold the biggest number
         * Loop through the list, if List[i] > MaxNum 
         * then assign MaxNum to List[i]
         * The list could have negative numbers, so MaxNum can't be 0
         */
        public int MaxNumInListMethod(List<int> Input)
        {
            int maxNum = Input[0];

            if (Input == null)
                throw new Exception("List is null");

            for(int i = 0; i < Input.Count; i++)
            {
                if (Input[i] > maxNum)
                    maxNum = Input[i];
            }
            return maxNum;
            
        }
    }
    /*
     * Does assigning MaxNum to null at the beginning work?
     * Null
     * all Negative ints
     * mix of Neg and Positive ints
     */
}
