using System;

namespace SimUDuck
{
    public class MullardDuck : Duck
    {
        public MullardDuck()
        {
            QuackBehavior = new Quack(); 
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real MallardDuck");
        }
    }
}