using System;
namespace collection
{
    public class karyawanHarian : karyawan
    {
        public override string nik {get;set;}
        public override string nama {get;set;}
        public double upahPerJam {get;set;}
        public double jumlahJamKerja {get;set;}
        public override double gaji(){
            return upahPerJam * jumlahJamKerja;
        }
        public karyawanHarian(string nik, string nama, double upahPerJam,double jumlahJamKerja){
            this.nik = nik;
            this.nama = nama;
            this.upahPerJam = upahPerJam;
            this.jumlahJamKerja = jumlahJamKerja;
            Console.WriteLine("karyawan Harian baru telah ditambah!");
        }
    }
}