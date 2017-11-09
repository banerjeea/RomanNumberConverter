namespace RomanNumberConverter.Validator
{
    public interface IInputValidator
    {
        bool Validate(string input);

    }
    public class InputValidator : IInputValidator
    {
        public bool Validate(string input)
        {
            int output;
            var tryInt = int.TryParse(input, out output);
            if(tryInt && (output > 0 && output < 4000))
              return true;
            return false;
        }
    }
}
