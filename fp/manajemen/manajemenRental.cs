using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace fp
{
    public class manajemenRental
    {
        public manajemenRental()
        {
            Console.Clear();
            Console.WriteLine("Page Manajemen Rental!");
            Thread.Sleep(1000);
            int pil = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("1.Daftar Mobil yang sudah disewa");
                Console.WriteLine("2.Daftar Mobil yang belum disewa");
                Console.WriteLine("3.Daftar Semua Mobil");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Pilihan Anda: ");
                pil = Convert.ToInt32(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        showMobilSudahDisewa();
                        break;
                    case 2:
                        showMobilBelumDisewa();
                        break;
                    case 3:
                    showAllMobil();
                        break;
                    case 4:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pilihan Anda Salah!");
                        Thread.Sleep(1000);

                        break;
                }
            } while (pil != 4);
        }
        public void showMobilSudahDisewa()
        {
            Console.Clear();
            int counterSuv = 1,terisi=0;
            foreach (suv mobil in manajemenMobil.listSuv)
            {
                if(mobil.statusRentals=="sudah"){
                Console.WriteLine(counterSuv + ". " + mobil.merk + "\n");
                Console.WriteLine("Warna Mobil = " + mobil.warna);
                Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                counterSuv++;
                terisi++;
                }
            }
            foreach (sedan mobil in manajemenMobil.listSedan)
            {
                if(mobil.statusRentals=="sudah"){
                Console.WriteLine(counterSuv + ". " + mobil.merk + "\n");
                Console.WriteLine("Warna Mobil = " + mobil.warna);
                Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                counterSuv++;
                terisi++;
                }
            }
            if(terisi == 0){
                Console.WriteLine("Maaf Tidak Ada Mobil yang sudah disewa");
            }
            else{
                Console.WriteLine("Ditemukan "+terisi+" Mobil yang berhasil disewa!");
            }
            Console.WriteLine("Enter untuk kembali");
            Console.ReadKey();
            Console.Clear();

        }
        public void showMobilBelumDisewa()
        {
            Console.Clear();
            int counterSuv = 1,terisi=0;
            foreach (suv mobil in manajemenMobil.listSuv)
            {
                if(mobil.statusRentals=="belum"){
                Console.WriteLine(counterSuv + ". " + mobil.merk + "\n");
                Console.WriteLine("Warna Mobil = " + mobil.warna);
                Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                counterSuv++;
                terisi++;
                }
            }
            foreach (sedan mobil in manajemenMobil.listSedan)
            {
                if(mobil.statusRentals=="belum"){
                Console.WriteLine(counterSuv + ". " + mobil.merk + "\n");
                Console.WriteLine("Warna Mobil = " + mobil.warna);
                Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                counterSuv++;
                terisi++;
                }
            }
            if(terisi == 0){
                Console.WriteLine("Semua Mobil Sudah disewa");
            }
            else{
                Console.WriteLine("Ditemukan "+terisi+" Mobil yang Belum disewa!");
            }
            Console.WriteLine("Enter untuk kembali");
            Console.ReadKey();
            Console.Clear();
        }
        public void showAllMobil(){
            int counterSuv=1;
            Console.Clear();
            Console.WriteLine("List Semua Mobil\n");
            foreach (suv mobil in manajemenMobil.listSuv)
            {
                Console.WriteLine(counterSuv + ". " + mobil.merk + "\n");
                Console.WriteLine("Warna Mobil = " + mobil.warna);
                Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                counterSuv++;
            }
            foreach (sedan mobil in manajemenMobil.listSedan)
            {
                Console.WriteLine(counterSuv + ". " + mobil.merk + "\n");
                Console.WriteLine("Warna Mobil = " + mobil.warna);
                Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                counterSuv++;
            }
            Console.WriteLine("total : "+--counterSuv +" Mobil");
            Console.WriteLine("tekan enter untuk kembali");
            Console.ReadKey();
        }
    }
}