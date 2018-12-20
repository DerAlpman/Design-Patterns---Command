using System;

namespace PrintCommand.Printer
{
    /// <summary>
    /// <para>Design pattern role: receiver</para>
    /// </summary>
    internal class ColourPrinter
    {
        internal void Printing(string document)
        {
            Console.WriteLine(String.Format("{0}: Printing {1}", this.GetType().Name, document));
        }
    }
}
