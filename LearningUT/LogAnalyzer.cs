using System;

namespace LearningUT
{
    class LogAnalyzer
    {
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
