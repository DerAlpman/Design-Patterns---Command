using EmployeesAndPrinters.Printer;

namespace EmployeesAndPrinters.Employees
{
    internal class Trainee
    {
        #region FIELDS

        private MatrixPrinter _Printer;

        #endregion

        public Trainee(MatrixPrinter printer)
        {
            this._Printer = printer;
        }

        #region METHODS

        public void Print(string document)
        {
            this._Printer.ConfigureCumbersome();
            this._Printer.Printing(document);
        }

        #endregion

    }
}
