using System;
namespace CalculatorModel
{
	public class MulOperation : Operation
	{
		public MulOperation(float a, float b) : base(a, b)
		{
		}

		public override float Execute(float a, float b)
		{
			return a * b;
		}
	}
}
