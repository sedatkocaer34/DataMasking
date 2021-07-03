using System;

namespace DataMasking
{
    class Program
    {
        static void Main(string[] args)
        {

            #region String Mask
            Console.WriteLine("Name =>");
            var nameValue = Console.ReadLine();

            Console.WriteLine("Surname =>");
            var surnameValue = Console.ReadLine();

            var nameMask = StringDataMask.CreateNewMask(nameValue);
            var surNameMask = StringDataMask.CreateNewMask(surnameValue);
            Console.WriteLine("Masking Value =>" + " " + nameMask + " " + surNameMask);
            #endregion


            #region Date Masking
            Console.WriteLine("Day =>");
            var dayValue = Console.ReadLine();

            Console.WriteLine("Month =>");
            var monthValue = Console.ReadLine();

            Console.WriteLine("Year =>");
            var yearValue = Console.ReadLine();

            var dateResponse = DateTimeMask.CreateNewMask(new DateTime(int.Parse(yearValue), int.Parse(monthValue), int.Parse(dayValue)));
            Console.WriteLine("Masking Date Value =>" + " " + dateResponse);
            #endregion


            Console.Write(CreditCardMasking.CreateNewMask("1234-5678-9101-1121"));
        }
    }
}
