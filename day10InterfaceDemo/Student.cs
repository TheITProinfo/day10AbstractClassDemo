using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10InterfaceDemo
{
    class Student : Person, Developer
    {
        public void WritingCode()
        {
            throw new NotImplementedException();
        }
    }
}
