using System;
namespace CalculatorModel
{
    public abstract class Operation
    {
		/// <summary>
        /// O primeiro operando, setado no construtor.
        /// </summary>
        /// <value>A.</value>
		public float A
		{
			get;
			private set;
		}
        /// <summary>
        /// O segundo operando, setado no construtor
        /// </summary>
        /// <value>The b.</value>
        public float B
		{
			get;
			private set;
		}
        /// <summary>
        /// O resultado da operação.
        /// </summary>
        /// <value>The c.</value>
		public float C => Execute(A, B);
        /// <summary>
        /// O método que os herdeiros terão que implementar para definir as operações.
        /// </summary>
        /// <returns>Deve ser o resultado.</returns>
        /// <param name="a">A.</param>
        /// <param name="b">B.</param>
		public abstract float Execute(float a, float b);
        /// <summary>
        /// Construtor, onde A e B são definidos.
        /// </summary>
        /// <param name="a">Operando 1</param>
        /// <param name="b">Operando 2</param>
		public Operation(float a, float b)
        {
			A = a;
			B = b;
        }

    }
}
