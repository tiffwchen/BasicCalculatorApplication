using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    interface IOperator
    {
        int AddInts(int operand1, int operand2);
        int SubtractInts(int operand1, int operand2);
        int DivideInts(int operand1, int operand2);
    }
}
