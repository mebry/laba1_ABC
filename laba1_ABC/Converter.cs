using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_ABC
{
    public class Converter
    {
        public static string UniversalConver(string number, int fromBase, int toBase)
        {
            string r = "";
            string letter = "0123456789abcdef";
            number = number.ToLower();
            int temp10 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int x = letter.IndexOf(number[i]);
                if (x == -1) throw new Exception(" + number +  числом не является");
                temp10 += x * (int)Math.Pow(fromBase, number.Length - i - 1);
            }
            while (temp10 >= toBase)
            {
                int mod = temp10 % toBase;
                r = r.Insert(0, letter[mod].ToString());
                temp10 /= toBase;
            }
            r = r.Insert(0, letter[temp10].ToString());
            return r;
        }
    }
}
