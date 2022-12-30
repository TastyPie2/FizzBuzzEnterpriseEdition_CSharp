using SeriousCompany.Business.FizBuzz.Interfaces.Printers;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /// <summary>
    /// Factory for IntegerPrinter
    /// </summary>
    public interface IIntegerPrinterFactory {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IIntegerPrinter CreatePrinter();
    }
}