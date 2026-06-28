using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises15Mins;
using Shouldly;

namespace Tests
{
    internal class PasswordValidator60MinsTest
    {
        [Test]
        public void ThrowWhenNull()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string? input = null;

            //act + assert
            Should.Throw<ArgumentException>(() => bl.PassWordValidatorMethod(input));
        }

        [Test]
        public void ReturnFalseWhenEmpty()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string input = "";

            //act
            var result = bl.PassWordValidatorMethod(input);
            //assert
            result.ShouldBeFalse();

        }

        [Test]
        public void ReturnFalseWhen7Chars()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string input = "12345Up";

            //act
            var result = bl.PassWordValidatorMethod(input);
            //assert
            result.ShouldBeFalse();

        }

        [Test]
        public void ReturnTrueWhen8Chars()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string input = "12345Up8";

            //act
            var result = bl.PassWordValidatorMethod(input);
            //assert
            result.ShouldBeTrue();

        }
        [Test]
        public void ReturnFalseWhenNoUpper()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string input = "123456up";

            //act
            var result = bl.PassWordValidatorMethod(input);
            //assert
            result.ShouldBeFalse();

        }

        [Test]
        public void ReturnTrueWhenOneUpper()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string input = "123456Up";

            //act
            var result = bl.PassWordValidatorMethod(input);
            //assert
            result.ShouldBeTrue();

        }

        [Test]
        public void ReturnFalseWhenNoDigits()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string input = "qwertyUi";

            //act
            var result = bl.PassWordValidatorMethod(input);
            //assert
            result.ShouldBeFalse();

        }

        [Test]
        public void ReturnTrueWhenOneDigit()
        {
            //assign
            var bl = new PasswordValidator60Mins();
            string input = "1pppppUp";

            //act
            var result = bl.PassWordValidatorMethod(input);
            //assert
            result.ShouldBeTrue();

        }
    }
}
