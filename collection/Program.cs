using System;
using System.Collections;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawanHarian karyawan1 = new karyawanHarian();
            karyawanTetap karyawan2 = new karyawanTetap();
            sales karyawan3 = new sales();

            karyawan1.nik = "1312314";
            karyawan1.nama = "Muhammad Rafly Indrawan";
            karyawan1.upahPerJam = 30000;
            karyawan1.jumlahJamKerja = 10;
            karyawan2.nik = "2316424";
            karyawan2.nama = "Mas Agus Indihome";
            karyawan2.gajiBulanan = 4000000;
            karyawan3.nik = "59146129";
            karyawan3.nama = "Randhika Prawira";
            karyawan3.jumlahPenjualan = 200;
            karyawan3.komisi = 3000;
            List<karyawan> listKaryawan = new List<karyawan>();
            listKaryawan.Add(karyawan1);
            listKaryawan.Add(karyawan2);
            listKaryawan.Add(karyawan3);
            int counter =1;
            foreach (karyawan karyawan in listKaryawan){
                Console.WriteLine(counter+" NIK : "+karyawan.nik+", Nama : "+karyawan.nama+", Gaji : "+karyawan.gaji()+" \n ");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
