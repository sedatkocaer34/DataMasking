using System;
using System.Collections.Generic;
using System.Text;

namespace DataMasking
{
    public static class CreditCardMasking
    {
        public static string CreateNewMask(string Value,int startlenght=4,int endLenght=2)
        {
            string[] values =  Value.Split('-');
            var newValue = string.Concat(values);
            string returnValue = Mask(newValue, startlenght, endLenght);

            return returnValue;
        }

        public static string Mask(string Value, int startlenght, int endLenght)
        {
            var maskingSign = '*';
            /// Default card number = 16
            int signSize = 16 - (startlenght + endLenght);

            var maskValue = string.Concat(GetStartMaskValue(Value,startlenght), "".PadRight(signSize, maskingSign),GetEndMaskValue(Value,endLenght));
            return maskValue;
        }

        public static string GetStartMaskValue(string Value,int startlenght)
        {
            return Value.Substring(0, startlenght);
        }

        public static string GetEndMaskValue(string Value,int endlenght)
        {
            return Value.Substring((Value.Length-endlenght), endlenght);
        }
    }
}
