using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Example
{
    public abstract class AdventurePrototype
    {
        public abstract AdventurePrototype Clone();
    }

    public class Product : AdventurePrototype
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }

        public Product(int productId,string name, decimal listPrice )
        {
            ProductId = productId;
            Name = name;
            ListPrice = listPrice;

        }

        public override AdventurePrototype Clone()
        {
            return this.MemberwiseClone() as AdventurePrototype;
        }
    }
}
