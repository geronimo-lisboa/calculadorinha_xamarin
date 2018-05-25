using System;
namespace CalculatorModel
{
	public class AddOperation : Operation
	{
		public AddOperation(float a, float b) : base(a, b)
		{
		}

		public override float Execute(float a, float b)
		{
			return a + b;
		}
	}
}
