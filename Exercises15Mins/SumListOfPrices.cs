using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
    public class SumListOfPrices
    {
        public double SumListOfPricesMethod(List<double> input)
        {
            /*
         * Assuming that the prices do not have currency:
         * intakes List<double> Prices
         * variable to store Total
         * foreach int rice in prices {total += price}
         * Behaviours to Check:
         * Null
         * Prices shouldn't be negative, but check anyway?
         * List of 1
         * Empty List 
        */

            double Total = 0;

            if (input == null)
                throw new ArgumentException("list is null!");

            foreach (double price in input)
                Total += price;

            return Total;

        }
    }
}
