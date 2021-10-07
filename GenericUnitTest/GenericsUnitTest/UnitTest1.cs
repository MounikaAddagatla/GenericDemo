using NUnit.Framework;

namespace GenericsUnitTest
{
    public class Tests
    {

        [Test]
        public void GivenMaxInFirstPositin_WhenMaxStringCheck_ThenReturnMax()
        {
            string firstValue = "peach", secondValue = "apple", thirdValue = "banana";
            MaxValueOfString maxOfNumber = new MaxValueOfString();
            var actual = maxOfNumber.Max(firstValue, secondValue, thirdValue);
            Assert.AreEqual(firstValue, actual);
        }
        [Test]
        public void GivenMaxInSecondPositin_WhenMaxStringCheck_ThenReturnMax()
        {
            string firstValue = "apple", secondValue = "peach", thirdValue = "banana";
            MaxValueOfString maxOfNumber = new MaxValueOfString();
            var actual = maxOfNumber.Max(firstValue, secondValue, thirdValue);
            Assert.AreEqual(secondValue, actual);
        }
        [Test]
        public void GivenMaxInThirdPositin_WhenMaxStringCheck_ThenReturnMax()
        {
            string firstValue = "apple", secondValue = "banana", thirdValue = "peach";
            MaxValueOfString maxOfNumber = new MaxValueOfString();
            var actual = maxOfNumber.Max(firstValue, secondValue, thirdValue);
            Assert.AreEqual(thirdValue, actual);
        }
    }
}
