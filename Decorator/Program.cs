using System;
using System.Security.Cryptography.X509Certificates;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalCar personalCar = new PersonalCar { Make = "Bmw", Model = "5.20", HirePrice = 3000 };
            Console.WriteLine(personalCar.HirePrice);
            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            Console.WriteLine(specialOffer.HirePrice);
        }
    }

    public abstract class CarBase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }

    public class PersonalCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    public class CommercialCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    public abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carBase;

        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }

    }

    public class SpecialOffer : CarDecoratorBase
    {
        private readonly CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }
        public override string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override decimal HirePrice
        {
            get
            {
                return _carBase.HirePrice *(decimal)0.90;
            }
            set
            {

            }

        }
    }
}


