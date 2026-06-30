using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises15Mins;
using Shouldly;

//READ:
//Read the question incorrectly - checked for duplicates when should've been testing for non duplicates. 
//The code and tests have been refactored, except for the test names, which remained as duplicates
namespace Tests
{
    internal class FirstNonRepeatingCharTest
    {
        [Test]
        public void ThrowWhenNull()
        {
            //assign
            var bl = new FirstNonRepeatingChar();
            string input = null;
            //act & assert
            Should.Throw<ArgumentException>(() => bl.FirstNonRepeatingCharMethod(input));
        }

        [Test]
        public void ReturnPleasefillinputWhenInputEmpty()
        {
            //assign
            var bl = new FirstNonRepeatingChar();
            string input = "";
            //act
            string result = bl.FirstNonRepeatingCharMethod(input);
            //assert
            result.ShouldBe("Please fill input");
        }

        [Test]
        public void ReturnCharInsteadOfWhiteSpace()
        {
            //assign
            var bl = new FirstNonRepeatingChar();
            string input = " hllo";
            //act
            string result = bl.FirstNonRepeatingCharMethod(input);
            //assert
            result.ShouldBe("h");
        }

        [Test]
        public void ReturnWhenCaseInsensitive()
        {
            //assign
            var bl = new FirstNonRepeatingChar();
            string input = " heLlo";
            //act
            string result = bl.FirstNonRepeatingCharMethod(input);
            //assert
            result.ShouldBe("h");
        }

        [Test]
        public void ReturnFirstInstanceOfDuplicate()
        {
            //assign
            var bl = new FirstNonRepeatingChar();
            string input = "hello ff";
            //act
            string result = bl.FirstNonRepeatingCharMethod(input);
            //assert
            result.ShouldBe("h");
        }

        [Test]
        public void ReturnDuplicate()
        {
            //assign
            var bl = new FirstNonRepeatingChar();
            string input = "hello";
            //act
            string result = bl.FirstNonRepeatingCharMethod(input);
            //assert
            result.ShouldBe("h");
        }
    }
}

/*
 * Test for
    ThrowWhenNull
    Return"Please fill input"WhenInputEmpty
    ReturnCharInsteadOfWhiteSpace
    ReturnFirstInstanceOfDuplicate
    Success
    
 */