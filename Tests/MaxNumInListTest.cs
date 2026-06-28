using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises15Mins;
using Shouldly;

namespace Tests
{
    public class MaxNumInListTest
    {
        //[Test]
        //public void ReturnFalseWhenNull()
        //{
        //    ////assign
        //    //var bl = new MaxNumInList();
        //    //List<int> input = null;
        //    ////act
        //    //var result = bl.MaxNumInListMethod(input);
        //    ////assert
        //    //result.Should (could not find shouldly for throw exception_
        //}

        [Test]
        public void ReturnMinus1WhenBiggest()
        {
            var bl = new MaxNumInList();
            List<int> input = new List<int> { -1, -2, -5};

            var result = bl.MaxNumInListMethod(input);

            result.ShouldBe(-1);
        }

        [Test]
        public void Return0WhenBiggest()
        {
            var bl = new MaxNumInList();
            List<int> input = new List<int> { -1, -2, 0 };

            var result = bl.MaxNumInListMethod(input);

            result.ShouldBeEquivalentTo(0);
        }

        [Test]
        public void ReturnOnly1Number()
        {
            var bl = new MaxNumInList();
            List<int> input = new List<int> { 1 };

            var result = bl.MaxNumInListMethod(input);

            result.ShouldBeEquivalentTo(1);
        }

        [Test]
        public void ReturnBiggestWhenMixedNegativePositiveNums()
        {
            var bl = new MaxNumInList();
            List<int> input = new List<int> { -1, -2, 5 };

            var result = bl.MaxNumInListMethod(input);

            result.ShouldBeEquivalentTo(5);
        }

    }
}
/*
     * Does assigning MaxNum to null at the beginning work?
     * Null
     * all Negative ints
     * mix of Neg and Positive ints
     */