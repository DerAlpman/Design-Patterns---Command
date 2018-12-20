namespace PrintCommand.Interfaces
{
    /// <summary>
    /// <para>Interface to an employee.</para>
    /// <para>Design pattern role: invoker</para>
    /// </summary>
    internal interface IEmployee
    {
        /// <summary>
        /// <para>Print command for employee.</para>
        /// <para><see cref="IPrintCommand"/></para>
        /// </summary>
        IPrintCommand PrintCommand { get; set; }

        /// <summary>
        /// <para>Method to execute the print command.</para>
        /// <para><see cref="IPrintCommand.Execute(string)"/></para>
        /// </summary>
        /// <param name="document">document to print</param>
        void Print(string document);
    }
}
