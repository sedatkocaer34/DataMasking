using System;
using System.Collections.Generic;
using System.Text;

namespace DataMasking
{
    public class StringDataMask
    {


        public static string CreateNewMask(string data,int startIndex = 0)
        {
            var dataLength = GetDataLenght(data);
            var maskingCount = CreateRandomLenght(dataLength,5);
            var mask = Mask(maskingCount, data, startIndex);

            return mask;
        }

        private static string Mask(int maskingCount, string data, int startIndex)
        {
            var maskingSign = '*';
            var mask = string.Concat(data[0], "".PadRight(maskingCount, maskingSign));

            return mask;
        }

        private static int GetDataLenght(string data)
        {
            var length = 0;

            if (!string.IsNullOrEmpty(data))
            {
                length = data.Length;
            }

            return length;
        }

        private static int CreateRandomLenght(int DataSize,int MaxRandomLenght = 4)
        {
            var rndVal = new Random().Next(MaxRandomLenght);
            var maskVal = DataSize + rndVal;

            return maskVal;
        }

    }
}
