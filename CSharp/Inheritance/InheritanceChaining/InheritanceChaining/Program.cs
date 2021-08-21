using System;

namespace InheritanceChaining
{
    public class Animal
    {
        public bool IsAlive { get; set; }
    }

    public class Mammal : Animal
    {
        public bool HasHair { get; set; }
    }

    public class Lion : Mammal
    {
        public bool HasClaws { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.IsAlive = true;

            Mammal m = new Mammal();
            m.IsAlive = true;
            m.HasHair = true;

            Lion l = new Lion();
            l.IsAlive = true;
            l.HasHair = true;
            l.HasClaws = true;            
        }
    }
}
