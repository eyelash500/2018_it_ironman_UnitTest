using NUnit.Framework;

namespace LearningUT
{
    class LogAnalyzerTest
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");
            //bool result = analyzer.IsValidLogFileName("filewithbadextension.log");
            Assert.False(result);   //預期：False。當發生非預期，就會Error，表示程式寫錯
        }

        [Test]
        public void IsValidLogFileName_goodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithgoodextension.LOG");
            Assert.True(result);   //預期：True。當發生非預期，就會Error，表示程式寫錯
        }


    }
}
