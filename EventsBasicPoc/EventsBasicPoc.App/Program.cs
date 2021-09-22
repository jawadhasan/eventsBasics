using System;

namespace EventsBasicPoc.App
{
    class Program
    {
        static void Main(string[] args)
        {

            var printer = new Printer();
            var reporter = new Reporter();

            //Handle wiring
            printer.printed += reporter.Report;


            //raise the event
            printer.Print();


            Console.ReadLine();
        }
    }
}
