using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumberConverter.Services;
using RomanNumberConverter.Validator;

namespace RomanNumberConverter.Test
{
    [TestClass]
    public class NumberToRomanTest
    {
        private INumberToRoman _numberToRoman;
        private IProcessor _processor;
        private IInputValidator _inputValidator;
        [TestInitialize]
        public void SetUp()
        {
            _numberToRoman = new NumberToRoman();
            _inputValidator = new InputValidator();
            _processor = new Processor(_numberToRoman, _inputValidator);
            
        }

        [TestMethod]
        public void TestOutputForValidNumber()
        {
            var output = _processor.CallConverter("1234");
            Assert.AreEqual(output, "MCCXXXIV");
        }
    }
}
