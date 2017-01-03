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
    public class CalculatorTests
    {
        [TestMethod()]
        public void checkInitializedValues()
        {
            Calculator newCalculator = new Calculator();
            Assert.AreEqual(newCalculator.FirstOperand, 0);
            Assert.AreEqual(newCalculator.SecondOperand, 0);
            Assert.AreEqual(newCalculator.SecondOperandBeenChanged, false);
            Assert.AreEqual(newCalculator.InputtedOperator, "");
            Assert.AreEqual(newCalculator.Answer, 0);
        }

        [TestMethod()]
        public void UpdateSecondOperandTest()
        {
            Calculator newCalculator = new Calculator();
            newCalculator.SecondOperand = 55;
            newCalculator.UpdateSecondOperand("34");
            Assert.AreEqual(newCalculator.SecondOperand, 34);
            Assert.AreEqual(newCalculator.SecondOperandBeenChanged, true);
        }

        [TestMethod()]
        public void UpdateOperatorTest()
        {
            Calculator newCalculator = new Calculator();
            newCalculator.InputtedOperator = "+";
            newCalculator.UpdateOperator("-");
            Assert.AreEqual(newCalculator.InputtedOperator, "-");
        }

        [TestMethod()]
        public void DoCalculationTest()
        {
            Calculator newCalculator = new Calculator();
            newCalculator.FirstOperand = 25;
            newCalculator.SecondOperand = 5;
            newCalculator.InputtedOperator = "-";
            newCalculator.Answer = newCalculator.DoCalculation();
            Assert.AreEqual(newCalculator.Answer, 20);
        }
    }
}