using SeriousCompany.Business.FizBuzz.Interfaces.Strategies;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /**
    * Factory for FizzBuzzOutputStrategy
    */
    public interface IFizzBuzzOutputStrategyFactory {
        /**
	    * @return
	    */
        IFizzBuzzOutputStrategy CreateOutputStrategy();
    }
}