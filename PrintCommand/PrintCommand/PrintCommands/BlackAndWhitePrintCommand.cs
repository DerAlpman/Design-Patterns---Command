using System;
using PrintCommand.Interfaces;
using PrintCommand.Printer;

namespace PrintCommand.PrintCommands
{
    /// <summary>
    /// <para>Class for black-and-white print commands</para>
    /// </summary>
    internal class BlackAndWhitePrintCommand : IPrintCommand
    {
        #region FIELDS

        private BlackAndWhitePrinter _Printer;

        #endregion

        public BlackAndWhitePrintCommand(BlackAndWhitePrinter printer)
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
            _Printer.Configure();
            _Printer.Printing(document);
        }

        #endregion
    }
}
