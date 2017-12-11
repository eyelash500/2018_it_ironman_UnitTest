using NUnit.Framework;

namespace LearningUT
{
    class LogAnalyzerTest_TestCase
    {
        [TestCase("WoW.txt")]   //That will be error.
        [TestCase("SUCCESS.LOG")]
        [TestCase("TEST.log")]
        public void IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName(file);
            Assert.True(result);   //預期：True。當發生非預期，就會Error，表示程式寫錯
        }

        
    }
}
