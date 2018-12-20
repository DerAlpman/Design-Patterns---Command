using EmployeesAndPrinters.Printer;

namespace EmployeesAndPrinters.Employees
{
    internal class Secretary
    {
        #region FIELDS

        private BlackAndWhitePrinter _Printer;

        #endregion

        public Secretary(BlackAndWhitePrinter printer)
        {
            this._Printer = printer;
        }

        #region METHODS

        public void Print(string document)
        {
            this._Printer.Configure();
            this._Printer.Printing(document);
        }

        #endregion

    }
}
