using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class CustomerManager
    {
       private CrossCuttingConcernsFacade _crossCuttingConcernsFacade;

        public CustomerManager(CrossCuttingConcernsFacade crossCuttingConcernsFacade)
        {
            _crossCuttingConcernsFacade = crossCuttingConcernsFacade;
        }

       
        public void Save()
        {
            _crossCuttingConcernsFacade.Authorize.Check();
            _crossCuttingConcernsFacade.Caching.Cache();
            _crossCuttingConcernsFacade.Logger.Log();
        }
    }


    public class CrossCuttingConcernsFacade
    {
        public ILogger Logger;
        public ICaching Caching;
        public IAuthorize Authorize;
        public CrossCuttingConcernsFacade()
        {
            Logger = new EdLogger();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    
    }



    public interface ILogger
    {
        public void Log();
    }
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log with edLogger");
        }
 
    }

    public interface ICaching
    {
        public void Cache();
    }

    public class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    public interface IAuthorize
    {
        public void Check();
    }

    public class Authorize : IAuthorize
    {
        public void Check()
        {
            Console.WriteLine("User checked");
        }
    }
}
