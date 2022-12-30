using System;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Printers {
    
    /// <summary>
    /// Printer for Data
    /// </summary>
    public interface IDataPrinter {

        /// <summary>
        /// 
        /// </summary>
        void Print();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        void PrintValue(object value);
    }
}