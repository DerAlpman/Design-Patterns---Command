using System;

namespace EmployeesAndPrinters.Printer
{
    internal class BlackAndWhitePrinter
    {
        internal void Configure()
        {
            Console.WriteLine("Configuring black-and-white printer");
        }

        internal void Printing(string document)
        {
            Console.WriteLine(String.Format("{0}: Printing {1}", typeof(BlackAndWhitePrinter), document));
        }
    }
}
