using Prototype.Example;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1,"Laptop",7000);


            var data= product.Clone () as Product;

            Console.WriteLine( data.Equals(product));
        }
    }

















}
