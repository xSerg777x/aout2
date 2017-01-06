using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        [Ignore("Устарел")]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            var logAnanlyzer = MakeLogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName("dasladlfkj.foo");

            Assert.False(result);
        }

        [Test]
        [Ignore("Устарел")]
        public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        {
            var logAnanlyzer = MakeLogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName("dskaflaskdjf.slf");

            Assert.True(result);
        }

        [Test]
        [Ignore("Устарел")]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            var logAnanlyzer = MakeLogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName("lkadsflajsdf.SLF");

            Assert.True(result);
        }

        private LogAnanlyzer MakeLogAnanlyzer()
        {
            return new LogAnanlyzer();
        }

        [TestCase("lasdkflasdffa.slf", true)]
        [TestCase("ladkjflafsdfj.SLF", true)]
        [TestCase("aksdfasdfasdf.foo", false)]
        public void IsValidLogFileName_VariousExtension_CheckThem(string fileName, bool expected)
        {
            var logAnanlyzer = MakeLogAnanlyzer();

            var result = logAnanlyzer.IsValidLogFileName(fileName);

            Assert.AreEqual(expected, result);
        }

        [TestCase("")]
        [TestCase("   ")]
        [TestCase(null)]
        public void IsValidLogFileName_NullOrWhiteSpaceFileName_ThrowsArgumentException(string fileName)
        {
            var la = MakeLogAnanlyzer();

            var ex = Assert.Catch<ArgumentException>(() => la.IsValidLogFileName(fileName));

            StringAssert.Contains("Необходимо указывать имя файла", ex.Message);
        }
    }
}
