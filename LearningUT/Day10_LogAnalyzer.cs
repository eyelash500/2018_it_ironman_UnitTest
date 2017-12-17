namespace LearningUT
{
    class Day10_LogAnalyzer
    {
        private IExtensionManager manager;   
        public Day10_LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);
        }
    }

    //interface: define an adapter.
    public interface IExtensionManager
    {
        bool IsValid(string fileName);
    }


}
