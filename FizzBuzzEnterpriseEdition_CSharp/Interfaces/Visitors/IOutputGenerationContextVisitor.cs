namespace SeriousCompany.Business.FizBuzz.Interfaces.Visitors {
    
    /// <summary>
    /// Visitor for OutputGenerationContext
    /// </summary>
    public interface IOutputGenerationContextVisitor {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="nGenerationParameter"></param>
        void Visit(OutputGenerationContext context, int nGenerationParameter);
    }
}