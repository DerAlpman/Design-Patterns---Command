namespace PrintCommand.Interfaces
{
    /// <summary>
    /// <para>Interface to a print command.</para>
    /// <para>Design pattern role: command</para>
    /// </summary>
    public interface IPrintCommand
    {
        /// <summary>
        /// <para>Execute the print command.</para>
        /// </summary>
        /// <param name="document">Document to print</param>
        void Execute(string document);
    }
}
