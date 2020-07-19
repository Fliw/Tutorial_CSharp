using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace fp
{
    public class manajemenMobil
    {
        //constructing first
        public manajemenMobil()
        {
            Console.Clear();
            Console.WriteLine("Page Manajemen Mobil!");
            Thread.Sleep(1000);
            int pil = 0;
            List<sedan> listSedan = new List<sedan>();
            List<suv> listSuv = new List<suv>();
            do
            {
                Console.WriteLine("Main Menu Manajemen Mobil\n");
                Console.WriteLine("1.Tambah Mobil");
                Console.WriteLine("2.Lihat Daftar Mobil");
                Console.WriteLine("3.Hapus Mobil Dari Daftar");
                Console.WriteLine("4.exit");
                Console.WriteLine("Pilihan Anda: ");
                pil = Convert.ToInt32(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("masukkan jenis mobil:");
                        Console.WriteLine("1.SEDAN");
                        Console.WriteLine("2.SUV");
                        Console.WriteLine("Pilihan anda:");
                        int pil1 = Convert.ToInt32(Console.ReadLine());
                        switch (pil1)
                        {
                            case 1:
                                listSedan.Add(new sedan());
                                break;
                            case 2:
                                listSuv.Add(new suv());
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Pilihan Anda Salah!");
                                Thread.Sleep(1000);
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Jenis Mobil: ");
                        Console.WriteLine("1.SEDAN");
                        Console.WriteLine("2.SUV");
                        Console.WriteLine("Pilihan anda:");
                        int pil2 = Convert.ToInt32(Console.ReadLine());
                        switch (pil2)
                        {
                            case 1:
                                Console.Clear();
                                int counterSedan = 1;
                                foreach (sedan mobil in listSedan)
                                {
                                    Console.WriteLine(counterSedan + ". " + mobil.merk + "\n");
                                    Console.WriteLine("Warna Mobil = " + mobil.warna);
                                    Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                                    Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                                    counterSedan++;
                                }
                                Console.WriteLine("Enter untuk kembali");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                int counterSuv = 1;
                                foreach (suv mobil in listSuv)
                                {
                                    Console.WriteLine(counterSuv + ". " + mobil.merk + "\n");
                                    Console.WriteLine("Warna Mobil = " + mobil.warna);
                                    Console.WriteLine("Tahun Produksi = " + mobil.tahun);
                                    Console.WriteLine("Harga Rental Perjam = " + mobil.harga + "\n\n");
                                    counterSuv++;
                                }
                                Console.WriteLine("Enter untuk kembali");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Pilihan Anda Salah!");
                                Thread.Sleep(1000);
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Jenis Mobil: ");
                        Console.WriteLine("1.SEDAN");
                        Console.WriteLine("2.SUV");
                        Console.WriteLine("Pilihan anda:");
                        int pil3 = Convert.ToInt32(Console.ReadLine());
                        switch (pil3)
                        {
                            case 1:
                                Console.Clear();
                                int counterSedan = 1;
                                foreach (sedan mobil in listSedan)
                                {
                                    Console.WriteLine(counterSedan + ". " + mobil.merk + "\n");
                                    counterSedan++;
                                }
                                Console.WriteLine("Masukkan nomor mobil yang ingin dihapus :");
                                int hapusSedan = Convert.ToInt32(Console.ReadLine());
                                listSedan.RemoveAt(hapusSedan-1);
                                Thread.Sleep(500);
                                Console.WriteLine("Mobil berhasil dihapus!");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 2:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pilihan Anda Salah!");
                        Thread.Sleep(1000);
                        break;
                }
            } while (pil != 4);
        }
    }
}