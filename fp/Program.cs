using System;

namespace fp
{
    class Program
    {
        static void Main(string[] args)
        {
            int pil = 0;
            do
            {
                Console.WriteLine("=====Aplikasi Rental Mobil=====\n");
                Console.WriteLine("Login As :\n");
                Console.WriteLine("1.admin");
                Console.WriteLine("2.user");
                Console.WriteLine("3.exit\n");
                Console.WriteLine("Pilihan anda = ");
                pil = Convert.ToInt32(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        admin admins = new admin();
                        break;
                    case 2:
                        user users = new user();
                        break;
                    case 3:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pilihan Anda Salah!");
                        break;
                }
            } while (pil != 3);
        }
    }
}
