using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Example
{
    public class MySingleton
    {
        private static MySingleton _singleton;
        private static object _lockObject = new object();
        Guid Guid = new Guid();
        private MySingleton()
        {
            Guid = Guid.NewGuid();

        }

        public static MySingleton CreateAsSingleton()
        {
            if (_singleton == null)
            {
                lock (_lockObject)
                {
                    if (_singleton == null)
                    {
                        _singleton = new MySingleton();
                    }
                }
               
            }

            return _singleton;
        }

        public Guid GetGuid()
        {
            return Guid;
        }
        
        
            
        














    }
}
