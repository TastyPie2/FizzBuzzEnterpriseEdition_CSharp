namespace SeriousCompany.Business.FizBuzz.Interfaces.Strategies {
    
    /// <summary>
    /// Strategy for OutputGeneration
    /// </summary>
    public interface IOutputGenerationStrategy {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="generationParameter"></param>
        void PerformGenerationForCurrentStep(ISingleStepOutputGenerationParameter generationParameter);
    }
}