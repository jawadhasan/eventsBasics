using System;
using System.Collections.Generic;
using System.Text;

namespace EventsBasicPoc.App
{
    public class Printer
    {
        public event EventHandler printed;

        public void Print()
        {
            //simulating work
            for(int i=0;i <3; i++)
            {
                Console.WriteLine($"Preparing...{i}");
            }

            //raise event
            if (printed != null) printed(this,null);
        }
    }
}
