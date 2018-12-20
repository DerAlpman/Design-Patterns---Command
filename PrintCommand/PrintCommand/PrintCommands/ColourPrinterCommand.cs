using System;
using PrintCommand.Interfaces;
using PrintCommand.Printer;

namespace PrintCommand.PrintCommands
{
    /// <summary>
    /// <para>Class for colour print commands</para>
    /// </summary>
    internal class ColourPrinterCommand : IPrintCommand
    {
        #region FIELDS

        private ColourPrinter _Printer;

        #endregion

        public ColourPrinterCommand(ColourPrinter printer)
        {
            this._Printer = printer;
        }

        /// <summary>
        /// <see cref="IPrintCommand.Execute(string)"/>
        /// </summary>
        public void Execute(string document)
        {
            Console.WriteLine(string.Format("{0}: Execute command", this.GetType().Name));
            _Printer.Printing(document);
        }
    }
}
