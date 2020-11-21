using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example
{
    public class GamerComputerBuilder : ComputerBuilder
    {
        ComputerModel _model;
        public GamerComputerBuilder(ComputerModel model)
        {
            _model = model;

        }
        public override ComputerModel CreateComputer()
        {
           


            return _model;
        }

        public override void CreateDisplayCard()
        {
            _model.DisplayCard = "Rtx 2080 DDR5 8GB 256 Bit";
        }

        public override void CreateProcessor()
        {
            _model.Processor = "Intel i9 9900 4.5 Ghz";
        }

        public override void CreateRam()
        {
            _model.Ram = "16 GB DDR4 3000 Mhz";
        }
    }
}
