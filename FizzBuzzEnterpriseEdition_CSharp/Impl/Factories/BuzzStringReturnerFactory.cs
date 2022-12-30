using SeriousCompany.Business.FizBuzz.Interfaces.Factories;

namespace SeriousCompany.Business.FizBuzz.Impl.Factories {
    /// <summary>
    /// Factory for BuzzStringReturner
    /// </summary>
    public class BuzzStringReturnerFactory : IStringStringReturnerFactory {

        private readonly BuzzStringReturner _myBuzzStringReturner;

        public BuzzStringReturnerFactory(BuzzStringReturner myBuzzStringReturner) {
            _myBuzzStringReturner = myBuzzStringReturner;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public StringStringReturner CreateStringStringReturner() {
            return this._myBuzzStringReturner;
        }
    }
}