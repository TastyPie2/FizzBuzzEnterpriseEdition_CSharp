using SeriousCompany.Business.FizBuzz.Interfaces.Visitors;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Factories {
    
    /// <summary>
    /// Factory for OutputGenerationContextVisitor
    /// </summary>
    public interface IOutputGenerationContextVisitorFactory {
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IOutputGenerationContextVisitor CreateVisitor();
    }
}