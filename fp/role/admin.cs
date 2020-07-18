using System;
namespace fp
{
    public class admin
    {
        public string username { get; set; }
        public string password { get; set; }
        public admin()
        {
            Console.Clear();
            Console.WriteLine("Login as admin:");
            Console.WriteLine("username:");
            this.username = Console.ReadLine();
            Console.WriteLine("password:");
            do
            {
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

            adminCheck();
        }
        public void adminCheck()
        {
            if (this.username == "fliw" && this.password == "fliw123")
            {
                adminPanel();
            }
            else if (this.username == "fliw" && this.password != "fliw123")
            {
                Console.WriteLine("Password atau username salah!");
                return;
            }
            else
            {
                Console.WriteLine("Kredensial tidak ditemukan!");
                return;
            }
        }
        public void adminPanel(){
            Console.WriteLine("admin Panel");
        }
    }

}