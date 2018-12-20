using System;
using PrintCommand.Interfaces;
using PrintCommand.Printer;

namespace PrintCommand.PrintCommands
{
    /// <summary>
    /// <para>Class for matrix print commands</para>
    /// </summary>
    internal class MatrixPrinterCommand : IPrintCommand
    {
        #region FIELDS

        private MatrixPrinter _Printer;

        #endregion

        public MatrixPrinterCommand(MatrixPrinter printer)
        {
            this._Printer = printer;
        }

        /// <summary>
        /// <see cref="IPrintCommand.Execute(string)"/>
        /// </summary>
        public void Execute(string document)
        {
            Console.WriteLine(string.Format("{0}: Execute command", this.GetType().Name));
            _Printer.ConfigureCumbersome();
            _Printer.Printing(document);
        }
    }
}
