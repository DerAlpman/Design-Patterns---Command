using System.Collections.Generic;
using PrintCommand.Interfaces;

namespace PrintCommand.PrintCommands
{
    /// <summary>
    /// <para>Class to handle many print commands</para>
    /// </summary>
    internal class PrintQueueCommand : IPrintCommand
    {
        #region FIELDS

        private IList<IPrintCommand> _PrintCommands;

        #endregion

        public PrintQueueCommand()
        {
            this._PrintCommands = new List<IPrintCommand>();
        }

        #region IPrintCommand

        public void Execute(string document)
        {
            foreach (IPrintCommand command in _PrintCommands)
            {
                command.Execute(document);
            }
        }

        #endregion

        #region METHODS

        public void AddCommand(IPrintCommand printCommand)
        {
            this._PrintCommands.Add(printCommand);
        }

        #endregion
    }
}
