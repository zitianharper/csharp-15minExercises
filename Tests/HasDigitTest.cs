using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Exercises15Mins;


namespace Tests
{
    internal class HasDigitTest
    {
        [Test]
        public void ReturnFalseWhenNoDigit()
        {
            //assign
            var bl = new HasDigit();
            var input = "f";
            //act
            var result = bl.HasDigitMethod(input);
            //assert
            result.ShouldBeFalse();
        }
        [Test]
        public void ReturnFalseWhenEmpty()
        {
            //assign
            var bl = new HasDigit();
            var input = "";
            //act
            var result = bl.HasDigitMethod(input);
            //assert
            result.ShouldBeFalse();
        }
        [Test]
        public void ReturnTrueWhen1Digit()
        {
            //assign
            var bl = new HasDigit();
            var input = "fqef1";
            //act
            var result = bl.HasDigitMethod(input);
            //assert
            result.ShouldBeTrue();
        }
    }
}
