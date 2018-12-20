using System;
using PrintCommand.Employees;
using PrintCommand.Interfaces;
using PrintCommand.PrintCommands;
using PrintCommand.Printer;

namespace PrintCommand
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region EMPLOYEES

            Secretary eva = new Secretary();
            Director herrSchulte = new Director();
            Developer heiko = new Developer();
            Trainee kevin = new Trainee();

            #endregion

            #region PRINTER

            BlackAndWhitePrinter bwPrinter = new BlackAndWhitePrinter();
            ColourPrinter cPrinter = new ColourPrinter();
            MatrixPrinter mPrinter = new MatrixPrinter();
            PDFPrinter pdfPrinter = new PDFPrinter();

            #endregion

            #region PRINT COMMANDS

            IPrintCommand blackAndWhitePrintCommand = new BlackAndWhitePrintCommand(bwPrinter);
            IPrintCommand colourPrintCommand = new ColourPrinterCommand(cPrinter);
            IPrintCommand matrixPrintCommand = new MatrixPrinterCommand(mPrinter);
            IPrintCommand pdfPrintCommand = new PDFPrinterCommand(pdfPrinter);

            #endregion

            eva.PrintCommand = blackAndWhitePrintCommand;
            eva.Print("Eva's bill");

            Console.WriteLine();

            eva.PrintCommand = colourPrintCommand;
            eva.Print("Eva's bill");

            Console.WriteLine();

            heiko.PrintCommand = pdfPrintCommand;
            heiko.Print("heiko's source code");

            Console.WriteLine();

            heiko.PrintCommand = matrixPrintCommand;
            heiko.Print("heiko's source code");

            Console.ReadKey();
        }
    }
}
