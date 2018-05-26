using System;
namespace CalculatorMobileApp.controller
{
	public class  Operand
        {
            private String value;
            public String Value => value;
            public void AddCharacter(String c)
            {
                if (!c.Equals("."))
                {
                    value += c;
                    return;
                }
                if (c.Equals(".") && !value.Contains("."))
                {
                    value += c;
                    return;
                }
            }
            public void SetFromFloat(float f)
            {
                value = f.ToString();
            }
            public void Clear()
            {
                value = "";
            }

        }
    
}
