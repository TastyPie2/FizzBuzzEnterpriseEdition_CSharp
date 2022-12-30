using SeriousCompany.Business.FizBuzz.Interfaces.StringReturners;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /// <summary>
    /// Factory for StringStringReturner
    /// </summary>
    public interface IStringStringReturnerFactory {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IStringStringReturner CreateStringStringReturner();
    }
}