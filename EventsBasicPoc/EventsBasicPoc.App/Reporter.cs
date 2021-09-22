using System;
using System.Collections.Generic;
using System.Text;

namespace EventsBasicPoc.App
{
    public class Reporter
    {
        public void Report(object sender, EventArgs e)
        {
            Console.WriteLine($"Report called.");
        }
    }
}
