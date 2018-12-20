using EmployeesAndPrinters.Printer;

namespace EmployeesAndPrinters.Employees
{
    internal class Director
    {
        #region FIELDS

        private ColourPrinter _Printer;

        #endregion

        public Director(ColourPrinter printer)
        {
            this._Printer = printer;
        }

        #region METHODS

        internal void Print(string document)
        {
            this._Printer.Printing(document);
        }

        #endregion
    }
}
