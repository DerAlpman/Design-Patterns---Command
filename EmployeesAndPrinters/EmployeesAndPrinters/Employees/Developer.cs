using EmployeesAndPrinters.Printer;

namespace EmployeesAndPrinters.Employees
{
    internal class Developer
    {
        #region FIELDS

        private PDFPrinter _Printer;

        #endregion

        public Developer(PDFPrinter printer)
        {
            this._Printer = printer;
        }

        #region METHODS

        internal void Print(string document)
        {
            this._Printer.Saving(document);
        }

        #endregion
    }
}
