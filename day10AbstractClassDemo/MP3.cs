using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10AbstractClassDemo
{
    class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3 is reading data"); ;
        }

        public override void Write()
        {
            Console.WriteLine("MP3 is writing data..."); ;
        }
    }
}
