using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStarter
{
    internal class MyFunction
    {
        public static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a != b)
            {
                if (a > b)
                    return UCLN(a - b, b);
                else
                    return UCLN(a, b - a);
            }
            else
                return a;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int NghichDao(int a)
        {
            int result = 0;
            a = Math.Abs(a);
            while (a != 0)
            {
                int digit = a % 10;
                result = result * 10 + digit;
                a /= 10;
            }

            return result;
        }

        public static bool DoiXung(int a)
        {
            int reverse = NghichDao(a);
            if(a == reverse)
                return true;
            else
                return false;
        }

        public static string XoaKhoangTrang(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    result += str[i];
            }
            return result;
        }

        public static char KyTuBenTrai(string str, int n)
        {
            return str[n];

        }

        public static char KyTuBenPhai(string str, int n)
        {
            return str[str.Length - n];
        }
    }
}
