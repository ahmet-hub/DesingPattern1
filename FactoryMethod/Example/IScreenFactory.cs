using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example
{
    public interface IScreenFactory
    {
        public enum ScreenModel
        {

            Web,
            Mobile,
            Windows
        }

        public IScreen CreateScreen(ScreenModel screenModel);

    }
}
