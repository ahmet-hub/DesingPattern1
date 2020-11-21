using System;
using Singleton.Example;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            MySingleton singleton1 = MySingleton.CreateAsSingleton();
            Console.WriteLine( singleton1.GetGuid().ToString());
            MySingleton singleton2= MySingleton.CreateAsSingleton();
            Console.WriteLine(singleton2.GetGuid().ToString());


        }
    }


}


