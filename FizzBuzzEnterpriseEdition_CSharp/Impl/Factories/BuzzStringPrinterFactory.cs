using SeriousCompany.Business.FizBuzz.Interfaces.Factories;

namespace SeriousCompany.Business.FizBuzz.Impl.Factories {
    /// <summary>
    /// Factory for BuzzStringPrinter
    /// </summary>
    public class BuzzStringPrinterFactory : IStringPrinterFactory {
        
        private readonly BuzzStringPrinter _buzzStringPrinter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buzzStringPrinter"></param>
        public BuzzStringPrinterFactory(BuzzStringPrinter buzzStringPrinter) {
            _buzzStringPrinter = buzzStringPrinter;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public StringPrinter CreateStringPrinter() {
            return this._buzzStringPrinter;
        }
    }
}