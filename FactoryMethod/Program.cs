using FactoryMethod.Example;
using FactoryMethod.Example2;
using System;
using System.Reflection.Metadata.Ecma335;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenFactory screenFactor = new ScreenFactory();
            screenFactor.CreateScreen(IScreenFactory.ScreenModel.Web).Draw();

            LoggerFactory loggerFactory = new LoggerFactory();
            loggerFactory.CreateLogger(ILoggerFactory.logger.DbLogger).Log();

        }
    }
}
