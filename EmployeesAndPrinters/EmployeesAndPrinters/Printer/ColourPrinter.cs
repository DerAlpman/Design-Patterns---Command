using System;

namespace EmployeesAndPrinters.Printer
{
    internal class ColourPrinter
    {
        internal void Printing(string document)
        {
            Console.WriteLine(String.Format("{0}: Printing {1}", typeof(ColourPrinter), document));
        }
    }
}
