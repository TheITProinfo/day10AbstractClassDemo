using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10AbstractClassDemo
{
    class Computer
    {
        private MobileStorage _ms;

        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }

        public void CPURead()
        {

            Ms.Read();
        }

        public void CPUWrite()
        {


            Ms.Write();
        }



    }
}
