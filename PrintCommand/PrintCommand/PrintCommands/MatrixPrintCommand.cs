using System;
using PrintCommand.Interfaces;
using PrintCommand.Printer;

namespace PrintCommand.PrintCommands
{
    /// <summary>
    /// <para>Class for matrix print commands</para>
    /// </summary>
    internal class MatrixPrintCommand : IPrintCommand
    {
        #region FIELDS

        private MatrixPrinter _Printer;

        #endregion

        public MatrixPrintCommand(MatrixPrinter printer)
        {
            this._Printer = printer;
        }

        #region IPrintCommand

        /// <summary>
        /// <see cref="IPrintCommand.Execute(string)"/>
        /// </summary>
        public void Execute(string document)
        {
            Console.WriteLine(string.Format("{0}: Execute command", this.GetType().Name));
            _Printer.ConfigureCumbersome();
            _Printer.Printing(document);
        }

        #endregion
    }
}
