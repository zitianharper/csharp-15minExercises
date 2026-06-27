using Shouldly;
using Exercises15Mins;
using System.Reflection.Metadata;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnFalseWhenNotEmpty()
        {
            //assign
            var bl = new checkIfStringEmpty();
            string input = "hello";
            //act
            bool result = bl.IsEmpty(input);
            //assert
            result.ShouldBeFalse();
        }

        [Test]
        public void ReturnTrueWhenEmpty()
        {
            //assign
            var bl = new checkIfStringEmpty();
            string input = "";
            //act
            bool result = bl.IsEmpty(input);
            //assert
            result.ShouldBeTrue();
        }

        [Test]
        public void ReturnTrueWhenNull()
        {
            //assign
            var bl = new checkIfStringEmpty();
            string input = null;
            //act
            bool result = bl.IsEmpty(input);
            //assert
            result.ShouldBeTrue();
        }
    }
}