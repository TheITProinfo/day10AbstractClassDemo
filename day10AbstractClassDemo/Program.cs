using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // MobileStorage ms = new UDisk();
            //MobileStorage ms = new ExternalDisk();
            MobileStorage ms = new MP3();
            Computer cpu = new Computer();
            cpu.Ms = ms;
            cpu.CPURead();
            cpu.CPUWrite();

            Console.ReadLine();

        }
    }
}
