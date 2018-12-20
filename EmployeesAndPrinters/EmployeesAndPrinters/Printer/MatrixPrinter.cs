using System;

namespace EmployeesAndPrinters.Printer
{
    internal class MatrixPrinter
    {
        internal void ConfigureCumbersome()
        {
            Console.WriteLine("Configuring matrix printer");
        }

        internal void Printing(string document)
        {
            Console.WriteLine(String.Format("{0}: Printing {1}", typeof(MatrixPrinter), document));
        }
    }
}
