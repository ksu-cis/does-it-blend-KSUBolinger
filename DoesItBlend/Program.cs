using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var s = new Strawberry();
            var m = new Mango();
            var c = new IceCubes();
            var cell = new CellPhone();

            Console.WriteLine(b.Blend());
            Console.WriteLine(s.Blend());
            Console.WriteLine(m.Blend());

            List<iBlendable> fruits = new List<iBlendable>() { b, s, m, c, cell};

            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit.GetType());
                Console.WriteLine(fruit.Blend());
            }
        }
    }
}
