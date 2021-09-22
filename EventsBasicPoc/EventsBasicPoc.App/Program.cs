using System;
using System.Threading;
using System.Threading.Tasks;

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

            //custom code example         
            SetInterval(() => printer.Print(), TimeSpan.FromSeconds(2));

            
            //timer example
            var timer1 = new Timer(_ => printer.Print2(), null, 0, 2000);


            Thread.Sleep(TimeSpan.FromMinutes(1));
            Console.ReadLine();
        }

        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);

            action();

            await SetInterval(action, timeout);
        }
    }
}
