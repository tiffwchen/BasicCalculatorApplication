using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.Tests
{
    [TestClass()]
    public class OperatorsTests
    {
        [TestMethod()]
        public void CalculationTest()
        {
            int firstOperand = 10;
            int secondOperand = 5;
            int expectedAnswer = 0;
            string operatorOne = "~";

            Operators newOperator = new Operators();

            int actualAnswerOne = newOperator.Calculation(firstOperand, secondOperand, operatorOne);
            Assert.AreEqual(expectedAnswer, actualAnswerOne);
        }

        [TestMethod()]
        public void AddIntsTest()
        {
            int firstOperand = 10;
            int secondOperand = 5;
            int expectedAnswerOne = 15;
            string operatorOne = "+";

            Operators newOperator = new Operators();

            int actualAnswerOne = newOperator.Calculation(firstOperand, secondOperand, operatorOne);
            Assert.AreEqual(expectedAnswerOne, actualAnswerOne);

        }

        [TestMethod()]
        public void SubtractIntsTest()
        {
            int firstOperand = 10;
            int secondOperand = 5;
            int expectedAnswerOne = 5;
            string operatorOne = "-";

            Operators newOperator = new Operators();

            int actualAnswerOne = newOperator.Calculation(firstOperand, secondOperand, operatorOne);
            Assert.AreEqual(expectedAnswerOne, actualAnswerOne);
        }

        [TestMethod()]
        public void DivideIntsTest()
        {
            int firstOperand = 10;
            int secondOperand = 5;
            int expectedAnswerOne = 2;
            string operatorOne = "/";

            Operators newOperator = new Operators();

            int actualAnswerOne = newOperator.Calculation(firstOperand, secondOperand, operatorOne);
            Assert.AreEqual(expectedAnswerOne, actualAnswerOne);
        }
    }
}