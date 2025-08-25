using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStarter
{
    internal class OutputFunction
    {
        public static void XuatUCLN(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số nguyên thứ nhất: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số nguyên thứ hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int KetQua = MyFunction.UCLN(a, b);
            Console.WriteLine($"Ước chung lớn nhất của {a} và {b} là: {KetQua}\n\n");
        }

        public static void XuatSwap(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số nguyên thứ nhất: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số nguyên thứ hai: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Trước khi hoán đổi: x = {x}, y = {y}");
            MyFunction.Swap(ref x, ref y);
            Console.WriteLine($"Sau khi hoán đổi: x = {x}, y = {y}\n\n");
        }

        public static void XuatNghichDao(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số nguyên: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int KetQua = MyFunction.NghichDao(n);
            Console.WriteLine($"Nghịch đảo của {n} là: {KetQua}\n\n");
        }

        public static void XuatDoiXung(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int n = Convert.ToInt32(Console.ReadLine());

            if (MyFunction.DoiXung(n))
                Console.WriteLine($"{n} là số đối xứng\n\n");
            else
                Console.WriteLine($"{n} không phải là số đối xứng\n\n");
        }

       public static void XuatXoaKhoangTrang(string[] args)
       {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string str = Console.ReadLine();
            string KetQua = MyFunction.XoaKhoangTrang(str);
            Console.WriteLine($"Chuỗi sau khi xóa khoảng trắng: '{KetQua}'\n\n");
       }

       public static void XuatKyTuBenTrai(string[] args)
       {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            string str = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập thứ tự ký tự bên trái cần lấy: ");
            int n = Convert.ToInt32(Console.ReadLine());

            char KetQua = MyFunction.KyTuBenTrai(str, n);
            Console.WriteLine($"Ký tự bên trái thứ {n}: '{KetQua}'\n\n");
       }
        
       public static void XuatKyTuBenPhai(string[] args)
       {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string str = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập thứ tự ký tự bên phải cần lấy: ");
            int n = Convert.ToInt32(Console.ReadLine());

            char KetQua = MyFunction.KyTuBenPhai(str, n);
            Console.WriteLine($"Ký tự bên phải thứ {n}: '{KetQua}'\n\n");
        }
    }
}
