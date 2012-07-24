using System;

namespace SimUDuck.App
{
    class SimUDuckSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulating Mullard Duck... \r\n");
            var mallard = new MullardDuck();
            mallard.Quack();
            mallard.Fly();

            Console.WriteLine("\r\nSimulating Model Duck... \r\n");
            var model = new ModelDuck();
            model.Quack();
            model.Fly();
            Console.Read();
        }
    }
}
