using System;
using System.Collections;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // karyawanHarian karyawan1 = new karyawanHarian();
            // karyawanTetap karyawan2 = new karyawanTetap();
            // sales karyawan3 = new sales();

            // karyawan1.nik = "1312314";
            // karyawan1.nama = "Muhammad Rafly Indrawan";
            // karyawan1.upahPerJam = 30000;
            // karyawan1.jumlahJamKerja = 10;

            // karyawan2.nik = "2316424";
            // karyawan2.nama = "Mas Agus Indihome";
            // karyawan2.gajiBulanan = 4000000;

            // karyawan3.nik = "59146129";
            // karyawan3.nama = "Randhika Prawira";
            // karyawan3.jumlahPenjualan = 200;
            // karyawan3.komisi = 3000;

            // listKaryawan.Add(karyawan1);
            // listKaryawan.Add(karyawan2);
            // listKaryawan.Add(karyawan3);
            utama:
            List<karyawan> listKaryawan = new List<karyawan>();
            Console.WriteLine("1.Tambah Data Karyawan\n");
            Console.WriteLine("2.Hapus Data Karyawan\n");
            Console.WriteLine("3.Tampil Data Karyawan\n");
            Console.WriteLine("Exit");
            string pil = Console.ReadLine();

            if (pil == "1")
            {
                Console.WriteLine("Pilih Karyawan\n");
                Console.WriteLine("1.Karyawan Harian\n");
                Console.WriteLine("2.Karyawan Tetap\n");
                Console.WriteLine("3.Sales\n");
                string pilihan = Console.ReadLine();
                if (pilihan == "1")
                {
                    Console.WriteLine("Masukkan NIK Anda:");
                    string nik = Console.ReadLine();
                    Console.WriteLine("Masukkan Nama Anda:");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Masukkan Upah Per Jam Anda:");
                    int upahPerJam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan Jumlah Jam Kerja Anda:");
                    int jumlahJamKerja = Convert.ToInt32(Console.ReadLine());
                    listKaryawan.Add(new karyawanHarian(nik, nama, upahPerJam, jumlahJamKerja));
                    goto utama;
                }
            }
            else if (pil == "2")
            {
                // hapusData();
            }
            else if (pil == "3")
            {
                Console.WriteLine("Data Karyawan\n");
                listKaryawan.ForEach(Console.WriteLine);
            }
            else if (pil == "4")
            {
                Console.WriteLine("Terimakasih !");
                Console.ReadKey();
            }
            else
            {

            }


        }
    }
}
