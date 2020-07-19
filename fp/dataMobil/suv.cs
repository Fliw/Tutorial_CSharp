using System;
using System.Threading;

namespace fp
{
    public class suv : abstractMobil
    {
        public override string merk { get; set; }
        public override string warna { get; set; }
        public override int tahun { get; set; }
        public override int harga { get; set; }
        public string statusRentals { get; set; }
        public override void statusRental()
        {
            Console.WriteLine("Mobil ini " + this.statusRentals + " Dirental.");
        }
        public suv()
        {
            Console.Clear();
            Console.WriteLine("Merk Mobil:");
            merk = Console.ReadLine();
            Console.WriteLine("Warna Mobil:");
            warna = Console.ReadLine();
            Console.WriteLine("Tahun produksi:");
            tahun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Harga Rental Perhari:");
            harga = Convert.ToInt32(Console.ReadLine());
            this.merk = merk;
            this.warna = warna;
            this.tahun = tahun;
            this.harga = harga;
            this.statusRentals = "belum";
            Console.Clear();
            Console.WriteLine("Mobil Berhasil Ditambah!");
            Thread.Sleep(1000);
        }
    }
}