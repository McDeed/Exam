using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class low_toner :   Printer
    {
        public void Onlow_toner(object source, EventArgs e)
        {
            Console.WriteLine("low toner");
        }
    }
}
