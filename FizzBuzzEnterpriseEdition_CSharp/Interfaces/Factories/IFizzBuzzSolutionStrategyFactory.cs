using SeriousCompany.Business.FizBuzz.Interfaces.Strategies;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /// <summary>
    /// Factory for FizzBuzzSolutionStrategy
    /// </summary>
    public interface IFizzBuzzSolutionStrategyFactory {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IFizzBuzzSolutionStrategy CreateFizzBuzzSolutionStrategy();
    }
}