using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Instagram
{
    class BasicUtilities
    {
        public int[] Convert_Object_To_IntegerArray(string rawData, char splitPointCharacter)
        {
            string[] location = rawData.Split(',');
            int[] array = new int[location.Length];
            for(int i=0; i< location.Length; i++)
            {
                string resultString = Regex.Match(location[i], @"\d+").Value;
                array[i] = Int32.Parse(resultString);
            }
            return array;
        }
    }
}
