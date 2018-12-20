using System;

namespace EmployeesAndPrinters.Printer
{
    internal class PDFPrinter
    {
        internal void Saving(string document)
        {
            Console.WriteLine(String.Format("{0}: Saving {1}", typeof(PDFPrinter), document));
        }
    }
}
