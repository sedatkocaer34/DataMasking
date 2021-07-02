using System;

namespace DataMasking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name =>");
            var nameValue = Console.ReadLine();

            Console.WriteLine("Surname =>");
            var surnameValue = Console.ReadLine();

            var nameMask = StringDataMask.CreateNewMask(nameValue);
            var surNameMask = StringDataMask.CreateNewMask(surnameValue);
            Console.WriteLine("Masking Value =>"+ " " + nameMask + " " + surNameMask);

            Console.WriteLine(DateTimeMask.CreateNewMask(DateTime.Now));
        }
    }
}
