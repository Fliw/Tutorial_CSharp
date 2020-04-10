using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            person Orang = new person("Mahluk",20);
            Orang.GetNameAndAge();
            Teacher Guru = new Teacher("Pak Majid",30,"2888","Komdat");
            Guru.GetNameAndAge();
            student Murid = new student("Rafly",18,"19.11.2888","Fliw@gmail.com");
            Murid.GetNameAndAge();
            Console.ReadKey();
        }
    }
}
