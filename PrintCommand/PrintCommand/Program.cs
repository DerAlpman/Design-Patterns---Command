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
            IPrintCommand colourPrintCommand = new ColourPrintCommand(cPrinter);
            IPrintCommand matrixPrintCommand = new MatrixPrintCommand(mPrinter);
            IPrintCommand pdfPrintCommand = new PDFPrintCommand(pdfPrinter);

            PrintQueueCommand printQueueCommand = new PrintQueueCommand();
            printQueueCommand.AddCommand(blackAndWhitePrintCommand);
            printQueueCommand.AddCommand(colourPrintCommand);
            printQueueCommand.AddCommand(matrixPrintCommand);
            printQueueCommand.AddCommand(pdfPrintCommand);

            IPrintCommand directorPrintCommand = new DirectorPrintCommand(eva);

            #endregion

            eva.PrintCommand = blackAndWhitePrintCommand;
            eva.Print("Eva's bill");

            Console.WriteLine();

            eva.PrintCommand = colourPrintCommand;
            eva.Print("Eva's bill");

            Console.WriteLine();

            heiko.PrintCommand = pdfPrintCommand;
            heiko.Print("Heiko's source code");

            Console.WriteLine();

            heiko.PrintCommand = matrixPrintCommand;
            heiko.Print("Heiko's source code");

            Console.WriteLine();

            kevin.PrintCommand = printQueueCommand;
            kevin.Print("Kevin's print queue.");

            Console.WriteLine();

            herrSchulte.PrintCommand = directorPrintCommand;
            herrSchulte.Print("Order 666");

            Console.ReadKey();
        }
    }
}
