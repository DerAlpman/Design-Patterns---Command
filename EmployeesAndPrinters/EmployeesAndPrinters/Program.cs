using System;
using EmployeesAndPrinters.Printer;
using EmployeesAndPrinters.Employees;

namespace EmployeesAndPrinters
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlackAndWhitePrinter bawPrinter = new BlackAndWhitePrinter();
            Secretary eva = new Secretary(bawPrinter);

            eva.Print("Secretary's bill");

            Console.WriteLine();

            ColourPrinter cPrinter = new ColourPrinter();
            Director herrSchulte = new Director(cPrinter);

            herrSchulte.Print("Director's order");

            Console.WriteLine();
            
            MatrixPrinter mPrinter = new MatrixPrinter();
            Trainee kevin = new Trainee(mPrinter);

            kevin.Print("Trainee's project");

            Console.WriteLine();

            PDFPrinter pdfPrinter = new PDFPrinter();
            Developer heiko = new Developer(pdfPrinter);

            heiko.Print("Developer's source code");

            Console.ReadKey();
        }
    }
}
