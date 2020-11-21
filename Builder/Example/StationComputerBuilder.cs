using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example
{
    public class StationComputerBuilder : ComputerBuilder
    {
        ComputerModel _model;
        public StationComputerBuilder(ComputerModel model)
        {
            _model = model;
        }
        public override ComputerModel CreateComputer()
        {
            return _model;
        }

        public override void CreateDisplayCard()
        {
            _model.DisplayCard = "PNY Nvidia Quadro RTX 8000 48 GB 448 Bit";
        }

        public override void CreateProcessor()
        {
            _model.Processor = "Amd Ryzen Thredripper 3990X TRX4 2.9 Ghz";
        }

        public override void CreateRam()
        {
            _model.Ram = "256 gb Ram";
        }
    }
}
