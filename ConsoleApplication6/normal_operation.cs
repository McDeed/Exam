using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class normal_operation  :   Printer
    {
        public void Onnormal_operation(object source, EventArgs e)
        {
            Console.WriteLine("everything is O.K");
        }
    }
}
