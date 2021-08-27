namespace Venom.Host.ConsoleApp
{
    using System;
    using Venom.Core.Component.Constructor;


    class Program
    {
        static void Main(string[] args)
        {

            ConstructorContainer.GetInstance().Run();

            Console.ReadKey(false);
        }
    }
}
