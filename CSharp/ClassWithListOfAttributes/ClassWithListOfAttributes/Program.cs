using System;
using System.Collections.Generic;

namespace ClassWithListOfAttributes
{

    public class Car
    {
        public string Model { get; set; }
        public Attributes Attributes { get; set; }
        public List<ZeroSixtyTimes> ZST { get; set; }

        public Car()
        {
            Attributes = new Attributes();
            ZST = new List<ZeroSixtyTimes>();
        }
    }

    public class Attributes
    {
        public string Colors { get; set; }
        public int WheelCount { get; set; }
    }

    public class ZeroSixtyTimes
    {
        public int Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                Model = "Mustang",
                Attributes =
                {
                    Colors = "Red",
                    WheelCount = 4
                },
                ZST = {
                    new ZeroSixtyTimes() {Time = 6},
                    new ZeroSixtyTimes() {Time = 7}
                }
            };

            Console.WriteLine("Hello World!");
        }
    }
}
