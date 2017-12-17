using NUnit.Framework;

namespace LearningUT
{
    class Day13_LogAnalyzer_Test
    {
        [Test]
        public void LogAnalyze_NameSupportedExtension_CallWebservice()
        {
            FakeWebService mokeSample = new FakeWebService();
            Day13_LogAnalyzer log = new Day13_LogAnalyzer(mokeSample);

            //log.Analyze("test_false.false");  //it will be error shows false
            log.Analyze("test_true.log");       //it will be ture shows true

            StringAssert.Contains("true", mokeSample.LastMessage);
        }
    }
}
