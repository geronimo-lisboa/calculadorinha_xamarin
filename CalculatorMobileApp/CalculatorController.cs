using System;
using CalculatorModel.CalculationService;
using CalculatorModel.Operations;

namespace CalculatorMobileApp
{
    public class CalculatorController
    {
		private bool alredyUsedDecimal = false;
		private String firstOperand = "";
		private String secondOperand = "";
		private String operation = "";
		private String accumulator = "";
        public String Data
		{
			get { return accumulator; }
			private set { accumulator += value; }
		}

		public void AccumulateData(String character){
			if(character.Equals(".") && alredyUsedDecimal==false){
				alredyUsedDecimal = true;
				accumulator = accumulator + character;
				return;
			}         
			if(character.Equals("+") && operation.Equals("")){
				firstOperand = Data;
				operation = "+";
				accumulator = "";
				return;
			}
			if (character.Equals("-") && operation.Equals(""))
            {
                firstOperand = Data;
                operation = "-";
				accumulator = "";
				return;
            }
			if (character.Equals("*") && operation.Equals(""))
            {
                firstOperand = Data;
                operation = "*";
				accumulator = "";
				return;
            }
			if (character.Equals("/") && operation.Equals(""))
            {
                firstOperand = Data;
                operation = "/";
				accumulator = "";
				return;
            }
			if(character.Equals("=")&&!operation.Equals("")){
				secondOperand = Data;
				Data = "";
				OperationFactory factory = new OperationFactory();
				var op = factory.CreateFromStringData(firstOperand, secondOperand, operation);
				firstOperand = accumulator;
				operation = "";
				accumulator = op.C.ToString();
				if (accumulator.Contains("."))
					alredyUsedDecimal = true;
				else
					alredyUsedDecimal = false;
				return;
			}
			accumulator += character;	         
		}

		public CalculatorController(){
			Data = "";
			accumulator = "";
			alredyUsedDecimal = false;
		}
    }
}
