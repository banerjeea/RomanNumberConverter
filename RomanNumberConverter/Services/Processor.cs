using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumberConverter.Validator;

namespace RomanNumberConverter.Services
{
    public interface IProcessor
    {
        string CallConverter(string num);
    }
    public class Processor : IProcessor
    {
        private readonly INumberToRoman _numberToRoman;
        private readonly IInputValidator _inputValidator;
        private const string InputError = "Input is invalid.";

        public Processor(INumberToRoman numberToRoman, IInputValidator inputValidator)
        {
            _numberToRoman = numberToRoman;
            _inputValidator = inputValidator;
        }
        public string CallConverter(string num)
        {
            var roman = new StringBuilder();
            if (!_inputValidator.Validate(num)) return InputError;
            return _numberToRoman.ConvertToRoman(int.Parse(num), roman).ToString();
        }
    }
}
