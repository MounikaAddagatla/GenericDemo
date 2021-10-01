using NUnit.Framework;

namespace GenericsUnitTest
{
    public class Tests
    {

        [Test]
        public void GivenMaxInFirstPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            int a = 50, b = 25, c = 10;
            MaxIntTest maxOfNumber = new MaxIntTest();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(a, actual);
        }
        [Test]
        public void GivenMaxInSecondPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            int a = 10, b = 22, c = 5;
            MaxIntTest maxOfNumber = new MaxIntTest();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(b, actual);
        }
        [Test]
        public void GivenMaxInThirdPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            int a = 10, b = 2, c = 55;
            MaxIntTest maxOfNumber = new MaxIntTest();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(c, actual);
        }
    }
}
