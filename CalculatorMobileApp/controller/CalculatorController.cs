using System;
using CalculatorModel.CalculationService;
using CalculatorModel.Operations;

namespace CalculatorMobileApp.controller
{


	public class CalculatorController
    {
		private Operand op1 = new Operand();
		private Operand op2 = new Operand();
		private String chosenOperation;
		private Operand currentOperand;
		public String Operand1 => op1.Value;
		public String Operand2 => op2.Value;
		public String Operation => chosenOperation;
		public CalculatorController()
		{
			currentOperand = op1;
		}
		private bool IsOperator(String c){
			if (c.Equals("+") || c.Equals("-") || c.Equals("/") || c.Equals("*"))
				return true;
			else
				return false;
		}
		private bool IsClear(String c){
			if (c.Equals("C"))
				return true;
			else
				return false;
		}
		private bool IsEnter(String c){
			if (c.Equals("=") && !chosenOperation.Equals(""))
				return true;
			else
				return false;
		}
		private bool IsNumeral(String c){
			if (c.Equals("0") || c.Equals("1") || c.Equals("2") || c.Equals("3") ||
			   c.Equals("4") || c.Equals("5") || c.Equals("6") || c.Equals("7") ||
			    c.Equals("8") || c.Equals("9") || c.Equals("."))
				return true;
			else
				return false;
		}
		private void ExecuteOperation(){
			//Cria o objeto de operação
			OperationFactory factory = new OperationFactory();
			var operationObject = factory.CreateFromStringData(op1.Value, op2.Value, chosenOperation);
			//calcula
			float result = operationObject.C;
			//resultado no operando 1
			op1.SetFromFloat(result);
			//limpa a operaçao
			chosenOperation = "";
			//limpa operando 2
			op2.Clear();
			//operando atual no operando 1
			currentOperand = op1;
		}
		public void PushCharacter(String c){
			//Pode ser numero, decimal, enter, clear ou operador
			//Pode estar sendo posto no 1o operando ou no 2o operando
			if(IsOperator(c)){
				chosenOperation = c;

				    currentOperand = op2;
				return;
			}
			if(IsClear(c)){
				currentOperand.Clear();
				return;
			}
			if(IsEnter(c)){
				ExecuteOperation();
			}
			if (IsNumeral(c)){
				currentOperand.AddCharacter(c);
				return;
			}
		}

		//		private bool alredyUsedDecimal = false;
		//private String firstOperand = "";
		//private String secondOperand = "";
		//private String operation = "";
		//private String accumulator = "";
  //      public String Data
		//{
		//	get { return accumulator; }
		//	private set { accumulator += value; }
		//}

		//public void PushCharacter(String character){
		//	if(character.Equals(".") && alredyUsedDecimal==false){
		//		alredyUsedDecimal = true;
		//		accumulator = accumulator + character;
		//		return;
		//	}         
		//	if(character.Equals("+") && operation.Equals("")){
		//		firstOperand = Data;
		//		operation = "+";
		//		accumulator = "";
		//		return;
		//	}
		//	if (character.Equals("-") && operation.Equals(""))
  //          {
  //              firstOperand = Data;
  //              operation = "-";
		//		accumulator = "";
		//		return;
  //          }
		//	if (character.Equals("*") && operation.Equals(""))
  //          {
  //              firstOperand = Data;
  //              operation = "*";
		//		accumulator = "";
		//		return;
  //          }
		//	if (character.Equals("/") && operation.Equals(""))
  //          {
  //              firstOperand = Data;
  //              operation = "/";
		//		accumulator = "";
		//		return;
  //          }
		//	if(character.Equals("=")&&!operation.Equals("")){
		//		secondOperand = Data;
		//		Data = "";
		//		OperationFactory factory = new OperationFactory();
		//		var op = factory.CreateFromStringData(firstOperand, secondOperand, operation);
		//		firstOperand = accumulator;
		//		operation = "";
		//		accumulator = op.C.ToString();
		//		if (accumulator.Contains("."))
		//			alredyUsedDecimal = true;
		//		else
		//			alredyUsedDecimal = false;
		//		return;
		//	}
		//	accumulator += character;	         
		//}

		//public CalculatorController(){
		//	Data = "";
		//	accumulator = "";
		//	alredyUsedDecimal = false;
		//}
    }
}
