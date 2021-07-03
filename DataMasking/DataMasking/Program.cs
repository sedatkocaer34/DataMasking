using System;

namespace DataMasking
{
    class Program
    {
        static void Main(string[] args)
        {

            #region String Mask
            var nameMask = StringDataMask.CreateNewMask("Sedat");
            var surNameMask = StringDataMask.CreateNewMask("Kocaer");
            Console.WriteLine("Masking name Value =>" + " " + nameMask + " " + surNameMask);
            #endregion


            #region Date Masking

            var dateResponse = DateTimeMask.CreateNewMask(new DateTime(1997, 06, 06));
            Console.WriteLine("Masking Date Value =>" + " " + dateResponse);
            #endregion

            var creditCardResponse = CreditCardMasking.CreateNewMask("1234-5678-9101-1121");
            Console.Write("Masking Credit Card Value =>" + " " + creditCardResponse);
        }
    }
}
