using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPool.Example
{
    internal class RequestClient : Client
    {
        public override void Connect()
        {
            Console.WriteLine("Connecting to something with RequestClient...");
        }
    }
}
