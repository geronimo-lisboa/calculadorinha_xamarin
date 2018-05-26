using System;
namespace CalculatorModel
{
	public class SubOperation:Operation
    {
    	public SubOperation(float a, float b) : base(a, b)
		{
		}

		public override float Execute(float a, float b)
		{
			return a - b;
		}
	}
}
