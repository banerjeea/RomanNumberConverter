using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using RomanNumberConverter.Util;

namespace RomanNumberConverter.Services
{
    public interface INumberToRoman
    {
      StringBuilder ConvertToRoman(int number, StringBuilder word);
    }
    public class NumberToRoman : INumberToRoman
    {
        //public StringBuilder ConvertToRoman(int number, StringBuilder word)
        //{
        //    if (number > 0)
        //    {
        //        if (number >= 1000)
        //        {
        //            word.Append("M");
        //            number -= 1000;
        //            ConvertToRoman(number, word);
        //            return word;
        //        }
        //        if (number >= 900)
        //        {
        //            word.Append("CM");
        //            number -= 900;
        //            ConvertToRoman(number, word);
        //            return word;

        //        }
        //        if (number >= 500)
        //        {
        //            word.Append("D");
        //            number -= 500;
        //            ConvertToRoman(number, word);
        //            return word;

        //        }
        //        if (number >= 400)
        //        {
        //            word.Append("CD");
        //            number -= 400;
        //            ConvertToRoman(number, word);
        //            return word;

        //        }
        //        if (number >= 100)
        //        {
        //            word.Append("C");
        //            number -= 100;
        //            ConvertToRoman(number,word);
        //            return word;
        //        }
        //        if (number >= 90)
        //        {
        //            word.Append("XC");
        //            number -= 90;
        //            ConvertToRoman(number, word);
        //            return word;
        //        }
        //        if (number >=  50)
        //        {
        //            word.Append("L");
        //            number -= 50;
        //            ConvertToRoman(number, word);
        //            return word;
        //        }
        //        if (number >= 40)
        //        {
        //            word.Append("XL");
        //            number -= 40;
        //            ConvertToRoman(number, word);
        //            return word;
        //        }
        //        if (number >= 10)
        //        {
        //            word.Append("X");
        //            number -= 10;
        //            ConvertToRoman(number, word);
        //            return word;
        //        }
        //        if (number > 0 && number < 10)
        //        {
        //            word.Append(InTens(number));
        //            return word;
        //        }

        //    }
        //    return word;
        //}

        //private string InTens(int num)
        //{
        //    var dict = new Dictionary<int, string>
        //    {
        //        {1, "I"},
        //        {2, "II"},
        //        {3, "III"},
        //        {4, "IV"},
        //        {5, "V"},
        //        {6, "VI"},
        //        {7, "VII"},
        //        {8, "VIII"},
        //        {9, "IX"}
        //    };

        //    string output;

        //    dict.TryGetValue(num, out output);

        //    return output;
        //}


        //readonly Dictionary<int,string> _allCombinationDict = new Dictionary<int, string>
        //    {
        //        { 1000, "M" } ,
        //        { 900,  "CM" } ,
        //        { 500,  "D" } ,
        //        { 400,  "CD" } ,
        //        { 100,  "C" } ,
        //        { 90,   "XC" } ,
        //        { 50,   "L" } ,
        //        { 40,   "XL" } ,
        //        { 10,   "X" } ,
        //        { 9,    "IX" } ,
        //        { 5,    "V" } ,
        //        { 4,    "IV" } ,
        //        { 1,    "I" } ,
        //    };

        private int _counter = 0;
    

        public StringBuilder ConvertToRoman(int number, StringBuilder word)
        {
            if (number <= 0)
            {
                return word;
            }
            

            var dictkey = Data.AllCombinationDictionary.ElementAt(_counter).Key;
            var dictVal = Data.AllCombinationDictionary.ElementAt(_counter).Value;
            

            if (number >= dictkey)
            {
                word.Append(dictVal);
                number -= dictkey;
                return ConvertToRoman(number, word);
            }
            else
            {
                _counter++;
                return ConvertToRoman(number, word);

            }
        }
    }
}
