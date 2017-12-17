using System;
using NUnit.Framework;

namespace LearningUT
{
    //class: the test target.
    class Day13_LogAnalyzer
    {
        private IWebService service;

        //structure: put the interface data to service.
        public Day13_LogAnalyzer(IWebService service)
        {
            this.service = service;
        }

        public void Analyze(string fileName)
        {
            if (!fileName.EndsWith(".log", StringComparison.CurrentCultureIgnoreCase))
            {
                service.LogMessage("false"); 
            }
            else
            {
                service.LogMessage("true");
            }
        }
    }

    #region Mock
    //interface: Web service's message.
    public interface IWebService
    {
        void LogMessage(string message);
    }

    //A fake class.
    public class FakeWebService : IWebService
    {
        public string LastMessage;
        public void LogMessage(string message)
        {
            LastMessage = message;
        }
    }
    #endregion
}
