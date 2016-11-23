using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Printer
    {
        public bool paper_jam_light, low_toner_light, empty_tray_light, printer_running;
        public int pages_to_print;
        public string status_message;

        public delegate void PrinterEventHandler(object source, EventArgs e);
        public event PrinterEventHandler paper_jam;
        public event PrinterEventHandler empty_tray;
        public event PrinterEventHandler low_toner;
        public event PrinterEventHandler norm_operation;


        public Printer()
        {
            pages_to_print = 0;
        }
        public Printer(int a)
        {
            pages_to_print = a;
        }
        public void decideevent(int a)
        {
            switch (a)
            {
                case 1:
                    Onpaper_jam();
                    break;
                case 2:
                    Onlow_toner();
                    break;
                case 3:
                    Onempty_tray();
                    break;
                case 4:
                    Onnorm_operation();
                    break;

                default:
                    Console.WriteLine("try again");
                    break;
            }
        }

        public static Printer operator +(Printer a, Printer b)
        {
            Printer objsum = new Printer();
            objsum.pages_to_print = a.pages_to_print + b.pages_to_print;
            return objsum;
            
        }
        
        protected virtual void Onpaper_jam()
        {
            if (paper_jam != null)
            {
                paper_jam(this, EventArgs.Empty);
            }
        }
        protected virtual void Onlow_toner()
        {
            if (low_toner != null)
            {
                low_toner(this, EventArgs.Empty);
            }
        }
        protected virtual void Onempty_tray()
        {
            if (empty_tray != null)
            {
                empty_tray(this, EventArgs.Empty);
            }
        }
        protected virtual void Onnorm_operation()
        {
            if (norm_operation != null)
            {
                norm_operation(this, EventArgs.Empty);
            }
        }
    }
}
