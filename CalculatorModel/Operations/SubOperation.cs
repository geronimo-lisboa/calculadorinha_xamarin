using System;
namespace CalculatorModel.Operations
{
	public class SubOperation:Operation
    {
    	public SubOperation(float a, float b) : base(a, b)
		{
		}

		protected override float Execute(float a, float b)
		{
			return a - b;
		}
	}
}
