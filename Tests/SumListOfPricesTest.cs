using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises15Mins;
using Shouldly;

namespace Tests
{
    internal class SumListOfPricesTest
    {

        [Test]
        public void ReturnExceptionWhenNull()
        {
            var bl = new SumListOfPrices();
            List<double>? input = null;

            Should.Throw<ArgumentException>(
                () => bl.SumListOfPricesMethod(input));

        }

        [Test]
        public void Return0WhenEmpty()
        {
            var bl = new SumListOfPrices();
            List<double> input = new List<double> {  };

            var result = bl.SumListOfPricesMethod(input);

            result.ShouldBe(0);

        }

        [Test]
        public void ReturnOnePriceWhenOneInList()
        {
            var bl = new SumListOfPrices();
            List<double> input = new List<double> {1.34};

            var result = bl.SumListOfPricesMethod(input);

            result.ShouldBe(1.34);

        }

        [Test]
        public void ReturnSumWhenMultipleInList()
        {
            var bl = new SumListOfPrices();
            List<double> input = new List<double> { 1.5, 2.55 };

            var result = bl.SumListOfPricesMethod(input);

            result.ShouldBe(4.05);

        }


    }
}
