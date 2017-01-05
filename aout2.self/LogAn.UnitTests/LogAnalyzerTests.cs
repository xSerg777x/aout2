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
    }
}
