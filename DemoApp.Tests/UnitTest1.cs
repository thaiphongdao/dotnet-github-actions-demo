using NUnit.Framework;

namespace DemoApp.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Math_Should_Add_Correctly()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
        }
    }
}