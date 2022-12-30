using SeriousCompany.Business.FizBuzz.Interfaces.Factories;

namespace SeriousCompany.Business.FizBuzz.Impl.Factories {
    
    /// <summary>
    /// Factory for EnterpriseGradeFizzBuzzSolutionStrategy
    /// </summary>
    public class FizzBuzzSolutionStrategyFactory : IFizzBuzzSolutionStrategyFactory {

        private readonly FizzBuzzSolutionStrategy _fizzBuzzSolutionStrategy;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fizzBuzzSolutionStrategy"></param>
        public FizzBuzzSolutionStrategyFactory(FizzBuzzSolutionStrategy fizzBuzzSolutionStrategy) {
            _fizzBuzzSolutionStrategy = fizzBuzzSolutionStrategy;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public FizzBuzzSolutionStrategy CreateFizzBuzzSolutionStrategy() {
            return this._fizzBuzzSolutionStrategy;
        }
    }
}