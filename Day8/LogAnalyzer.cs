using System;

namespace Day8
{
    class LogAnalyzer
    {
        public static void Main(){ }

        public bool WasLastFileNameValid { get; set; }
        public bool IsValidLogFileName(string fileName)
        {
            WasLastFileNameValid = false;   //Modify the system's status.

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("請提供檔名 please provide the filename");
            }

            if(!fileName.EndsWith(".log", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            //Doing the line means everything is correct.
            //Therefore the system's status is "true".
            WasLastFileNameValid = true;        //modify the system's status

            return true;        //means: the function finishes.
        }
    }
}
