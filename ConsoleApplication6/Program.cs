using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        bool paper_jam_light, low_toner_light, empty_tray_light, printer_running;
        int pages_to_print;
        string status_message;

        
        static void Main(string[] args)
        {

            var obj1 = new Printer(4);
            var obj2 = new Printer(2);
            var ev1 = new normal_operation();
            var ev2 = new empty_tray();
            var ev3 = new paper_jam();
            var ev4 = new low_toner();
            int a;
            Console.WriteLine("Obj1 pages to print:{0}\tObj2 pages to print:{1}", obj1.pages_to_print, obj2.pages_to_print);
            var obj3 = obj1 + obj2;
            Console.WriteLine("number of pages to print: {0}", obj3.pages_to_print);
            obj3.paper_jam += ev3.Onpaperjam;
            obj3.norm_operation += ev1.Onnormal_operation;
            obj3.empty_tray += ev2.Onempty_tray;
            obj3.low_toner += ev4.Onlow_toner;

            Console.WriteLine("Enter:\n1 for paper jam\n2for low toner\n3 for empty tray\n4for normal printing\n5 to quit");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                a = 0;
                
            }
            //int a = Convert.ToInt32(Console.ReadLine());
            while (a!=5)
            {
                obj3.decideevent(a);
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    a = 0;

                }
            }
        

            //a=obj1.pages_to_print;
        }
    }
}
