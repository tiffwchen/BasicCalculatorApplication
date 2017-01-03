using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication2
{
    public class Calculator
    {
        private int firstOperand = 0;
        private int secondOperand = 0;
        private bool secondOperandBeenChanged = false;
        private string inputtedOperator = "";
        private int answer = 0;
        public int FirstOperand { get { return firstOperand; } set { firstOperand = value; } }
        public int SecondOperand { get { return secondOperand; } set { secondOperand = value; } }
        public bool SecondOperandBeenChanged { get { return secondOperandBeenChanged; } set { secondOperandBeenChanged = value; } }
        public string InputtedOperator { get { return inputtedOperator; } set { inputtedOperator = value; } }
        public int Answer { get { return answer; } set { answer = value; } }

        public string Input { get; set; }

        public void UpdateSecondOperand(string numberString)
        {
            secondOperand = Convert.ToInt32(numberString);
            secondOperandBeenChanged = true;
        }

        // update operator variable
        public void UpdateOperator(string operatorString)
        {
            firstOperand = Convert.ToInt32(Input);
            inputtedOperator = operatorString;
        }

        // reset calculator variables
        public void ResetVariables()
        {
            inputtedOperator = "";
            firstOperand = secondOperand = 0;
            secondOperandBeenChanged = false;
        }

        // method that calculates the answer once "=" button is clicked
        public int DoCalculation()
        {
            Operators calcbutton = new Operators();
            answer = calcbutton.Calculation(firstOperand, secondOperand, inputtedOperator);
            return answer;
        }

    }
}
