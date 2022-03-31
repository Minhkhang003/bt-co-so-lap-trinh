using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float Toan, Tinhoc, Ngoaingu;
            Console.WriteLine("nhap diem toan");
            Toan = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem tin");
            Tinhoc = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ngoai ngu");
            Ngoaingu = float.Parse(Console.ReadLine());

            Console.WriteLine("Loai: " + xepLoai(Toan, Tinhoc, Ngoaingu));
        }

        static string xepLoai(float Toan, float Tinhoc, float Ngoaingu )
        {
            float diemTB = (Toan + Tinhoc + Ngoaingu) / 3;
            Console.WriteLine($"diem trung binh: {diemTB");
            if (diemTB >= 8 && Toan >= 8 && Tinhoc >= 8 && Ngoaingu >= 8)
                return ("gioi");
            else if (diemTB >= 7 && Toan >= 7 && Tinhoc >= 7 && Ngoaingu >= 7)
                return "kha";
            else if (diemTB >= 6 && diemTB < 7)
                return "trung binh kha";
            else if (diemTB >= 6)
                return "trung binh";
            else
                return "kem";
        }
        
    }
}
