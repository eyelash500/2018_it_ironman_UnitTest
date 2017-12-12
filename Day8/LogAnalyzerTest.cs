using NUnit.Framework;

namespace Day8
{
    class LogAnalyzerTest
    {

        [TestCase("Test.LOG", true)]
        [TestCase("Test.log", true)]
        [TestCase("Test.qoo", false)]
        [TestCase("", false)]   //It will be exception.
        //Name: TargetFunctionName_Factor_ExpectResult()
        public void IsValidLogFileName_WhenCalled_ChangeWasLastFileNameValid(string fileName, bool expectResult)
        {
            LogAnalyzer logAlr = MakeAnalyzer();        //Arrange   //var: the target object.

            logAlr.IsValidLogFileName(fileName);        //Act   //func:Do something and change the system's status.

            Assert.AreEqual(expectResult, logAlr.WasLastFileNameValid); //Assert    //check: the status is correct.
        }

        //func: initalize the class "LogAnalyzer"
        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }
    }
}
