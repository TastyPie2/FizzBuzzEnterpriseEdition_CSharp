using SeriousCompany.Business.FizBuzz.Interfaces.StringReturners;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /// <summary>
    /// Factory for IntegerStringReturner
    /// </summary>
    public interface IIntegerStringReturnerFactory {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IIntegerStringReturner CreateIntegerStringReturner();
    }
}