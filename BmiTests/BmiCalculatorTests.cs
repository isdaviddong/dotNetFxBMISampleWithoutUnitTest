using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bmi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi.Tests
{
    [TestClass()]
    public class BmiCalculatorTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            //arrange
            BmiCalculator bmi = new BmiCalculator();
            bmi.Height = 170;
            bmi.Weight = 70;

            //act
            float result = bmi.Calculate();

            //assert
            Assert.AreEqual("24.22", result.ToString("00.00"));
        }
    }
}