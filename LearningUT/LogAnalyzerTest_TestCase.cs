using NUnit.Framework;

namespace LearningUT
{
    class LogAnalyzerTest_TestCase
    {
        [TestCase("WoW.txt", false)]   //That will be error.
        [TestCase("SUCCESS.LOG", true)]
        [TestCase("TEST.log", true)]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(file);
            Assert.AreEqual(expected, result);   //預期：True。當發生非預期，就會Error，表示程式寫錯
        }
        
    }
}
