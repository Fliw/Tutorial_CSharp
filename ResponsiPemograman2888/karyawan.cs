using System;
namespace ResponsiPemograman2888
{
    public class karyawan
    {
        
        public string nik;
        public string nama;
        public int gajiBulanan;
        public karyawan(string nik,string nama,int gajiBulanan){
            this.nik=nik;
            this.nama=nama;
            if(gajiBulanan<0){
                this.nik="0";
                Console.WriteLine("Maaf Gaji Yang Anda Masukkan Tidak boleh Kurang Dari 0");
            }
            else{
            this.gajiBulanan=gajiBulanan;
            }
        }
    }
}