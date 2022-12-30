using SeriousCompany.Business.FizBuzz.Interfaces.Printers;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /// <summary>
    /// Factory for StringPrinter
    /// </summary>
    public interface IStringPrinterFactory {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>StringPrinter</returns>
        IStringPrinter CreateStringPrinter();
    }
}