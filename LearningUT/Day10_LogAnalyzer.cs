namespace LearningUT
{
    class Day10_LogAnalyzer
    {
        private IExtensionManager manager;   
        public Day10_LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }
        //public class FileExtensionManager : IExtensionManager
        //{
        //    public bool IsValid(string fileName)
        //    {
        //        return true;
        //    }
            
        //}

        public bool IsValidLogFileName(string fileName)
        {
            //IExtensionManager mgr = new FileExtensionManager();
            return manager.IsValid(fileName);
            //return mgr.IsValid(fileName);
        }
    }
    //interface: define an adapter.
    public interface IExtensionManager
    {
        bool IsValid(string fileName);
    }


}
