using NUnit.Framework;

namespace TestDrivenDevelopment.Tests
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void ReturnIsHelloWorld()
        {
            string hello = "HelloWorld";
            Assert.AreEqual("HelloWorld", hello);
        }
    }
}
