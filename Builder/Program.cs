using Builder.Example;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductDirector productDirector = new ProductDirector();
            //var builder = new OldCustomerProductBuilder();
            //productDirector.GenerateProduct(builder);
            //var model = builder.GetProduct();

            //Console.WriteLine(model.Id);
            //Console.WriteLine(model.CategoryName);
            //Console.WriteLine(model.ProductName);
            //Console.WriteLine(model.UnitPrice);
            //Console.WriteLine(model.DiscountedPrice);
            //Console.WriteLine(model.DiscountApplied);






            ComputerDirector computer = new ComputerDirector();
            var computerModel = computer.CreateComputer(new StationComputerBuilder(new ComputerModel()));

            Console.WriteLine(computerModel.Processor);
            Console.WriteLine(computerModel.DisplayCard);
            Console.WriteLine(computerModel.Ram);
             






        }
    }
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }

    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetProduct();


    }

    public class NewCustomerProductBuilder : ProductBuilder

    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice * (decimal)0.90;
            model.DiscountApplied = true;
        }

        public override ProductViewModel GetProduct()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Laptop";
            model.ProductName = "Abra A5 V15.2";
            model.UnitPrice = 7000;

        }
    }

    public class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice;
            model.DiscountApplied = false;
        }
        public override ProductViewModel GetProduct()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Laptop";
            model.ProductName = "Abra A5 V15.2";
            model.UnitPrice = 7000;
        }
    }


    public class ProductDirector
    {

        public void GenerateProduct(ProductBuilder productBuilder)

        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
            productBuilder.GetProduct();
        }

    }



}






