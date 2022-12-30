using SeriousCompany.Business.FizBuzz.Interfaces.Factories;

namespace SeriousCompany.Business.FizBuzz.Impl.Factories {
    
    /// <summary>
    /// Factory for BuzzStrategy
    /// </summary>
    public class BuzzStrategyFactory : IIsEvenlyDivisibleStrategyFactory {
        private readonly BuzzStrategy _buzzStrategy;

        public BuzzStrategyFactory(BuzzStrategy buzzStrategy) {
            _buzzStrategy = buzzStrategy;
        }

        public IsEvenlyDivisibleStrategy CreateIsEvenlyDivisibleStrategy() {
            return this._buzzStrategy;
        }
    }
}