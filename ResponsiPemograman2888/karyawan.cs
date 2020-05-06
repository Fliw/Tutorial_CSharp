using System;
namespace ResponsiPemograman2888
{
    //creating a class
    public class karyawan
    {
        //declare props
        public string nik;
        public string nama;
        public int gajiBulanan;
        //declare constructor that takes 3 args
        public karyawan(string nik,string nama,int gajiBulanan){
            //assign val
            this.nik=nik;
            this.nama=nama;
            //branching for assign val
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