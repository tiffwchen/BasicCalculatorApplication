using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Operators: IOperator
    {

        public int Calculation(int operand1, int operand2, string theOperator)
        {
            int answer = 0;
            if (theOperator == "+")
            {
                answer = AddInts(operand1, operand2);
                return answer;
            }
            else if (theOperator == "-")
            {
                answer = SubtractInts(operand1, operand2);
                return answer;
            }
            else if (theOperator == "/")
            {
                answer = DivideInts(operand1, operand2);
                return answer;
            }
            return answer;
        }

        public int AddInts(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int SubtractInts(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public int DivideInts(int operand1, int operand2)
        {
            if (operand2 != 0)
            {
                return operand1 / operand2;
            }
            else
            {
                // right now divide by 0 just returns 0, not entirely accurate
                return 0;
            }

        }
    }
}
