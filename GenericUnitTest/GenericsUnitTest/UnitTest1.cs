using NUnit.Framework;

namespace GenericsUnitTest
{
    public class Tests
    {

        [Test]
        public void GivenMaxInFirstPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            float a = 10.4f, b = 2f, c = 5f;
            MaxDoubleTest maxOfNumber = new MaxDoubleTest();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(a, actual);
        }
        [Test]
        public void GivenMaxInSecondPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            float a = 10f, b = 22.21f, c = 5.324f;
            MaxDoubleTest maxOfNumber = new MaxDoubleTest();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(b, actual);
        }
        [Test]
        public void GivenMaxInThirdPositin_WhenMaxNumberCheck_ThenReturnMax()
        {
            float a = 10.214f, b = 2.3983f, c = 55.213f;
            MaxDoubleTest maxOfNumber = new MaxDoubleTest();
            var actual = maxOfNumber.Max(a, b, c);
            Assert.AreEqual(c, actual);
        }
    }
}
