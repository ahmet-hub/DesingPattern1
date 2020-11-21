using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example
{
    public abstract class ComputerBuilder
    {
        public abstract void CreateRam();
        public abstract void CreateProcessor();
        public abstract void CreateDisplayCard();
        public abstract ComputerModel CreateComputer();
    }
}
