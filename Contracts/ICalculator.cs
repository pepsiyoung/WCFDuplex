using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Contracts
{
    [ServiceContract(Name = "CalculatorService",CallbackContract = typeof(ICallback))]
    public interface ICalculator
    {
        [OperationContract(IsOneWay = true)]
        void Add(double x, double y);
    }
}
