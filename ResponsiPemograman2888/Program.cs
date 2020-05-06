using System;

namespace ResponsiPemograman2888
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare props
            int gaji1;
            int gaji2;
            //declare new obj with diff parameter val
            karyawan Karyawan1 = new karyawan("1234","Rafli",3000000);
            karyawan Karyawan2 = new karyawan("4321","Fliw",4000000);
            //output
            Console.WriteLine("No Nik/nama \t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. "+Karyawan1.nik+" "+Karyawan1.nama+"\t\t"+Karyawan1.gajiBulanan);
            Console.WriteLine("1. "+Karyawan2.nik+" "+Karyawan2.nama+"\t\t"+Karyawan2.gajiBulanan);
            Console.WriteLine("\n\nAsyiik Ada Kenaikan Gaji 10%!!");
            //adding 10% promotion based on salary
            gaji1=(10*Karyawan1.gajiBulanan)/100;
            gaji2=(10*Karyawan2.gajiBulanan)/100;
            Console.WriteLine("No Nik/nama \t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. "+Karyawan1.nik+" "+Karyawan1.nama+"\t\t"+(gaji1+Karyawan1.gajiBulanan));
            Console.WriteLine("1. "+Karyawan2.nik+" "+Karyawan2.nama+"\t\t"+(gaji2+Karyawan2.gajiBulanan));
        }
    }
}
