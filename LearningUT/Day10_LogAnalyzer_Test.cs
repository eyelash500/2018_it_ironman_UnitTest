using NUnit.Framework;

namespace LearningUT
{
    [TestFixture]
    public class Day10_LogAnalyzer_Test
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            Day10_LogAnalyzer log = new Day10_LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("test.TEST");
            Assert.True(result);
        }
        internal class FakeExtensionManager : IExtensionManager
        {
            public bool WillBeValid = false;
            public bool IsValid(string filename)
            {
                return WillBeValid;
            }
        }
    }
}
