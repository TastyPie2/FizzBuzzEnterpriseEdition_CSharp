using SeriousCompany.Business.FizBuzz.Interfaces.Strategies;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /// <summary>
    /// Factory for IsEvenlyDivisibleStrategy
    /// </summary>
    public interface IIsEvenlyDivisibleStrategyFactory {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IIsEvenlyDivisibleStrategy CreateIsEvenlyDivisibleStrategy();
    }
}