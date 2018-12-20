﻿using System;
using PrintCommand.Interfaces;
using PrintCommand.Printer;

namespace PrintCommand.PrintCommands
{
    /// <summary>
    /// <para>Class for colour print commands</para>
    /// </summary>
    internal class PDFPrinterCommand : IPrintCommand
    {
        #region FIELDS

        private PDFPrinter _Printer;

        #endregion

        public PDFPrinterCommand(PDFPrinter printer)
        {
            this._Printer = printer;
        }

        /// <summary>
        /// <see cref="IPrintCommand.Execute(string)"/>
        /// </summary>
        public void Execute(string document)
        {
            Console.WriteLine(string.Format("{0}: Execute command", this.GetType().Name));
            _Printer.Saving(document);
        }
    }
}
