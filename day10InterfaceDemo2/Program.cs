using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog myDog = new Dog();
            myDog.AnimalSoud();
            myDog.Fly();
            Console.ReadLine();
        }
    }
}
