using System;

namespace fp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int pil = 0;
            //loop
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
                    //redirect to admin role
                        admin admins = new admin();
                        break;
                    case 2:
                    //redirect to user role
                        user users = new user();
                        break;
                    case 3:
                    //out from loop (exit)
                        return;
                    default:
                    //back to top
                        Console.Clear();
                        Console.WriteLine("Pilihan Anda Salah!");
                        break;
                }
            } while (pil != 3);
        }
    }
}
