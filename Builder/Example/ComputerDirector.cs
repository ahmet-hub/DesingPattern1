using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example
{
    public class ComputerDirector
    {
        public ComputerModel CreateComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.CreateProcessor();
            computerBuilder.CreateDisplayCard();
            computerBuilder.CreateRam();
            return computerBuilder.CreateComputer();
           

        }

    }
}
