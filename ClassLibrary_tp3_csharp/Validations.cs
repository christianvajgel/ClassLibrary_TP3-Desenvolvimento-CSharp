using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClassLibrary_tp3_csharp
{
    class Validations
    {
        public static List<bool> StringValidation(string evaluate) {
            List<bool> validations = new List<bool>();

           // new Action(() => { /* do some suck things */ })();
           // int v = new Func<int>(() => { return 123; })();
           
            bool stringOnlyLetters = new Func<bool>(() => { return Regex.IsMatch(evaluate, @"^[a-zA-Z]+$"); })();
            bool stringOnlyDate = new Func<bool>(() => { return Regex.IsMatch(evaluate, @"^[0-9/]+$"); })();
            bool stringOnlyNumber = new Func<bool>(() => { return Regex.IsMatch(evaluate, @"^[0-9]+$"); })();

            validations.Add(stringOnlyLetters);
            validations.Add(stringOnlyDate);
            validations.Add(stringOnlyNumber);

            return validations;
        }
    }
}
