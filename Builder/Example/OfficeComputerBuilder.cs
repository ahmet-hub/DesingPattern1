using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        private ComputerModel _model;
        public OfficeComputerBuilder(ComputerModel model)
        {
            _model = model;
        }
        public override ComputerModel CreateComputer()
        {
            return _model;
        }

        public override void CreateDisplayCard()
        {
            _model.DisplayCard = "Gtx 1650 4GB";
        }

        public override void CreateProcessor()
        {

            _model.Processor = "Intel i5 9500 3.2 Ghz";

        }

        public override void CreateRam()
        {
            _model.Ram = "8gb DDR 4 2666 Mhz";
        }
    }
}
