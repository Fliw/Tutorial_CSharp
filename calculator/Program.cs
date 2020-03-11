using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello Devs !";
            Console.WriteLine = "Aplikasi Kalkulator C#";
            Console.WriteLine("Inputkan nilai A = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inputkan nilai B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + tambah(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, kurang(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, kali(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, bagi(a, b));
        }
        static int tambah(int a, int b)
        {
            return a + b;
        }
        static int kurang(int a, int b)
        {
            return a - b;
        }
        static int kali(int a, int b)
        {
            return a * b;
        }
        static int bagi(int a, int b)
        {
            return a / b;
        }
    }
}
