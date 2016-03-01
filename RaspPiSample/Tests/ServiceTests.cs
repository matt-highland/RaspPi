using System;
using NUnit.Framework;
using RaspPiSample;

namespace Tests
{
    [TestFixture]
    public class ServiceTests
    {
        [TestCase(0,0,0)]
        [TestCase(1, 1, 2)]
        public void DoAddition_returns_expected_results(int a, int b, int expectedResult)
        {
            var service = new Service();
            var result = service.DoAddition(a, b);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
