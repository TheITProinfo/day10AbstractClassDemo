using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10InterfaceDemo2
{
    class Dog : IAnimal, IFlayable
    {
        public void AnimalSoud()
        {
            Console.WriteLine("the dog says: bow bow"); ;
        }
    public void Fly()
        {
        Console.WriteLine("I can fly !!!");
        }

    
    }
}
