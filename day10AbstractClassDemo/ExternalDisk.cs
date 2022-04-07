using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10AbstractClassDemo
{
    class ExternalDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("external disk is reading data...."); ;
        }

        public override void Write()
        {
            Console.WriteLine("external disk is writing data.... "); ;
        }
    }
}
