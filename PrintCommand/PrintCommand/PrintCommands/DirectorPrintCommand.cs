using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintCommand.Interfaces;

namespace PrintCommand.PrintCommands
{
    class DirectorPrintCommand : IPrintCommand
    {
        #region FIELDS

        private IEmployee _Employee;

        #endregion

        public DirectorPrintCommand(IEmployee employee)
        {
            this._Employee = employee;
        }

        #region IPrintCommand

        /// <summary>
        /// <see cref="IPrintCommand.Execute(string)"/>
        /// </summary>
        public void Execute(string document)
        {
            Console.WriteLine(string.Format(
                "{0}: Print '{1}' for me, {2}!", 
                this.GetType().Name,
                document,
                _Employee.GetType().Name));
            _Employee.Print(document);
        }

        #endregion
    }
}
