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


            //raise the event
            printer.Print();

            //Built-in timer example
            //Just make sure you're timers don't go out of scope and get disposed.
            var timer1 = new Timer(_ => Console.WriteLine("Hello World-Timer"), null, 0, 2000);
            var timer2 = new Timer(_ => printer.Print(), null, 0, 2000);

            //custom code example
            SetInterval(() => Console.WriteLine("Hello World"), TimeSpan.FromSeconds(2));
            SetInterval(() => printer.Print(), TimeSpan.FromSeconds(4));




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
