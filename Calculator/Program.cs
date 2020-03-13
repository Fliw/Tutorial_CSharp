using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{    
    class Program
    {
        static void Main(string[] args) //start the apps
        {
            Console.Title = "Hello Devs !";
            //output like echo / cout
            Console.WriteLine("Aplikasi Kalkulator C#\n");
            Console.WriteLine("A. Pertambahan\n");
            Console.WriteLine("B. Pengurangan\n");
            Console.WriteLine("C. Perkalian\n");
            Console.WriteLine("D. Pembagian\n");
            Console.WriteLine("Pilih = ");
            //input from user
            string isi = Console.ReadLine();
            //control flow
            if((isi == "A")||(isi == "a")){
                Console.WriteLine("Pertambahan \n");
                Console.WriteLine("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2} ", a, b, tambah(a, b));
            }
            else if((isi == "B")||(isi == "b")){
                Console.WriteLine("Pengurangan \n");
                Console.WriteLine("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, kurang(a, b));
            }
            else if((isi == "C")||(isi == "c")){
                Console.WriteLine("Perkalian \n");
                Console.WriteLine("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, kali(a, b));
            }
            else if((isi == "D")||(isi == "d")){
                Console.WriteLine("Pembagian \n");
                Console.WriteLine("Inputkan nilai A = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai B = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, bagi(a, b));
            }
            //if there is not match
            else{
                Console.WriteLine("OPSI TIDAK ADA !\n");
            }
        }
        //a function outside main that return value based on operator and name
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
