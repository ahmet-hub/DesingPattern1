using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example
{
    public class ScreenFactory : IScreenFactory
    {
        public IScreen CreateScreen(IScreenFactory.ScreenModel screenModel)
        {

            switch (screenModel)
            {
                case IScreenFactory.ScreenModel.Web:
                    return new WebScreen();
                case IScreenFactory.ScreenModel.Mobile:
                    return new MobileScreen();
                case IScreenFactory.ScreenModel.Windows:
                    return new WindowsScreen();
                default: throw new Exception(message: "Invalid Model");

            }

        }
    }
}
