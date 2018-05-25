using System;
namespace CalculatorModel
{
	public class DivOperation:Operation
    {
		public DivOperation(float a, float b) : base(a, b)
		{
		}

		public override float Execute(float a, float b)
		{
			if (Math.Abs(b) > 0)
				return a / b;
			else
				return float.NaN;
		}
	}
}
