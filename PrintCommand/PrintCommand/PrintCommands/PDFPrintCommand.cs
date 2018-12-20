using System;
using PrintCommand.Interfaces;
using PrintCommand.Printer;

namespace PrintCommand.PrintCommands
{
    /// <summary>
    /// <para>Class for colour print commands</para>
    /// </summary>
    internal class PDFPrintCommand : IPrintCommand
    {
        #region FIELDS

        private PDFPrinter _Printer;

        #endregion

        public PDFPrintCommand(PDFPrinter printer)
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
            _Printer.Saving(document);
        }

        #endregion
    }
}
