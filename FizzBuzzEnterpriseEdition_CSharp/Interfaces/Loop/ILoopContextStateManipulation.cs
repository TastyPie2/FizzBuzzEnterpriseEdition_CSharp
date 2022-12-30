namespace SeriousCompany.Business.FizBuzz.Interfaces.Loop {
    
    /// <summary>
    /// Manipulation for LoopContextState
    /// </summary>
    public interface ILoopContextStateManipulation {
        
        /// <summary>
        /// 
        /// </summary>
        void Start();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool ShouldProceed();
        
        /// <summary>
        /// 
        /// </summary>
        void Proceed();
    }
}