﻿using PrintCommand.Interfaces;

namespace PrintCommand.Employees
{
    internal class Director : IEmployee
    {
        #region FIELDS

        private IPrintCommand _PrintCommand;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// <see cref="IEmployee.PrintCommand"/>
        /// </summary>
        public IPrintCommand PrintCommand
        {
            get
            {
                return _PrintCommand;
            }
            set
            {
                _PrintCommand = value;
            }
        }

        #endregion

        #region IEmployee

        /// <summary>
        /// <see cref="IEmployee.Print(string)"/>
        /// </summary>
        /// <param name="document"></param>
        public void Print(string document)
        {
            this._PrintCommand.Execute(document);
        }

        #endregion
    }
}
