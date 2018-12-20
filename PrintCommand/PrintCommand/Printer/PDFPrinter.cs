using System;

namespace PrintCommand.Printer
{
    /// <summary>
    /// <para>Design pattern role: receiver</para>
    /// </summary>
    internal class PDFPrinter
    {
        internal void Saving(string document)
        {
            Console.WriteLine(String.Format("{0}: Saving {1}", this.GetType().Name, document));
        }
    }
}
