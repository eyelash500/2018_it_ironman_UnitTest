using System;
using NUnit.Framework;

namespace LearningUT
{
    class Day11_LogAnalyzer_Test
    {
        [Test]
        //增加錯誤的偽造對象來模擬異常
        public void IsValidLogFileName_ExtManagerThrowsException_ReruensFalse()
        {
            //先設定錯誤訊息
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillThrow = new Exception("this is fake");

            //開始測試
            LogAnalyzer log = new LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("Test11.11day"); 
            //雖然說不使用也可以是false，那就不使用吧（此部分與書本不同）
            Assert.False(result);
        }

        internal class FakeExtensionManager: IExtensionManager
        {
            public bool WillBeValid = false;
            public Exception WillThrow = null;

            public bool IsValid(string fileName)
            {
                if (WillThrow != null)
                {
                    throw WillThrow;
                }
                return WillBeValid;
            }
        }
    }
}
