using System;

namespace OOPStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("Nhập hai số nguyên để tìm ước chung lớn nhất ");
            //OutputFunction.XuatUCLN(args);

            //Console.WriteLine("Nhập hai số nguyên để hoán đổi ");
            //OutputFunction.XuatSwap(args);

            //Console.WriteLine("Nhập một số nguyên để nghịch đảo ");
            //OutputFunction.XuatNghichDao(args);

            //Console.Write("Nhập một số nguyên để kiểm tra đối xứng: ");
            //OutputFunction.XuatDoiXung(args);

            Console.Write("Nhập chuỗi để xóa khoảng trắng: ");
            OutputFunction.XuatXoaKhoangTrang(args);

            Console.Write("Nhập chuỗi để lấy ký tự bên trái: ");
            OutputFunction.XuatKyTuBenTrai(args);

            Console.Write("Nhập chuỗi để lấy ký tự bên phải: ");
            OutputFunction.XuatKyTuBenPhai(args);
        }
    }
}