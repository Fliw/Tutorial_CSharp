using System;
using System.Threading;

namespace fp
{
    public class admin
    {
        public string username { get; set; }
        public string password { get; set; }
        //create a constructor that get an input and set this class's username & input
        public admin()
        {
            Console.Clear();
            Console.WriteLine("Login as admin:");
            Console.WriteLine("username:");
            this.username = Console.ReadLine();
            Console.WriteLine("password:");
            do
            {
                //method for replace every char in string with asterisk
                ConsoleKeyInfo kunci = Console.ReadKey(true);
                if (kunci.Key != ConsoleKey.Backspace && kunci.Key != ConsoleKey.Enter)
                {
                    this.password += kunci.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (kunci.Key == ConsoleKey.Backspace && this.password.Length > 0)
                    {
                        this.password = this.password.Substring(0, (this.password.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (kunci.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);
            //go to admin check
            adminCheck();
        }
        public void adminCheck()
        {
            //check the credentials
            if (this.username == "fliw" && this.password == "fliw123")
            {
                adminPanel();
            }
            else if (this.username == "fliw" && this.password != "fliw123")
            {
                Console.Clear();
                Console.WriteLine("Password atau username salah!");
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Kredensial tidak ditemukan!");
                return;
            }
        }
        //start the admin panel
        public void adminPanel()
        {
            Console.Clear();
            Console.WriteLine("\nWelcome To ADMIN Panel!");
            Thread.Sleep(1000);
            Console.Clear();
            int pil = 0;
            do
            {
                Console.WriteLine("Main Menu\n");
                Console.WriteLine("1.Manajemen Mobil");
                Console.WriteLine("2.Manajemen Users");
                Console.WriteLine("3.Manajemen Rental");
                Console.WriteLine("4.Exit\n");
                Console.WriteLine("Pilihan Anda:");
                pil = Convert.ToInt32(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                    //redirect to manajemen mobil page
                        manajemenMobil manajemenMobils = new manajemenMobil();
                        break;
                    case 2:
                    //redirect to manajemen user page
                        // manajemenUser manajemenUsers = new manajemenUser();
                        break;
                    case 3:
                    //redirect to manajemen rental page
                        // manajemenRental manajemenRentals = new manajemenRental();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pilihan Anda Salah!");
                        Thread.Sleep(1000);
                        adminPanel();
                        break;
                }
            } while (pil != 4);
        }
    }

}