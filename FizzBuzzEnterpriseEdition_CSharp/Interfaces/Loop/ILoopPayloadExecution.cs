namespace SeriousCompany.Business.FizBuzz.Interfaces.Loop {
    
    /// <summary>
    /// Execution for LoopPayload
    /// </summary>
    public interface ILoopPayloadExecution {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateRetrieval"></param>
        void RunLoopPayload(ILoopContextStateRetrieval stateRetrieval);
    }
}