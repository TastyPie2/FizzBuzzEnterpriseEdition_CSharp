using System;
using System.IO;

namespace SeriousCompany.Business.FizBuzz.Interfaces.Strategies {
    
    /// <summary>
    /// Strategy for FizzBuzzOutput
    /// </summary>
    public interface IFizzBuzzOutputStrategy {
	    
	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="output"></param>
	    void Output(string output);
    }
}