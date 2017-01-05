using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            var logAnanlyzer = new LogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName("dasladlfkj.foo");

            Assert.False(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            var logAnanlyzer = new LogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName("dskaflaskdjf.slf");

            Assert.True(result);
        }

        [Test]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            var logAnanlyzer = new LogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName("lkadsflajsdf.SLF");

            Assert.True(result);
        }

        [TestCase("lasdkfla.slf", true)]
        [TestCase("ladkjflasdfj.SLF", true)]
        [TestCase("akasdf.foo", false)]
        public void IsValidLogFileName_VariousExtension_CheckThem(string fileName, bool expected)
        {
            var logAnanlyzer = new LogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName(fileName);

            Assert.AreEqual(expected, result);
        }
    }
}
