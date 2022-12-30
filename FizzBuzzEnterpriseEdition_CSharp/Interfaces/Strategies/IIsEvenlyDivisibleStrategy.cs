namespace SeriousCompany.Business.FizBuzz.Interfaces.Strategies {
    
    /// <summary>
    /// Strategy for IsEvenlyDivisible
    /// </summary>
    public interface IIsEvenlyDivisibleStrategy {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="theInteger"></param>
        /// <returns></returns>
        bool IsEvenlyDivisible(int theInteger);
    }
}