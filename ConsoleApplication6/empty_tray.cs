using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class empty_tray    :   Printer
    {
        public void Onempty_tray(object source, EventArgs e)
        {
            Console.WriteLine("empty tray");
        }
    }
}
