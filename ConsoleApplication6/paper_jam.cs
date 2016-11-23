using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class paper_jam :   Printer
    {
        public void Onpaperjam(object source, EventArgs e)
        {
            Console.WriteLine("paper jam! Stop!");
        }
    }
}
