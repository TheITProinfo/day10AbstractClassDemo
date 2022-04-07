using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10AbstractClassDemo
{
    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U disk is reading data ..."); ;
        }

        public override void Write()
        {
            Console.WriteLine(" U disk is writing data......"); ;
        }
    }
}
