using System;

namespace LearningUT
{
    class LogAnalyzer
    {
        private Day11_LogAnalyzer_Test.FakeExtensionManager myFakeManager;

        public LogAnalyzer()
        {
        }


        //Struture: 用來帶入的stub。此為UT的時候可以調用的建構式
        public LogAnalyzer(Day11_LogAnalyzer_Test.FakeExtensionManager myFakeManager)
        {
            this.myFakeManager = myFakeManager;
        }

        public static void Main()
        {

        }
        public bool IsValidLogFileName(string fileName)
        {
            //判斷：不分大小寫
            if (!fileName.EndsWith(".log", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }

    }
}
