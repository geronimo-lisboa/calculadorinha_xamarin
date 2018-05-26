using System;
using CalculatorModel.Operations;

namespace CalculatorModel.CalculationService
{
    public class OperationFactory
    {
        public OperationFactory()
        {
        }

		public Operation CreateFromStringData(String A, String B, String op){
			if (op.Equals("*"))
				return new MulOperation(float.Parse(A), float.Parse(B));
			if (op.Equals("/"))
				return new DivOperation(float.Parse(A), float.Parse(B));
			if (op.Equals("+"))
				return new AddOperation(float.Parse(A), float.Parse(B));
			if (op.Equals("-"))
				return new SubOperation(float.Parse(A), float.Parse(B));
			return null;
		}
    }
}
