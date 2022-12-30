using SeriousCompany.Business.FizBuzz.Interfaces.Factories;

namespace SeriousCompany.Business.FizBuzz.Impl.Factories {
    public class FizzBuzzOutputGenerationContextVisitorFactory : IOutputGenerationContextVisitorFactory {

        private readonly FizzBuzzOutputGenerationContextVisitor _fizzBuzzOutputGenerationContextVisitor;
        
        
        
        public OutputGenerationContextVisitor CreateVisitor() {
            throw new System.NotImplementedException();
        }
    }
}