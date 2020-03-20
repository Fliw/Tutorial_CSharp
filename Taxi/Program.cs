using System;

namespace Tugas
{   
    public class Program
    {   
        //Disini Kita Membuat Class taxi Didalam Class program Dan Sejajar Dengan Class Main
        public class taxi{

        //Deklarasi Property Dan Assign Value Secara lgsg.
        public string DriverName = "Kang Mamat";
        public Boolean onDuty = false;
        public int NumPassenger = 4;

        //Deklarasi Metode Yang Akan Mengambil Nilai Property Berdasarkan Akses Modifier yang diberikan 
        public void TaxiInfo(){
            Console.WriteLine("Hai, Nama Saya " + this.DriverName + " Saya Adalah Supir Taxi Yang Akan Mengangkut " + this.NumPassenger + ", Selamat Menikmati Perjalanan kak.\n");
        }
        public void PickUpPassenger(){
            Console.WriteLine("Hai, Aku Sekarang Sedang Menjemput " + this.NumPassenger + " Penumpang Sekarang !\n");
        }
        public void DropOffPassenger(){
            Console.WriteLine("Hai, Aku Sekarang Sedang Menurunkan " + this.NumPassenger + " Penumpang Sekarang !\n");
        }
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Objek Pertama Yang Masih Orisinil Tanpa Pengubahan Property \n");
            
            //membuat objek orisinil, semua nilai property default saat di construct
            taxi Taksilama = new taxi();

            //memanggil setiap fungsi dari objek ini
            Taksilama.TaxiInfo();
            Taksilama.PickUpPassenger();
            Taksilama.DropOffPassenger();
            Console.WriteLine("Objek Kedua, Setelah Value Property Kita Ubah \n");

            //membuat objek baru, namun value dari property akan kita replace disini.
            taxi Gotaxi = new taxi();

            //replace property
            Gotaxi.DriverName = "Kang Rapli";
            Gotaxi.onDuty = true;
            Gotaxi.NumPassenger = 10;
            
            //panggil fungsi objek
            Gotaxi.TaxiInfo();
            Gotaxi.PickUpPassenger();
            Gotaxi.DropOffPassenger();
            
        }
    }
}
