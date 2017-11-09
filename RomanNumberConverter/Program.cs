using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumberConverter.Services;
using RomanNumberConverter.Validator;

namespace RomanNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number : ");
            var number = Console.ReadLine();


            INumberToRoman numberToRoman = new NumberToRoman();
            IInputValidator inputValidator = new InputValidator();
            IProcessor processor = new Processor(numberToRoman,inputValidator);

            var roman = processor.CallConverter(number);
            
            Console.WriteLine("After Conversation : "+ roman);
            Console.ReadKey();
        }

    }
}
